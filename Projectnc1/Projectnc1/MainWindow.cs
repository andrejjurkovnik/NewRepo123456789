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
            

            foreach (string s in fileContent)
            {
                //Convert to upper
                s.ToUpper();

                //Replace comma with dot
                s.Replace(",", ".");

                //Find X movement
                Regex regexX = new Regex("[X][0-9]?[0-9]?[0-9]?.?[0-9]?[0-9]");  //Regular expresion of X movement
                Match matchX = regexX.Match(s);
                testTextbox.AppendText("X movements  ");
                if (matchX.Success)
                {
                    testTextbox.AppendText(float.Parse(matchX.Value.Replace("X", ""), CultureInfo.InvariantCulture.NumberFormat).ToString() + Environment.NewLine);
                }
                else
                {
                    testTextbox.AppendText("0" + Environment.NewLine);
                }


                //Find Y movement
                Regex regexY = new Regex("[Y][0-9]?.?[0-9]?[0-9]");  //Regular expresion of X movement
                Match matchY = regexY.Match(s);
                testTextbox.AppendText("Y movements  ");
                if (matchY.Success)
                {
                    testTextbox.AppendText(float.Parse(matchY.Value.Replace("Y", ""), CultureInfo.InvariantCulture.NumberFormat).ToString() + Environment.NewLine);
                }
                else
                {
                    testTextbox.AppendText("0" + Environment.NewLine);
                }
                //Find Z movement
                Regex regexZ = new Regex("[Z][0-9]?.?[0-9]?[0-9]");  //Regular expresion of X movement
                Match matchZ = regexZ.Match(s);
                testTextbox.AppendText("Z movements  ");
                if (matchZ.Success)
                {
                    testTextbox.AppendText(float.Parse(matchZ.Value.Replace("Z", ""), CultureInfo.InvariantCulture.NumberFormat).ToString() + Environment.NewLine);
                }
                else
                {
                    testTextbox.AppendText("0" + Environment.NewLine);
                }

                testTextbox.AppendText("----------------------" +Environment.NewLine);
            }



          
                
        }
    }


}
