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
        



        public MainWindow()
        {
            //Form start
            InitializeComponent();

            //Set up connection object
            USBconnection = new ConnectionUSB();                        //Set up connection with default settings
            comboBoxCOMports.Items.Add("Please select...");             //Add "Pleas select..." item to the combo box           
            comboBoxCOMports.Items.AddRange(USBconnection.portNames);   //Add Found port names to the combo box
            comboBoxCOMports.SelectedIndex = 0;                         //Set selected index

            comboBoxBaudRate.SelectedIndex = 0;



        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool success = USBconnection.ConnectUSB(Convert.ToInt32(comboBoxBaudRate.SelectedItem), Convert.ToString(comboBoxCOMports.SelectedItem));

            if (success)
            {
                comboBoxBaudRate.Enabled = false;
                comboBoxCOMports.Enabled = false;

            }
            else
            {
                MessageBox.Show("Connection to the machine was NOT successful", "Error");
            }

        }


        private void btnSelectGFile_Click(object sender, EventArgs e)
        {
            Interpolation3Axis interpolation = new Interpolation3Axis(3);
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
            double[] ppositions = {0,0,0};

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

                switch (currentCommand)
                {
                    case "G00":
                        ReadGCode.readG00G01(line);
                        positions = ReadGCode.positions;
                        Interpolation3Axis.rapidPositioning(positions);
                        //send data
                        break;
                    case "G01":
                        ReadGCode.readG00G01(line);
                        positions = ReadGCode.positions;
                        Interpolation3Axis.linearInterpolation(positions);
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
            ConnectionUSB.SendAxisData('1', 8226, 8226, 8226, 800);
        }


    }


}
