using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//delete this comment
namespace Projectnc1
{
    class ReadGCode
    {

        static public double[] positions;

        public ReadGCode(int stMotirjev)
        {
            positions = new double[stMotirjev];
        }

        static public string getCommandType(string line)
        {

            Regex Gtype = new Regex("[G][0-9][0-9]");       //Regular expresion for serching G.... 
            Match GtypeMatch = Gtype.Match(line);           //Searches for pateren

            if (GtypeMatch.Success)                          //If search was successful return value else return string "previous"
            {
                return GtypeMatch.Value;
            }
            else
            {
                return "previous";
            }


        }

        static public double[] readG00G01(string line, double[] pposition)
        {
            double[] values;//what is the point of that, function can be void!
            values = new double[3];

            //Searches for X value
            Regex regexX = new Regex("[X][0-9]?[0-9]?[0-9]?[0-9]?[0-9]?.?[0-9]?[0-9]?[0-9]?[0-9]?[0-9]");  //Regular expresion of X movement
            Match matchX = regexX.Match(line);

            if (matchX.Success)                          //If search was successful return value else return string "previous"
            {
                positions[0] = double.Parse(matchX.Value.Replace("X", ""), CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                positions[0] = pposition[0];
            }

            //Searches for Y value
            Regex regexY = new Regex("[Y][0-9]?[0-9]?[0-9]?[0-9]?[0-9]?.?[0-9]?[0-9]?[0-9]?[0-9]?[0-9]");  //Regular expresion of Y movement
            Match matchY = regexY.Match(line);

            if (matchY.Success)                          //If search was successful return value else return string "previous"
            {
                positions[1] = double.Parse(matchY.Value.Replace("Y", ""), CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                positions[1] = pposition[1];
            }

            //Searches for Z value
            Regex regexZ = new Regex("[Z][0-9]?[0-9]?[0-9]?[0-9]?[0-9]?.?[0-9]?[0-9]?[0-9]?[0-9]?[0-9]");  //Regular expresion of Z movement
            Match matchZ = regexZ.Match(line);

            if (matchZ.Success)                          //If search was successful return value else return string "previous"
            {
                positions[2] = double.Parse(matchZ.Value.Replace("Z", ""), CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                positions[2] = pposition[2];
            }
            return values;

        }





    }
}
