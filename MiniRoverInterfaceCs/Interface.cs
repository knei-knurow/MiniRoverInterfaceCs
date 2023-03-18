using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace MiniRoverInterfaceCs
{
    public partial class Interface : Form
    {
        public string RecieveString;
        public string SendString;
        public Thread RecieveThread;
        public Thread SendThread;
        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            Text = @"MiniRover Interface";
            BtnEdit.Enabled = true;
            BtnConnect.Enabled = true;
            BtnSave.Enabled = false;
            BtnDisconnect.Enabled = false;
            TxtSendPort.Enabled = false;
            TxtRecievePort.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            BtnConnect.Enabled = false;
            BtnSave.Enabled = true;
            TxtSendPort.Enabled = true;
            TxtRecievePort.Enabled = true;

            BtnEdit.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if ((TxtSendPort.Text != TxtRecievePort.Text) && TxtSendPort.Text != @"" /*&& TxtRecievePort.Text != @""*/)
            {
                BtnEdit.Enabled = true;
                BtnConnect.Enabled = true;
                TxtSendPort.Enabled = false;
                TxtRecievePort.Enabled = false;

                BtnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show(@"Select different and not empty Send and Recieve Ports.");
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (/*TxtRecievePort.Text != @"" && */TxtSendPort.Text != @"")
            {
                BtnDisconnect.Enabled = true;
                BtnEdit.Enabled = false;

                //SerialPortRecieve.PortName = TxtRecievePort.Text;
                SerialPortSend.PortName = TxtSendPort.Text;

                //SerialPortRecieve.Open();
                SerialPortSend.Open();
                /*try
                {
                    RecieveThread = new Thread(SerialPortRecieveRead);
                    RecieveThread.Start();
                }
                catch (Exception ConnectionException)
                {
                    MessageBox.Show(@"You done did f*cked up boi: " + ConnectionException.Message);
                }*/

                BtnConnect.Enabled = false;
            }
        }

        /*private void SerialPortRecieveRead()
        {
            while (SerialPortRecieve.IsOpen)
            {
                if (SerialPortRecieve.BytesToRead > 0)
                {
                    RecieveString = SerialPortRecieve.ReadExisting();
                }
                Thread.Sleep(500);
            }
        }*/

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            if (/*SerialPortRecieve.IsOpen || */SerialPortSend.IsOpen)
            {
                //SerialPortRecieve.Close();
                SerialPortSend.Close();
                BtnConnect.Enabled = true;
                BtnEdit.Enabled = true;

                BtnDisconnect.Enabled = false;
            }
        }

        private void TxtSendPort_DropDown(object sender, EventArgs e)
        {
            TxtSendPort.Items.Clear();
            string[] COMPorts = SerialPort.GetPortNames();
            foreach (string comport in COMPorts)
            {
                TxtSendPort.Items.Add(comport);
            }
        }

        private void TxtRecievePort_DropDown(object sender, EventArgs e)
        {
            TxtRecievePort.Items.Clear();
            string[] COMPorts = SerialPort.GetPortNames();
            foreach (string comport in COMPorts)
            {
                TxtRecievePort.Items.Add(comport);
            }
        }
    }
}
