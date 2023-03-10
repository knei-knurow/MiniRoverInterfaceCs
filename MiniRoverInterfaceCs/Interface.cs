using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace MiniRoverInterfaceCs
{
    public partial class Interface : Form
    {
        public string ProgramVersion = @"0.1.1.0";
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
            Text = @"MiniRover Interface Version " + ProgramVersion;
            BtnEdit.Enabled = true;
            BtnConnect.Enabled = true;
            BtnSave.Enabled = false;
            BtnDisconnect.Enabled = false;
            TxtSendPort.Enabled = false;
            TxtRecievePort.Enabled = false;
        }

        #region Connection
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
        #endregion

        #region Wheel Controls
        #region Wheel Speed
        bool WheelSpeedSliderSync = false;
        bool WheelAngleSliderSync = false;
        private void BtnSyncWheelSpeed_Click(object sender, EventArgs e)
        {
            Wheel0SpeedLabel.Text = Wheel1SpeedLabel.Text = Wheel2SpeedLabel.Text = Wheel3SpeedLabel.Text = @"0";
            if (WheelSpeedSliderSync == true) BtnSyncWheelSpeed.Text = @"Sync Wheel Speed";
            else BtnSyncWheelSpeed.Text = @"Unsync Wheel Speed";

            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 0;
            WheelSpeedSliderSync = !WheelSpeedSliderSync;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnResetWheelSpeed_Click(object sender, EventArgs e)
        {
            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 0;
            Wheel0SpeedLabel.Text = Wheel1SpeedLabel.Text = Wheel2SpeedLabel.Text = Wheel3SpeedLabel.Text = @"0";
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void Wheel0SpeedSlider_Scroll(object sender, EventArgs e)
        {
            Wheel0SpeedLabel.Text = Wheel0SpeedSlider.Value.ToString();
            if (WheelSpeedSliderSync == true)
            {
                Wheel3SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel0SpeedSlider.Value;
                Wheel3SpeedLabel.Text = Wheel1SpeedLabel.Text = Wheel2SpeedLabel.Text = Wheel0SpeedLabel.Text;
            }
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void Wheel1SpeedSlider_Scroll(object sender, EventArgs e)
        {
            Wheel1SpeedLabel.Text = Wheel1SpeedSlider.Value.ToString();
            if (WheelSpeedSliderSync == true)
            {
                Wheel0SpeedSlider.Value = Wheel3SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel1SpeedSlider.Value;
                Wheel0SpeedLabel.Text = Wheel3SpeedLabel.Text = Wheel2SpeedLabel.Text = Wheel1SpeedLabel.Text;
            }
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void Wheel2SpeedSlider_Scroll(object sender, EventArgs e)
        {
            Wheel2SpeedLabel.Text = Wheel2SpeedSlider.Value.ToString();
            if (WheelSpeedSliderSync == true)
            {
                Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel3SpeedSlider.Value = Wheel2SpeedSlider.Value;
                Wheel0SpeedLabel.Text = Wheel1SpeedLabel.Text = Wheel3SpeedLabel.Text = Wheel2SpeedLabel.Text;
            }
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void Wheel3SpeedSlider_Scroll(object sender, EventArgs e)
        {
            if (WheelSpeedSliderSync == true)
            {
                Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value;
                Wheel0SpeedLabel.Text = Wheel1SpeedLabel.Text = Wheel2SpeedLabel.Text = Wheel3SpeedLabel.Text;
            }
            SerialPortSend.Write(SerialSend(), 0, 21);
        }
        #endregion

        #region Wheel Angle
        private void BtnSyncWheelAngle_Click(object sender, EventArgs e)
        {
            Wheel0AngleLabel.Text = Wheel1AngleLabel.Text = Wheel2AngleLabel.Text = Wheel3AngleLabel.Text = @"0";
            if (WheelAngleSliderSync == true) BtnSyncWheelAngle.Text = @"Sync Wheel Angle";
            else BtnSyncWheelAngle.Text = @"Unsync Wheel Angle";

            Wheel0AngleSlider.Value = Wheel1AngleSlider.Value = Wheel2AngleSlider.Value = Wheel3AngleSlider.Value = 0;
            WheelAngleSliderSync = !WheelAngleSliderSync;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnResetWheelAngle_Click(object sender, EventArgs e)
        {
            Wheel0AngleSlider.Value = Wheel1AngleSlider.Value = Wheel2AngleSlider.Value = Wheel3AngleSlider.Value = 0;
            Wheel0AngleLabel.Text = Wheel1AngleLabel.Text = Wheel2AngleLabel.Text = Wheel3AngleLabel.Text = @"0";
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void Wheel0AngleSlider_Scroll(object sender, EventArgs e)
        {
            Wheel0AngleLabel.Text = Wheel0AngleSlider.Value.ToString();
            if (WheelAngleSliderSync == true)
            {
                Wheel3AngleSlider.Value = Wheel1AngleSlider.Value = Wheel2AngleSlider.Value = Wheel0AngleSlider.Value;
                Wheel3AngleLabel.Text = Wheel1AngleLabel.Text = Wheel2AngleLabel.Text = Wheel0AngleLabel.Text;
            }
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void Wheel1AngleSlider_Scroll(object sender, EventArgs e)
        {
            Wheel1AngleLabel.Text = Wheel1AngleSlider.Value.ToString();
            if (WheelAngleSliderSync == true)
            {
                Wheel0AngleSlider.Value = Wheel3AngleSlider.Value = Wheel2AngleSlider.Value = Wheel1AngleSlider.Value;
                Wheel0AngleLabel.Text = Wheel3AngleLabel.Text = Wheel2AngleLabel.Text = Wheel1AngleLabel.Text;
            }
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void Wheel2AngleSlider_Scroll(object sender, EventArgs e)
        {
            Wheel2AngleLabel.Text = Wheel2AngleSlider.Value.ToString();
            if (WheelAngleSliderSync == true)
            {
                Wheel0AngleSlider.Value = Wheel1AngleSlider.Value = Wheel3AngleSlider.Value = Wheel2AngleSlider.Value;
                Wheel0AngleLabel.Text = Wheel1AngleLabel.Text = Wheel3AngleLabel.Text = Wheel2AngleLabel.Text;
            }
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void Wheel3AngleSlider_Scroll(object sender, EventArgs e)
        {
            Wheel3AngleLabel.Text = Wheel3AngleSlider.Value.ToString();
            if (WheelAngleSliderSync == true)
            {
                Wheel0AngleSlider.Value = Wheel1AngleSlider.Value = Wheel2AngleSlider.Value = Wheel3AngleSlider.Value;
                Wheel0AngleLabel.Text = Wheel1AngleLabel.Text = Wheel2AngleLabel.Text = Wheel3AngleLabel.Text;
            }
            SerialPortSend.Write(SerialSend(), 0, 21);
        }
        #endregion
        #endregion

        #region Arm Controls
        public byte[] ArmRun = new byte[5];
        #region Arm 0 Controls
        private void BtnArm0Left_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[0] = 1;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm0Left_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[0] = 0;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm0Right_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[0] = 2;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm0Right_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[0] = 0;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }
        #endregion

        #region Arm 1 Controls
        private void BtnArm1Left_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[1] = 1;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm1Left_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[1] = 0;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm1Right_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[1] = 2;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm1Right_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[1] = 0;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }
        #endregion

        #region Arm 2 Controls
        private void BtnArm2Left_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[2] = 1;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm2Left_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[2] = 0;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm2Right_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[2] = 2;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm2Right_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[2] = 0;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }
        #endregion

        #region Arm 3 Controls
        private void BtnArm3Left_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[3] = 1;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm3Left_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[3] = 0;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm3Right_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[3] = 2;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm3Right_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[3] = 0;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }
        #endregion

        #region Arm 4 Controls
        private void BtnArm4Left_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[4] = 1;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm4Left_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[4] = 0;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm4Right_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[4] = 2;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }

        private void BtnArm4Right_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[4] = 0;
            SerialPortSend.Write(SerialSend(), 0, 21);
        }
        #endregion
        #endregion
    }
}
