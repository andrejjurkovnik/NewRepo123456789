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

            int pos_x;

            foreach (string line in fileContent)
            {
                string[] words;
                words = line.Split(' ');
                foreach (string aa in words)
                {
                    if (line.Contains("X"))
                    {
                        testTextbox.Text = words[1];
                    }
                }
                
            }
                
        }
    }


}
