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

        public string sendBuffer;
        public string dataDisplay;
        public string receivedData;
        public string checkData;
        public char currentProfilePart;

        public delegate void bool_handler(bool value);

        public bool GcodeExecuting = false;
        public int executingLine = 0;

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

        public bool sendWithCheckComplete;
        private bool sendSteps = false;
        private bool sendCheckReady = false;
        private bool sendProfile = false;

        System.Timers.Timer USBtimer;

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
        }

        private void USBTimeout(object sender, ElapsedEventArgs e)
        {
            USBtimer.Stop();
            //MessageBox.Show("fail timer");
            receivedData = "";
            if (sendSteps)
            {
                SendStepData(Convert.ToInt32(checkData));
            }
            else if (sendCheckReady)
            {
                USBserialPort.Write("R");
            }
            else if(sendProfile)
            {
                SendProfileData(currentProfilePart, Convert.ToUInt16(checkData));
            }
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
                dataDisplay = receivedData;
                receivedData = "";
                sendWithCheckComplete = true;
                if(sendCheckReady)
                {
                    sendCheckReady = false;
                    readyToMove = true;
                }
            }

            if (receivedData != checkData && receivedData.Length == checkData.Length)
            {
                USBtimer.Stop();
                receivedData = "";
                if(sendSteps)
                {
                    SendStepData(Convert.ToInt32(checkData));
                }
                else if(sendCheckReady)
                {
                    USBserialPort.Write("R");
                }
                else if(sendProfile)
                {
                    SendProfileData(currentProfilePart, Convert.ToUInt16(checkData));
                }
            }
        }

        private void SendSelectSlave(char axisNum)
        {
            USBserialPort.Write(axisNum.ToString());
        }

        private void SendProfileData(char profilePart, UInt16 profileData)
        {
            sendSteps = false;
            sendCheckReady = false;
            sendProfile = true;
            USBtimer.Interval = 1000;
            sendWithCheckComplete = false;
            byte[] toSend;
            toSend = new byte[2];

            checkData = profileData.ToString();
            currentProfilePart = profilePart;

            //Send a - for acceleration
            //Send d - for deceleration
            //Send f - for speed
            USBserialPort.Write(profilePart.ToString());
            //send data
            toSend = BitConverter.GetBytes(profileData);
            USBserialPort.Write(toSend, 0, 2);
            startTimer();
        }

        private void SendStepData(Int32 steps)
        {
            sendProfile = false;
            sendCheckReady = false;
            sendSteps = true;
            USBtimer.Interval = 700;
            sendWithCheckComplete = false;
            checkData = steps.ToString();
            //Send s - for steeps
            USBserialPort.Write("s");
            //send steps value
            USBserialPort.Write(Convert.ToString(steps));
            //confirm steps value
            USBserialPort.Write("e");
            startTimer();
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
            SendSelectSlave(axisNum);

            SendProfileData('a', acceleration);
            while (!sendWithCheckComplete) ;
            SendProfileData('d', deceleration);
            while (!sendWithCheckComplete) ;
            SendProfileData('f', speed);
            while (!sendWithCheckComplete) ;
            SendStepData(steps);
            while (!sendWithCheckComplete) ;

            USBserialPort.Write("c");                   //Complete slave data
        }

        public void SendMoveCommand()
        {
            readyToMove = false;
            sendProfile = false;
            sendSteps = false;
            sendCheckReady = true;
            USBtimer.Interval = 300;
            sendWithCheckComplete = false;
            checkData = "r";
            USBserialPort.Write("m");
            startTimer();
        }
    }
}
