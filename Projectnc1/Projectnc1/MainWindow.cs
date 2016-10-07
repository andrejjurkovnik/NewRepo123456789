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
        string filePath = "";
        string[] fileContent;
        double[][] Movements;

        ConnectionUSB USBport;

        public MainWindow()
        {
            InitializeComponent();
            USBport = new ConnectionUSB();
                   
            
           
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
                        ConnectionUSB.SendAxisData('0', 8224, 8224, 8224, 800);
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
    }


}
