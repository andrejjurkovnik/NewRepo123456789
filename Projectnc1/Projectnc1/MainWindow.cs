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



    }
}
