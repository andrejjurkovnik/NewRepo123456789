using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Timers;

namespace Projectnc1
{
    class USB_MCP2200 : SerialPort
    {
        SerialPort USBport;
        System.Timers.Timer USBtimeoutTimer;
        public double MCP2200_timeout
        {
            get
            {
                return MCP2200_timeout;
            }
            set
            {
                USBtimeoutTimer.Interval = value;
            }
        }
        string[] portNames;
        private bool check;
        private string checkData;
        private string receivedData;

        public delegate void completeHandler(bool complete);
        public event completeHandler completeEvent;

        public USB_MCP2200(int baud = 9600)
        {
            USBport = new SerialPort();
            USBport.BaudRate = baud;
            portNames = SerialPort.GetPortNames();
            USBport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            USBtimeoutTimer = new System.Timers.Timer();
            MCP2200_timeout = 500;
            USBtimeoutTimer.Elapsed += new ElapsedEventHandler(USBtimeout);
        }

        private void USBtimeout(object sender, ElapsedEventArgs e)
        {
            SendDataAndCheck(checkData);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            receivedData += USBport.ReadExisting();
            if(check)
            {
                USBtimeoutTimer.Stop();//is that needed?
                USBtimeoutTimer.Start();//is that needed?
                if (receivedData == checkData)
                {
                    sentAndChecked = true;
                    USBtimeoutTimer.Stop();
                }
            }
        }

        private bool sentchecked;
        public bool sentAndChecked
        {
            get
            {
                return sentAndChecked;
            }
            set
            {
                sentchecked = value;
                if(sentchecked)
                {
                    completeEvent(sentchecked);
                }
            }
        }

        public void ConnectUSB(int baudRate, string COMport)
        {

            USBport.BaudRate = baudRate;                 //set up Baud rate
            USBport.PortName = COMport;                  //Set up port
            try
            {
                USBport.Open();
            }
            catch
            {
                MessageBox.Show("Connection failed. Try again!");
            }
        }

        public void SendData(string data)
        {
            check = false;
            receivedData = "";
            USBport.Write(data);
        }

        public void SendDataAndCheck(string data)
        {
            check = true;
            receivedData = "";
            sentAndChecked = false;
            checkData = data;
            USBtimeoutTimer.Start();
            USBport.Write(data);
        }

    }
}
