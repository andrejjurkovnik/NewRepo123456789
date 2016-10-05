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
            Interpolation3Axis interpolation = new Interpolation3Axis(3);

            // Get G code file path
            openFileDialog.ShowDialog();                                    //Show open file dialog
            filePath = openFileDialog.FileName;                             //Save file path
            txtBoxFileSelected.Text = openFileDialog.SafeFileName;          //Display Job 

            //Read all lines
            fileContent = File.ReadAllLines(@filePath);

            double[] positions;
            positions = new double[3];


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
                    Interpolation3Axis.rapidPositioning(positions);

                    //testTextbox.Text = Convert.ToString(Interpolation3Axis.Axis[0].stepsInstruction);
                    testTextbox.Text = testTextbox.Text + Environment.NewLine + Convert.ToString(Interpolation3Axis.Axis[0].position);
                    testTextbox.Text = testTextbox.Text + Environment.NewLine + Convert.ToString(Interpolation3Axis.Axis[1].position);
                    testTextbox.Text = testTextbox.Text + Environment.NewLine + Convert.ToString(Interpolation3Axis.Axis[2].position);

                }


            }


          
                
        }
    }


}
