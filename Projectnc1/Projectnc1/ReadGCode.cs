using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectnc1
{
    class ReadGCode
    {
        static string currentMode = "";

        static public float[] readGCodeLine(string line)
        {
            float[] movements = {0,0,0};
            currentMode = getMode(line);
            System.Windows.Forms.MessageBox.Show("Napaka!!");
            switch (currentMode)
            {
                case "G00":
                    
                    break;
                case "G01":
                    break;
                case "G02":
                    break;
                case "G03":
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Unable to read G code command type", "Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                    break;
            }

            return movements;
        }

        /// <summary>
        /// From G code line exstract movement type
        /// </summary>
        /// <param name="line">G code line</param>
        static string getMode(string line)
        {
            //Checks what type of the command line contains
            if (line.Contains("G00"))
            {
                currentMode = "G00";
            }
            else if (line.Contains("G01"))
            {
                currentMode = "G01";
            }
            else if (line.Contains("G02"))
            {
                currentMode = "G02";
            }
            else if (line.Contains("G03"))
            {
                currentMode = "G03";
            }
            else
            {
              
            }
            return currentMode;  
        }



    }
}
