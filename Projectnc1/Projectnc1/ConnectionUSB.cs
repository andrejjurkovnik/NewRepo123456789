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
using System.Timers;

namespace Projectnc1
{
    class ConnectionUSB
    {
        public SerialPort USBserialPort;
        public string[] portNames;
        System.Timers.Timer USBtimer;

        public bool sendAndCheck = true;                            //not needed at the moment

        public string sendBuffer;
        public string dataDisplay;
        private string receivedData;
        public bool readyForMoveCmd = false;

        public struct send
        {
            public int sendBufferIndex;                             //Index of transmit buffer
            public int sendBufferLength;                            //Length of current outgoing transmision
            public string[] check;                                  //String to compare with incoming data
            public int[] numberCheckBytes;                          //Number of bytes to be checked
            public int numberOfAllTransmisions;                     //Number of all transmisons to be made
            public int numberOfTransmisions;                        //Number of transmisions already complete
        }

        public send sendData;

        public ConnectionUSB(int baudRate = 9600)
        {
            USBtimer = new System.Timers.Timer();                   //Timer for USB error check
            USBtimer.Elapsed += new ElapsedEventHandler(USBTimeout);
            USBtimer.Interval = 100;                                //Timer interval set to 100ms
            //Set up Serial port properties
            USBserialPort = new SerialPort();                       //Create Serial port object      
            USBserialPort.BaudRate = baudRate;
            portNames = SerialPort.GetPortNames();                  //Gets all the available COM-ports 
            USBserialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            sendData.numberOfAllTransmisions = 4;
            sendData.numberCheckBytes = new int[5];
            sendData.check = new string[4];
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            receivedData = receivedData + USBserialPort.ReadExisting();

            USBtimer.Stop();
            USBtimer.Start();

            if (receivedData.Length == sendData.numberCheckBytes[sendData.numberOfTransmisions])
            {
                if (receivedData == sendData.check[sendData.numberOfTransmisions])
                {
                    USBtimer.Stop();
                    dataDisplay = receivedData;
                    receivedData = "";
                    sendData.numberOfTransmisions++;

                    if(sendData.numberOfTransmisions < sendData.numberOfAllTransmisions)
                    {
                        sendData.sendBufferIndex += sendData.numberCheckBytes[sendData.numberOfTransmisions - 1] + 2;
                        sendData.sendBufferLength = sendData.numberCheckBytes[sendData.numberOfTransmisions] + 2;
                        StartTransmit(sendData.sendBufferIndex, sendData.sendBufferLength);
                    }
                    else if(sendData.numberOfTransmisions == sendData.numberOfAllTransmisions)
                    {
                        USBserialPort.Write("c");
                        sendData.numberOfTransmisions = 0;
                        readyForMoveCmd = true;
                        USBtimer.Stop();
                    }
                }

                //else if (receivedData != sendData.check[sendData.numberOfTransmisions])//is that needed, timer is more secure option
                //{
                //    receivedData = "";
                //    StartTransmit(sendData.sendBufferIndex, sendData.sendBufferLength);
                //}
            }
        }

        public delegate void bool_handler(bool value);

        public event bool_handler ReadyToMoveEvent;

        private bool readyMove = false;

        public bool readyToMove
        {
            get
            {
                return readyMove;
            }
            set
            {
                readyMove = value;
                ReadyToMoveEvent(readyMove);
            }
        }

        private void USBTimeout(object sender, ElapsedEventArgs e)
        {
            USBtimer.Stop();
            //MessageBox.Show("fail timer");
            receivedData = "";
            StartTransmit(sendData.sendBufferIndex, sendData.sendBufferLength);
        }

        public void SendSelectSlave(char axisNum)
        {
            USBserialPort.Write(axisNum.ToString());
        }

        public void SendProfileData(char profilePart, UInt16 profileData)
        {
            //Send a - for acceleration
            //Send d - for deceleration
            //Send f - for speed
            sendBuffer += Convert.ToString(profilePart) + Convert.ToString(profileData) + "e";
        }

        public void SendStepData(Int32 steps)
        {
            sendBuffer += "s" + Convert.ToString(steps) + "e";                  //Send 's' for steeps + send steps value + 'e' confirm steps value
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
            sendBuffer = "";
            sendData.numberOfTransmisions = 0;
            readyForMoveCmd = false;

            SendSelectSlave(axisNum);

            SendProfileData('a', acceleration);

            SendProfileData('d', deceleration);

            SendProfileData('f', speed);

            SendStepData(steps);

            sendData.numberCheckBytes[0] = acceleration.ToString().Length;
            sendData.numberCheckBytes[1] = deceleration.ToString().Length;
            sendData.numberCheckBytes[2] = speed.ToString().Length;
            sendData.numberCheckBytes[3] = steps.ToString().Length;
            sendData.numberCheckBytes[4] = 1;

            sendData.check[0] = acceleration.ToString();
            sendData.check[1] = deceleration.ToString();
            sendData.check[2] = speed.ToString();
            sendData.check[3] = steps.ToString();

            sendData.sendBufferIndex = 0;
            sendData.sendBufferLength = sendData.numberCheckBytes[0] + 2;

            USBtimer.Interval = 400;

            StartTransmit(sendData.sendBufferIndex,sendData.sendBufferLength);
        }

        private void StartTransmit(int startIndex, int length)
        {
            USBserialPort.Write(sendBuffer.Substring(startIndex, length));
            USBtimer.Start();
        }

        public void SendMoveCommand()
        {
            readyToMove = false;
            USBtimer.Interval = 300;
            //checkData = "r";
            USBserialPort.Write("m");
            //USBtimer.Start();
        }
    }
}
