using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Input;
using System.IO.Ports;

namespace Projectnc1
{
    public partial class MainWindow : Form
    {

        /// <summary>
        /// Global objects
        /// </summary>
        ///
        ConnectionUSB USBconnection;    //USB connection object
        string filePath = "";           //G file path
        string[] fileContent;
        Interpolation3Axis interpolation;
        int GcodeIndex = 0;
        int Gmode = 0;

        public MainWindow()
        {
            //Form start
            InitializeComponent();
            this.KeyPreview = true;

            //Set up connection object
            USBconnection = new ConnectionUSB();                        //Set up connection with default settings
            comboBoxCOMports.Items.Add("Please select...");             //Add "Pleas select..." item to the combo box           
            comboBoxCOMports.Items.AddRange(USBconnection.portNames);   //Add Found port names to the combo box
            comboBoxCOMports.SelectedIndex = 0;                         //Set selected COMport index

            comboBoxBaudRate.SelectedIndex = 0;                         //Set selected Baud rate index

            interpolation = new Interpolation3Axis(3);
            USBconnection.USBserialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (USBconnection.USBserialPort.ReadChar() == 'r')
            {
                double[] positions;
                positions = new double[3];

                fileContent[GcodeIndex].ToUpper();
                fileContent[GcodeIndex].Replace(",", ".");

                if (fileContent[GcodeIndex].Contains("G00")) Gmode = 0;
                else if (fileContent[GcodeIndex].Contains("G01")) Gmode = 1;
                else if (fileContent[GcodeIndex].Contains("G02")) Gmode = 2;
                else if (fileContent[GcodeIndex].Contains("G03")) Gmode = 3;
                else if (fileContent[GcodeIndex].Contains("M02")) Gmode = 200;

                double[] currentAxisPositions;
                currentAxisPositions = new double[3];

                switch (Gmode)
                {
                    case 0:
                        currentAxisPositions[0] = interpolation.Axis[0].position;
                        currentAxisPositions[1] = interpolation.Axis[1].position;
                        currentAxisPositions[2] = interpolation.Axis[2].position;
                        ReadGCode.readG00G01(fileContent[GcodeIndex], currentAxisPositions);
                        positions = ReadGCode.positions;
                        interpolation.rapidPositioning(positions);
                        //send data
                        break;
                    case 1:
                        currentAxisPositions = new double[3];
                        currentAxisPositions[0] = interpolation.Axis[0].position;
                        currentAxisPositions[1] = interpolation.Axis[1].position;
                        currentAxisPositions[2] = interpolation.Axis[2].position;
                        ReadGCode.readG00G01(fileContent[GcodeIndex], currentAxisPositions);
                        positions = ReadGCode.positions;
                        interpolation.linearInterpolation(positions);
                        break;
                    case 200:
                        break;
                    default:
                        break;
                }

                if(Gmode < 10)
                {
                    GcodeIndex++;

                    USBconnection.SendAxisData('0', 8226, 8226, 8226, Convert.ToInt32(interpolation.Axis[0].stepsInstruction));
                    USBconnection.SendAxisData('1', 8226, 8226, 8226, Convert.ToInt32(interpolation.Axis[1].stepsInstruction));
                    USBconnection.SendAxisData('2', 8226, 8226, 8226, Convert.ToInt32(interpolation.Axis[2].stepsInstruction));
                    USBconnection.SendMoveCommand();
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool success = USBconnection.ConnectUSB(Convert.ToInt32(comboBoxBaudRate.SelectedItem), Convert.ToString(comboBoxCOMports.SelectedItem));

            if (success)
            {
                comboBoxBaudRate.Enabled = false;
                comboBoxCOMports.Enabled = false;
                btnSendData.Enabled = true;
            }
            else
            {
                MessageBox.Show("Connection to the machine was NOT successful", "Error");
            }
        }


        private void btnSelectGFile_Click(object sender, EventArgs e)
        {
            
            ReadGCode reader = new ReadGCode(3);

            // Get G code file path
            openFileDialog.ShowDialog();                                    //Show open file dialog
            filePath = openFileDialog.FileName;                             //Save file path
            txtBoxFileSelected.Text = openFileDialog.SafeFileName;          //Display Job 

            //Read all lines
            fileContent = File.ReadAllLines(@filePath);
            StartExecuteGFile();
        }

        private void StartExecuteGFile()
        {
            GcodeIndex = 0;
            //USBconnection.SendAxisData('0', 8226, 8226, 8226, 0);
            //USBconnection.SendAxisData('1', 8226, 8226, 8226, 0);
            //USBconnection.SendAxisData('2', 8226, 8226, 8226, 0);
            //USBconnection.SendMoveCommand();
            USBconnection.SendAxisData('0', 8226, 8226, 8226, 0);
            USBconnection.SendAxisData('1', 8226, 8226, 8226, 0);
            USBconnection.SendAxisData('2', 8226, 8226, 8226, 0);
            USBconnection.SendMoveCommand();
        }



        private void btnCOMportsRefresh_Click(object sender, EventArgs e)
        {
            USBconnection.getPorts();
            comboBoxCOMports.Items.Clear();
            comboBoxCOMports.Items.Add("Please select...");             //Add "Pleas select..." item to the combo box           
            comboBoxCOMports.Items.AddRange(USBconnection.portNames);   //Add Found port names to the combo box
            comboBoxCOMports.SelectedIndex = 0;                         //Set selected index
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            double[] movePositions;
            movePositions = new double[3];
            try
            {
                movePositions[0] = interpolation.Axis[0].position + Convert.ToDouble(tbMoveX.Text);
            }
            catch
            {
                MessageBox.Show("Invalid number");
                movePositions[0] = interpolation.Axis[0].position;
                tbMoveX.Text = "0";
            }
            try
            {
                movePositions[1] = interpolation.Axis[1].position + Convert.ToDouble(tbMoveY.Text);
            }
            catch
            {
                MessageBox.Show("Invalid number");
                movePositions[1] = interpolation.Axis[1].position;
                tbMoveY.Text = "0";
            }
            try
            {
                movePositions[2] = interpolation.Axis[2].position + Convert.ToDouble(tbMoveZ.Text);
            }
            catch
            {
                MessageBox.Show("Invalid number");
                movePositions[2] = interpolation.Axis[2].position;
                tbMoveZ.Text = "0";
            }
            interpolation.rapidPositioning(movePositions);
            USBconnection.SendAxisData('0', 8226, 8226, 8226, Convert.ToInt32(interpolation.Axis[0].stepsInstruction));
            USBconnection.SendAxisData('1', 8226, 8226, 8226, Convert.ToInt32(interpolation.Axis[1].stepsInstruction));
            USBconnection.SendAxisData('2', 8226, 8226, 8226, Convert.ToInt32(interpolation.Axis[2].stepsInstruction));
            USBconnection.SendMoveCommand();
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.PageUp:
                    break;
                case Keys.PageDown:
                    break;
                case Keys.Up:
                    break;
                case Keys.Down:
                    break;
                case Keys.Left:
                    break;
                case Keys.Right:
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }


}
