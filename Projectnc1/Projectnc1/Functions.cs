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
using System.Windows.Input;

namespace Projectnc1
{
    public partial class MainWindow : Form
    {


        private void StartExecuteGFile()
        {
            GcodeIndex = 0;
            //USBconnection.SendAxisData('0', 8226, 8226, 8226, 0);
            //USBconnection.SendAxisData('1', 8226, 8226, 8226, 0);
            //USBconnection.SendAxisData('2', 8226, 8226, 8226, 0);
            //USBconnection.SendMoveCommand();
            USBconnection.SendAxisData('0', 8226, 8226, 8226, 0);
            USBconnection.SendAxisData('1', 8226, 8226, 8226, 0);
            USBconnection.SendAxisData('2', 8226, 8226, 8226, 0);
            USBconnection.SendMoveCommand();
        }



    }
}
