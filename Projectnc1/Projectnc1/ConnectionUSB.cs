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
        //delte this comment
        /// <summary>
        /// Global objects/variables
        /// </summary>
        public SerialPort USBserialPort;
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
            try
            {
                USBserialPort.Open();
            }
            catch
            { }

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

        public void SendAxisData(char axisNum, UInt16 acceleration, UInt16 deceleration, UInt16 speed, Int32 steps)
        {
            //Send Axis Number
            byte[] toSend;
            toSend = new byte[2];

            USBserialPort.Write(Convert.ToString(axisNum));

            //Send a - for acceleration
            USBserialPort.Write("a");

            //Send acceleration value
            toSend = BitConverter.GetBytes(acceleration);
            USBserialPort.Write(toSend, 0, 2);

            //Send d - for deceleration
            USBserialPort.Write("d");

            //Send deceleration value
            toSend = BitConverter.GetBytes(deceleration);
            USBserialPort.Write(toSend, 0, 2);

            //Send f - for speed
            USBserialPort.Write("f");

            //Send speed value
            toSend = BitConverter.GetBytes(speed);
            USBserialPort.Write(toSend, 0, 2);

            //Send s - for steeps
            USBserialPort.Write("s");

            //Send deceleration value
            USBserialPort.Write(Convert.ToString(steps));
            USBserialPort.Write("e");

            USBserialPort.Write("c");

            //USBserialPort.Close();
        }

        public void SendMoveCommand()
        {
            USBserialPort.Write("m");
        }


    }
}
