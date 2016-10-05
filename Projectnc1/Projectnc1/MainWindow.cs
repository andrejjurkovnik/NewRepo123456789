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
        float[][] Movements;

        public MainWindow()
        {
            InitializeComponent();

                   
            
           
        }


        private void btnSelectGFile_Click(object sender, EventArgs e)
        {

            // Get G code file path
            openFileDialog.ShowDialog();                                    //Show open file dialog
            filePath = openFileDialog.FileName;                             //Save file path
            txtBoxFileSelected.Text = openFileDialog.SafeFileName;          //Display Job 

            //Read all lines
            fileContent = File.ReadAllLines(@filePath);

            float[] positions;
            positions = new float[3];


            foreach (string line in fileContent)
            {
                //Convert to upper
                line.ToUpper();

                //Replace comma with dot
                line.Replace(",", ".");


                string currentType = "G00";
                string returnType = ReadGCode.getCommandType(line);

                

                if (returnType == "previous")
                {
                    currentType = returnType;
                }


                if (currentType == "G00" || currentType == "G01")
                {
                    positions = ReadGCode.readG00G01(line);

                }


            }


          
                
        }
    }


}
