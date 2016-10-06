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

        public void getPorts()
        {
            portNames = SerialPort.GetPortNames();                  //Gets all the available COM-ports 
        }








        static public void SendAxisData(char axisNum, UInt16 acceleration, UInt16 deceleration, UInt16 speed, Int32 steps)
        {
            //Send Axis Number
            byte[] toSend;
            toSend = new byte[2];
            toSend = BitConverter.GetBytes(axisNum); 
            USBserialPort.Write(toSend, 0, 2);

            //Send a - for acceleration
            toSend = new byte[2];
            toSend = BitConverter.GetBytes('a');
            USBserialPort.Write(toSend, 0, 2);

            //Send acceleration value
            toSend = new byte[2];
            toSend = BitConverter.GetBytes(acceleration);
            USBserialPort.Write(toSend, 0, 2);

            //Send d - for deceleration
            toSend = new byte[2];
            toSend = BitConverter.GetBytes('d');
            USBserialPort.Write(toSend, 0, 2);

            //Send deceleration value
            toSend = new byte[2];
            toSend = BitConverter.GetBytes(deceleration);
            USBserialPort.Write(toSend, 0, 2);

            //Send s - for speed
            toSend = new byte[2];
            toSend = BitConverter.GetBytes('s');
            USBserialPort.Write(toSend, 0, 2);

            //Send speed value
            toSend = new byte[2];
            toSend = BitConverter.GetBytes(speed);
            USBserialPort.Write(toSend, 0, 2);

            //Send m - for steeps
            toSend = new byte[2];
            toSend = BitConverter.GetBytes('m');
            USBserialPort.Write(toSend, 0, 2);

            //Send deceleration value
            toSend = new byte[4];
            toSend = BitConverter.GetBytes(steps);
            USBserialPort.Write(toSend, 0, 4);

        }


    }
}
