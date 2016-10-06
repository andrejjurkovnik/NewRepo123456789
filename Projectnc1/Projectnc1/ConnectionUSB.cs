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
        /// <summary>
        /// Global objects/variables
        /// </summary>
        static SerialPort USBserialPort;
        public string[] portNames;


        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="baudRate"></param>
        public ConnectionUSB(int baudRate = 9600)
        {
            //Set up Serial port properties
            USBserialPort = new SerialPort();                       //Create Serial port object      
            USBserialPort.BaudRate = baudRate;
            portNames = SerialPort.GetPortNames();                  //Gets all the available COM-ports 
            

        }

         public bool ConnectUSB(int baudRate, string COMport)
        {

            USBserialPort.BaudRate = baudRate;                 //set up Baud rate
            USBserialPort.PortName = COMport;                  //Set up port

            // Check if connection was successful          
            if (USBserialPort.IsOpen)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        static public void SendAxisData(char axisNum, UInt16 acceleration, UInt16 deceleration, UInt16 speed, Int32 steps)
        {
            byte[] temp;
            temp = new byte[2];
            USBserialPort.Write(temp,0,2);
            USBserialPort.Write("a");
            temp[0] = (byte)(acceleration);
            USBserialPort.Write(Convert.ToString(temp));
            temp[1] = (byte)(acceleration >> 8);
            USBserialPort.Write(Convert.ToString(temp));
        }
    }
}
