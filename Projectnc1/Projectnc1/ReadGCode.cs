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

            //Checks what type of the command line contains
            if (line.Contains("G00"))
            {
                currentMode = "G00";
            }
            else if(line.Contains("G01"))
            {
                currentMode = "G01";
            }
            else if(line.Contains("G02"))
            {
                currentMode = "G02";
            }
            else if(line.Contains("G03"))
            {
                currentMode = "G03";
            }
            else
            {
                
            }

            return movements;
        }



    }
}
