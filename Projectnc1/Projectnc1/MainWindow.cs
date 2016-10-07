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
            //Briši komentar
            double[] positions;
            positions = new double[3];
            double[] ppositions = { 0, 0, 0 };

            foreach (string line in fileContent)
            {
                //Convert to upper
                line.ToUpper();

                //Replace comma with dot
                line.Replace(",", ".");

                string currentCommand = "G00";
                string returnCommandType = ReadGCode.getCommandType(line);

                if (returnCommandType == "previous")
                {
                    currentCommand = returnCommandType;
                }

                double[] currentAxisPositions;
                currentAxisPositions = new double[3];

                switch (currentCommand)
                {
                    case "G00":
                        currentAxisPositions[0] = interpolation.Axis[0].position;
                        currentAxisPositions[1] = interpolation.Axis[1].position;
                        currentAxisPositions[2] = interpolation.Axis[2].position;
                        ReadGCode.readG00G01(line, currentAxisPositions);
                        positions = ReadGCode.positions;
                        interpolation.rapidPositioning(positions);
                        //send data
                        break;
                    case "G01":
                        currentAxisPositions = new double[3];
                        currentAxisPositions[0] = interpolation.Axis[0].position;
                        currentAxisPositions[1] = interpolation.Axis[1].position;
                        currentAxisPositions[2] = interpolation.Axis[2].position;
                        ReadGCode.readG00G01(line, currentAxisPositions);
                        ReadGCode.readG00G01(line, currentAxisPositions);
                        positions = ReadGCode.positions;
                        interpolation.linearInterpolation(positions);
                        break;
                    default:
                        break;
                }
            }
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
            ConnectionUSB.SendAxisData('0', 8226, 8226, 8226, Convert.ToInt32(interpolation.Axis[0].stepsInstruction));
            ConnectionUSB.SendAxisData('1', 8226, 8226, 8226, Convert.ToInt32(interpolation.Axis[1].stepsInstruction));
            ConnectionUSB.SendAxisData('2', 8226, 8226, 8226, Convert.ToInt32(interpolation.Axis[2].stepsInstruction));
            ConnectionUSB.SendMoveCommand();
        }


    }


}
