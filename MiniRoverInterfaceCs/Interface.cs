﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace MiniRoverInterfaceCs
{
    public partial class Interface : Form
    {
        public string ProgramVersion = @"0.0.1.3";
        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            this.Text = @"MiniRover Interface Version " + ProgramVersion;
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
            if ((TxtSendPort.Text != TxtRecievePort.Text) && TxtSendPort.Text != @"" && TxtRecievePort.Text != @"")
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
            if (TxtSendPort.Text != @"" && TxtRecievePort.Text != @"")
            {
                BtnDisconnect.Enabled = true;
                BtnEdit.Enabled = false;

                SerialPort1.PortName = TxtSendPort.Text;
                SerialPort2.PortName = TxtRecievePort.Text;

                SerialPort1.Open();
                SerialPort2.Open();


                BtnConnect.Enabled = false;
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen || SerialPort2.IsOpen)
            {
                SerialPort1.Close();
                SerialPort2.Close();
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

        bool WheelSpeedSliderSync = false;
        private void BtnSyncWheelSpeed_Click(object sender, EventArgs e)
        {
            Wheel0Label.Text = Wheel1Label.Text = Wheel2Label.Text = Wheel3Label.Text = @"0";
            if (WheelSpeedSliderSync == true)   BtnSyncWheelSpeed.Text = @"Sync Wheel Speed";
            else                                BtnSyncWheelSpeed.Text = @"Unsync Wheel Speed";

            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 0;
            WheelSpeedSliderSync = !WheelSpeedSliderSync;
        }

        private void BtnResetWheelSpeed_Click(object sender, EventArgs e)
        {
            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 0;
            Wheel0Label.Text = Wheel1Label.Text = Wheel2Label.Text = Wheel3Label.Text = @"0";
        }

        private void Wheel0SpeedSlider_Scroll(object sender, EventArgs e)
        {
            Wheel0Label.Text = Wheel0SpeedSlider.Value.ToString();
            if (WheelSpeedSliderSync == true)
            {
                Wheel3SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel0SpeedSlider.Value;
                Wheel3Label.Text = Wheel1Label.Text = Wheel2Label.Text = Wheel0Label.Text;
            }
        }

        private void Wheel1SpeedSlider_Scroll(object sender, EventArgs e)
        {
            Wheel1Label.Text = Wheel1SpeedSlider.Value.ToString();
            if (WheelSpeedSliderSync == true)
            {
                Wheel0SpeedSlider.Value = Wheel3SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel1SpeedSlider.Value;
                Wheel0Label.Text = Wheel3Label.Text = Wheel2Label.Text = Wheel1Label.Text;
            }
        }

        private void Wheel2SpeedSlider_Scroll(object sender, EventArgs e)
        {
            Wheel2Label.Text = Wheel2SpeedSlider.Value.ToString();
            if (WheelSpeedSliderSync == true)
            {
                Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel3SpeedSlider.Value = Wheel2SpeedSlider.Value;
                Wheel0Label.Text = Wheel1Label.Text = Wheel3Label.Text = Wheel2Label.Text;
            }
        }

        private void Wheel3SpeedSlider_Scroll(object sender, EventArgs e)
        {
            Wheel3Label.Text = Wheel3SpeedSlider.Value.ToString();
            if (WheelSpeedSliderSync == true)
            {
                Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value;
                Wheel0Label.Text = Wheel1Label.Text = Wheel2Label.Text = Wheel3Label.Text;
            }
        }
    }
}
