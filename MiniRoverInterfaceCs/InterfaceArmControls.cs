using System;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace MiniRoverInterfaceCs
{
    public partial class Interface
    {
        public byte[] ArmRun = new byte[2];
        #region Arm 0 Controls
        private void BtnArm0Left_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[0] |= 0b00000001;
            SerialSend();
        }

        private void BtnArm0Left_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[0] &= 0b11111110;
            SerialSend();
        }

        private void BtnArm0Right_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[0] |= 0b00000010;
            SerialSend();
        }

        private void BtnArm0Right_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[0] &= 0b11111101;
            SerialSend();
        }
        #endregion

        #region Arm 1 Controls
        private void BtnArm1Left_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[0] |= 0b00000100;
            SerialSend();
        }

        private void BtnArm1Left_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[0] &= 0b11111011;
            SerialSend();
        }

        private void BtnArm1Right_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[0] |= 0b00001000;
            SerialSend();
        }

        private void BtnArm1Right_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[0] &= 0b11110111;
            SerialSend();
        }
        #endregion

        #region Arm 2 Controls
        private void BtnArm2Left_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[0] |= 0b00010000;
            SerialSend();
        }

        private void BtnArm2Left_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[0] &= 0b11101111;
            SerialSend();
        }

        private void BtnArm2Right_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[0] |= 0b00100000;
            SerialSend();
        }

        private void BtnArm2Right_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[0] &= 0b11011111;
            SerialSend();
        }
        #endregion

        #region Arm 3 Controls
        private void BtnArm3Left_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[0] |= 0b01000000;
            SerialSend();
        }

        private void BtnArm3Left_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[0] &= 0b10111111;
            SerialSend();
        }

        private void BtnArm3Right_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[0] |= 0b10000000;
            SerialSend();
        }

        private void BtnArm3Right_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[0] &= 0b01111111;
            SerialSend();
        }
        #endregion

        #region Arm 4 Controls
        private void BtnArm4Left_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[1] |= 0b00000001;
            SerialSend();
        }

        private void BtnArm4Left_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[1] &= 0b11111110;
            SerialSend();
        }

        private void BtnArm4Right_MouseDown(object sender, MouseEventArgs e)
        {
            ArmRun[1] |= 0b00000010;
            SerialSend();
        }

        private void BtnArm4Right_MouseUp(object sender, MouseEventArgs e)
        {
            ArmRun[1] &= 0b11111101;
            SerialSend();
        }
        #endregion
    }
}