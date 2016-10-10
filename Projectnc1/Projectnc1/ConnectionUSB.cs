﻿using System;
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
using System.Timers;

namespace Projectnc1
{
    class ConnectionUSB
    {
        public SerialPort USBserialPort;
        public string[] portNames;

        public string receivedData;

        public string checkData;
        public string wrongData;

        System.Timers.Timer USBtimer;

        public ConnectionUSB(int baudRate = 9600)
        {
            USBtimer = new System.Timers.Timer();
            USBtimer.Elapsed += new ElapsedEventHandler(USBTimeout);
            USBtimer.Interval = 100;
            //USBtimer.AutoReset = true;
            //Set up Serial port properties
            USBserialPort = new SerialPort();                       //Create Serial port object      
            USBserialPort.BaudRate = baudRate;
            portNames = SerialPort.GetPortNames();                  //Gets all the available COM-ports 

            USBserialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void USBTimeout(object sender, ElapsedEventArgs e)
        {
            USBtimer.Stop();
            MessageBox.Show("fail timer");
            wrongData = receivedData;
            receivedData = "";
            SendAccData(Convert.ToUInt16(checkData));

        }

        public void startTimer()
        {
            USBtimer.Start();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            receivedData = receivedData + USBserialPort.ReadExisting();

            USBtimer.Stop();
            USBtimer.Start();

            if (receivedData == checkData)
            {
                USBtimer.Stop();
                receivedData = "";
                MessageBox.Show("success");
            }

            if (receivedData != checkData && receivedData.Length == checkData.Length)
            {
                USBtimer.Stop();
                MessageBox.Show("fail");
                wrongData = receivedData;
                receivedData = "";
                SendAccData(Convert.ToUInt16(checkData));
            }
            //if (USBconnection.USBserialPort.ReadChar() == 'r')
            //{
            //    SendExecutingGCode();
            //}
        }

        public void SendAccData(UInt16 acceleration)
        {
            byte[] toSend;
            toSend = new byte[2];

            USBserialPort.Write("0");
            USBserialPort.Write("a");
            toSend = BitConverter.GetBytes(acceleration);
            USBserialPort.Write(toSend, 0, 2);
            checkData = acceleration.ToString();
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
