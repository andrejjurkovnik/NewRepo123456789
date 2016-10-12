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
using System.Threading;

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
        ReadGCode reader;

        public MainWindow()
        {
            //Form start
            InitializeComponent();

            //Set up connection object
            USBconnection = new ConnectionUSB();                        //Set up connection with default settings
            comboBoxCOMports.Items.Add("Please select...");             //Add "Pleas select..." item to the combo box           
            comboBoxCOMports.Items.AddRange(USBconnection.portNames);   //Add Found port names to the combo box
            comboBoxCOMports.SelectedIndex = 0;                         //Set selected COMport index

            comboBoxBaudRate.SelectedIndex = 0;                         //Set selected Baud rate index

            interpolation = new Interpolation3Axis(3);
        }

        private void SendExecutingGCode()
        {
            try                                         //try catch loop is because we can move axis with NULL reader.GcodeExecuting
            {
                reader.executingLine++;
                if (reader.executingLine == interpolation.Axis[0].steps.Length)
                {
                    reader.GcodeExecuting = false;
                }
                if (reader.GcodeExecuting)
                {
                    USBconnection.SendAxisData('0', 8224, 8224, 8224, Convert.ToInt32(interpolation.Axis[0].steps[reader.executingLine]));
                    USBconnection.SendAxisData('1', 8224, 8224, 8224, Convert.ToInt32(interpolation.Axis[1].steps[reader.executingLine]));
                    USBconnection.SendAxisData('2', 8224, 8224, 8224, Convert.ToInt32(interpolation.Axis[2].steps[reader.executingLine]));
                    Thread.Sleep(300);
                    USBconnection.SendMoveCommand();
                }
            }
            catch
            { }
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
            
            reader = new ReadGCode(3);

            // Get G code file path
            openFileDialog.ShowDialog();                                    //Show open file dialog
            filePath = openFileDialog.FileName;                             //Save file path
            txtBoxFileSelected.Text = openFileDialog.SafeFileName;          //Display Job 

            //Read all lines
            fileContent = File.ReadAllLines(@filePath);

            interpolation.Axis[0].SetInstructionLength(fileContent.Length);
            interpolation.Axis[1].SetInstructionLength(fileContent.Length);
            interpolation.Axis[2].SetInstructionLength(fileContent.Length);

            double[] positions;
            positions = new double[3];
            int successiveMoveCommand = 0;

            foreach (string line in fileContent)
            {
                //Convert to upper
                line.ToUpper();

                //Replace comma with dot
                line.Replace(",", ".");

                reader.SetGmode(line);

                double[] currentAxisPositions;
                currentAxisPositions = new double[3];

                switch (reader.GcodeMode)
                {
                    case 0:
                        //set speed to default feed rate
                        currentAxisPositions[0] = interpolation.Axis[0].position;
                        currentAxisPositions[1] = interpolation.Axis[1].position;
                        currentAxisPositions[2] = interpolation.Axis[2].position;
                        reader.readG00G01(line, currentAxisPositions);
                        positions = reader.positions;
                        interpolation.rapidPositioning(positions);
                        for(int i=0; i<3; i++)
                        {
                            interpolation.Axis[i].steps[successiveMoveCommand] = interpolation.Axis[i].stepsInstruction;
                        }
                        successiveMoveCommand++;
                        break;
                    case 1:
                        currentAxisPositions[0] = interpolation.Axis[0].position;
                        currentAxisPositions[1] = interpolation.Axis[1].position;
                        currentAxisPositions[2] = interpolation.Axis[2].position;
                        reader.readG00G01(line, currentAxisPositions);
                        reader.readG00G01(line, currentAxisPositions);
                        positions = reader.positions;
                        interpolation.linearInterpolation(positions);
                        for (int i = 0; i < 3; i++)
                        {
                            interpolation.Axis[i].steps[successiveMoveCommand] = interpolation.Axis[i].stepsInstruction;
                            interpolation.Axis[i].speed[successiveMoveCommand] = interpolation.Axis[i].speedInstruction;
                        }
                        successiveMoveCommand++;
                        break;
                    default:
                        break;
                }
            }
            StartExecutingGCode();
        }

        private void StartExecutingGCode()
        {
            reader.executingLine = 0;
            reader.GcodeExecuting = true;
            foreach(int a in interpolation.Axis[0].steps)
            {
                testTextbox.Text = testTextbox.Text + Environment.NewLine + Convert.ToString(a);
            }
            USBconnection.SendAxisData('0', 8224, 8224, 8224, Convert.ToInt32(interpolation.Axis[0].steps[reader.executingLine]));
            USBconnection.SendAxisData('1', 8224, 8224, 8224, Convert.ToInt32(interpolation.Axis[1].steps[reader.executingLine]));
            USBconnection.SendAxisData('2', 8224, 8224, 8224, Convert.ToInt32(interpolation.Axis[2].steps[reader.executingLine]));
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
            USBconnection.SendAxisData('0', 8224, 8224, 8224, Convert.ToInt32(interpolation.Axis[0].stepsInstruction));
            USBconnection.SendAxisData('1', 8224, 8224, 8224, Convert.ToInt32(interpolation.Axis[1].stepsInstruction));
            USBconnection.SendAxisData('2', 8224, 8224, 8224, Convert.ToInt32(interpolation.Axis[2].stepsInstruction));
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
