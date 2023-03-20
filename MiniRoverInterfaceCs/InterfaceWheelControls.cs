using System;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace MiniRoverInterfaceCs
{
    public partial class Interface
    {
        private void WheelFloor(object sender, MouseEventArgs e)
        {
            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 0;
            Wheel0AngleSlider.Value = Wheel1AngleSlider.Value = Wheel2AngleSlider.Value = Wheel3AngleSlider.Value = 0;
            SerialSend();
        }

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
            SerialSend();
        }

        private void BtnResetWheelSpeed_Click(object sender, EventArgs e)
        {
            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 0;
            Wheel0SpeedLabel.Text = Wheel1SpeedLabel.Text = Wheel2SpeedLabel.Text = Wheel3SpeedLabel.Text = @"0";
            SerialSend();
        }

        private void Wheel0SpeedSlider_Scroll(object sender, EventArgs e)
        {
            Wheel0SpeedLabel.Text = Wheel0SpeedSlider.Value.ToString();
            if (WheelSpeedSliderSync == true)
            {
                Wheel3SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel0SpeedSlider.Value;
                Wheel3SpeedLabel.Text = Wheel1SpeedLabel.Text = Wheel2SpeedLabel.Text = Wheel0SpeedLabel.Text;
            }
            SerialSend();
        }

        private void Wheel1SpeedSlider_Scroll(object sender, EventArgs e)
        {
            Wheel1SpeedLabel.Text = Wheel1SpeedSlider.Value.ToString();
            if (WheelSpeedSliderSync == true)
            {
                Wheel0SpeedSlider.Value = Wheel3SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel1SpeedSlider.Value;
                Wheel0SpeedLabel.Text = Wheel3SpeedLabel.Text = Wheel2SpeedLabel.Text = Wheel1SpeedLabel.Text;
            }
            SerialSend();
        }

        private void Wheel2SpeedSlider_Scroll(object sender, EventArgs e)
        {
            Wheel2SpeedLabel.Text = Wheel2SpeedSlider.Value.ToString();
            if (WheelSpeedSliderSync == true)
            {
                Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel3SpeedSlider.Value = Wheel2SpeedSlider.Value;
                Wheel0SpeedLabel.Text = Wheel1SpeedLabel.Text = Wheel3SpeedLabel.Text = Wheel2SpeedLabel.Text;
            }
            SerialSend();
        }

        private void Wheel3SpeedSlider_Scroll(object sender, EventArgs e)
        {
            Wheel3SpeedLabel.Text = Wheel3SpeedSlider.Value.ToString();
            if (WheelSpeedSliderSync == true)
            {
                Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value;
                Wheel0SpeedLabel.Text = Wheel1SpeedLabel.Text = Wheel2SpeedLabel.Text = Wheel3SpeedLabel.Text;
            }
            SerialSend();
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
            SerialSend();
        }

        private void BtnResetWheelAngle_Click(object sender, EventArgs e)
        {
            Wheel0AngleSlider.Value = Wheel1AngleSlider.Value = Wheel2AngleSlider.Value = Wheel3AngleSlider.Value = 0;
            Wheel0AngleLabel.Text = Wheel1AngleLabel.Text = Wheel2AngleLabel.Text = Wheel3AngleLabel.Text = @"0";
            SerialSend();
        }

        private void Wheel0AngleSlider_Scroll(object sender, EventArgs e)
        {
            Wheel0AngleLabel.Text = Wheel0AngleSlider.Value.ToString();
            if (WheelAngleSliderSync == true)
            {
                Wheel3AngleSlider.Value = Wheel1AngleSlider.Value = Wheel2AngleSlider.Value = Wheel0AngleSlider.Value;
                Wheel3AngleLabel.Text = Wheel1AngleLabel.Text = Wheel2AngleLabel.Text = Wheel0AngleLabel.Text;
            }
            SerialSend();
        }

        private void Wheel1AngleSlider_Scroll(object sender, EventArgs e)
        {
            Wheel1AngleLabel.Text = Wheel1AngleSlider.Value.ToString();
            if (WheelAngleSliderSync == true)
            {
                Wheel0AngleSlider.Value = Wheel3AngleSlider.Value = Wheel2AngleSlider.Value = Wheel1AngleSlider.Value;
                Wheel0AngleLabel.Text = Wheel3AngleLabel.Text = Wheel2AngleLabel.Text = Wheel1AngleLabel.Text;
            }
            SerialSend();
        }

        private void Wheel2AngleSlider_Scroll(object sender, EventArgs e)
        {
            Wheel2AngleLabel.Text = Wheel2AngleSlider.Value.ToString();
            if (WheelAngleSliderSync == true)
            {
                Wheel0AngleSlider.Value = Wheel1AngleSlider.Value = Wheel3AngleSlider.Value = Wheel2AngleSlider.Value;
                Wheel0AngleLabel.Text = Wheel1AngleLabel.Text = Wheel3AngleLabel.Text = Wheel2AngleLabel.Text;
            }
            SerialSend();
        }

        private void Wheel3AngleSlider_Scroll(object sender, EventArgs e)
        {
            Wheel3AngleLabel.Text = Wheel3AngleSlider.Value.ToString();
            if (WheelAngleSliderSync == true)
            {
                Wheel0AngleSlider.Value = Wheel1AngleSlider.Value = Wheel2AngleSlider.Value = Wheel3AngleSlider.Value;
                Wheel0AngleLabel.Text = Wheel1AngleLabel.Text = Wheel2AngleLabel.Text = Wheel3AngleLabel.Text;
            }
            SerialSend();
        }
        #endregion

        #region Wheel Quick Actions
        private void BtnForward_MouseDown(object sender, MouseEventArgs e)
        {
            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 255;
            SerialSend();
        }

        private void BtnForwardLeft_MouseDown(object sender, MouseEventArgs e)
        {
            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = 255;
            Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 170;
            Wheel0AngleSlider.Value = -10;
            Wheel1AngleSlider.Value = 10;
            Wheel2AngleSlider.Value = -15;
            Wheel3AngleSlider.Value = 15;
            SerialSend();
        }

        private void BtnForwardRight_MouseDown(object sender, MouseEventArgs e)
        {
            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = 170;
            Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 255;
            Wheel0AngleSlider.Value = 15;
            Wheel1AngleSlider.Value = -15;
            Wheel2AngleSlider.Value = 10;
            Wheel3AngleSlider.Value = -10;
            SerialSend();
        }

        private void BtnBackwardLeft_MouseDown(object sender, MouseEventArgs e)
        {
            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = -255;
            Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = -170;
            Wheel0AngleSlider.Value = -10;
            Wheel1AngleSlider.Value = 10;
            Wheel2AngleSlider.Value = -15;
            Wheel3AngleSlider.Value = 15;
            SerialSend();
        }

        private void BtnBackwardRight_MouseDown(object sender, MouseEventArgs e)
        {
            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = -170;
            Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = -255;
            Wheel0AngleSlider.Value = 15;
            Wheel1AngleSlider.Value = -15;
            Wheel2AngleSlider.Value = 10;
            Wheel3AngleSlider.Value = -10;
            SerialSend();
        }

        private void BtnBackward_MouseDown(object sender, MouseEventArgs e)
        {
            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = -255;
            SerialSend();
        }

        private void BtnPivotLeft_MouseDown(object sender, MouseEventArgs e)
        {
            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = 255;
            Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = -255;
            Wheel0AngleSlider.Value = Wheel3AngleSlider.Value = -45;
            Wheel1AngleSlider.Value = Wheel2AngleSlider.Value = 45;
        }

        private void BtnPivotRight_MouseDown(object sender, MouseEventArgs e)
        {
            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = -255;
            Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 255;
            Wheel0AngleSlider.Value = Wheel3AngleSlider.Value = -45;
            Wheel1AngleSlider.Value = Wheel2AngleSlider.Value = 45;
        }
        #endregion
    }
}