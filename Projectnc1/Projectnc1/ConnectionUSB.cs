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
            USBserialPort.PortName = "COM4";
            USBserialPort.Open();
            //string[] portNames;
            //portNames = SerialPort.GetPortNames();
            //foreach(string portName in portNames)
            //{
            //    try
            //    {
            //        USBserialPort.PortName = portName;
            //        USBserialPort.Open();
            //        USBserialPort.Write("h");//write h as hello, MCU must response, otherwise it continues to search for right port
            //        if (USBserialPort.ReadLine() == "Machine connected")
            //        {
            //            break;
            //        }
            //    }
            //    catch
            //    { }
            //}
            //if (USBserialPort.IsOpen) MessageBox.Show("CNC machine connected to port " + USBserialPort.PortName);
            //else MessageBox.Show("No machine found");
        }

        static public void SetBaud(int baud)
        {
            USBserialPort.BaudRate = baud;
        }

        static public void SendAxisData(char axisNum, UInt16 acceleration, UInt16 deceleration, UInt16 speed, Int32 steps)
        {
            if (!USBserialPort.IsOpen) USBserialPort.Open();
            byte[] temp;
            temp = new byte[2];
            USBserialPort.Write(Convert.ToString(axisNum));

            USBserialPort.Write("a");
            temp[0] = Convert.ToByte(acceleration);
            temp[1] = Convert.ToByte(acceleration >> 8);
            USBserialPort.Write(temp,0,2);

            USBserialPort.Write("d");
            temp[0] = Convert.ToByte(deceleration);
            temp[1] = Convert.ToByte(deceleration >> 8);
            USBserialPort.Write(temp, 0, 2);

            USBserialPort.Write("f");
            temp[0] = Convert.ToByte(speed);
            temp[1] = Convert.ToByte(speed >> 8);
            USBserialPort.Write(temp, 0, 2);

            USBserialPort.Write("s");
            USBserialPort.Write(Convert.ToString(steps));
            USBserialPort.Write("e");

            USBserialPort.Write("c");
            USBserialPort.Write("m");

            USBserialPort.Close();
        }
    }
}
