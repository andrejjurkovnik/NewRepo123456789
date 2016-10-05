using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Projectnc1
{
    class ConnectionUSB
    {
        static SerialPort USBserialPort = new SerialPort();
        public ConnectionUSB()
        {
            USBserialPort = new SerialPort();
            USBserialPort.BaudRate = 9600;//default
        }

        public void SetBaud(int baud)
        {
            USBserialPort.BaudRate = baud;
        }
    }
}
