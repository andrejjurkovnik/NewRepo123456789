using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Projectnc1
{
    class ReadGCode
    {

        static public string getCommandType(string line)
        {

            Regex Gtype = new Regex("[G][0-9][0-9]");       //Regular expresion for serching G.... 
            Match GtypeMatch = Gtype.Match(line);           //Searches for pateren

            if(GtypeMatch.Success)                          //If search was successful return value else return string "previous"
            {
                return GtypeMatch.Value;
            }
            else
            {
                return "previous";
            }


        }



        static public float[] readG00G01(string line)
        {
            float[] values;
            values = new float[3];

            //Searches for X value
            Regex regexX = new Regex("[X][0-9]?[0-9]?[0-9]?[0-9]?[0-9]?.?[0-9]?[0-9]?[0-9]?[0-9]?[0-9]");  //Regular expresion of X movement
            Match matchX = regexX.Match(line);

            if (matchX.Success)                          //If search was successful return value else return string "previous"
            {
                values[0] = float.Parse(matchX.Value, CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                values[0] = -2000000000f;
            }

            //Searches for Y value
            Regex regexY = new Regex("[Y][0-9]?[0-9]?[0-9]?[0-9]?[0-9]?.?[0-9]?[0-9]?[0-9]?[0-9]?[0-9]");  //Regular expresion of X movement
            Match matchY = regexY.Match(line);

            if (matchY.Success)                          //If search was successful return value else return string "previous"
            {
                values[1] = float.Parse(matchY.Value, CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                values[1] = -2000000000f;
            }

            //Searches for Z value
            Regex regexZ = new Regex("[Z][0-9]?[0-9]?[0-9]?[0-9]?[0-9]?.?[0-9]?[0-9]?[0-9]?[0-9]?[0-9]");  //Regular expresion of X movement
            Match matchZ = regexX.Match(line);

            if (matchZ.Success)                          //If search was successful return value else return string "previous"
            {
                values[3] = float.Parse(matchZ.Value, CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                values[3] = -2000000000f;
            }


            return values;

        }

        


        
    }
}
