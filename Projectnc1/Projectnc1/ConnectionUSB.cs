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
            string[] portNames;
            portNames = SerialPort.GetPortNames();
            foreach(string portName in portNames)
            {
                try
                {
                    USBserialPort.PortName = portName;
                    USBserialPort.Open();
                    USBserialPort.Write("h");//write h as hello, MCU must response, otherwise it continues to search for right port
                    if (USBserialPort.ReadLine() == "Machine connected")
                    {
                        break;
                    }
                }
                catch
                { }
            }
            if (USBserialPort.IsOpen) MessageBox.Show("CNC machine connected to port " + USBserialPort.PortName);
            else MessageBox.Show("No machine found");
        }

        static public void SetBaud(int baud)
        {
            USBserialPort.BaudRate = baud;
        }

        static public void SendAxisData(char axisNum, UInt16 acceleration, UInt16 deceleration, UInt16 speed, Int32 steps)
        {
            char temp;
            USBserialPort.Write(Convert.ToString(axisNum));
            USBserialPort.Write("a");
            temp = Convert.ToChar(acceleration);
            USBserialPort.Write(Convert.ToString(temp));
            temp = Convert.ToChar(acceleration >> 8);
            USBserialPort.Write(Convert.ToString(temp));
        }
    }
}
