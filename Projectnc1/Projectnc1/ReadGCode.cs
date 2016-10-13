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

        public bool GcodeExecuting = false;
        public int executingLine = 0;

        public double[] positions;
        public int GcodeMode = 0;

        public ReadGCode(int stMotirjev)
        {
            positions = new double[stMotirjev];
        }

        public void SetGmode(string line)
        {
            if (line.Contains("G00")) GcodeMode = 0;
            else if (line.Contains("G01")) GcodeMode = 1;
            else if (line.Contains("G02")) GcodeMode = 2;
            else if (line.Contains("G03")) GcodeMode = 3;
        }

        public double[] readG00G01(string line, double[] currentAxisPosition)
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
                positions[0] = currentAxisPosition[0];
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
                positions[1] = currentAxisPosition[1];
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
                positions[2] = currentAxisPosition[2];
            }
            return values;

        }
    }
}
