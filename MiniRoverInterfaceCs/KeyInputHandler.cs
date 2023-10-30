using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniRoverInterfaceCs
{
    public partial class Interface
    {
        private void Interface_KeyUp(object sender, KeyEventArgs e)
        {
            Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 0;
            Wheel0AngleSlider.Value = Wheel1AngleSlider.Value = Wheel2AngleSlider.Value = Wheel3AngleSlider.Value = 0;
            ArmRun[0] ^= ArmRun[0];
            ArmRun[1] ^= ArmRun[1];
            SerialSend();
        }

        private void Interface_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            switch ((char)e.KeyData) 
            {
                #region WheelKeys
                case 'W':
                    Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 255;
                    SerialSend();
                    break;
                case 'A':
                    Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = 255;
                    Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 170;
                    Wheel0AngleSlider.Value = -10;
                    Wheel1AngleSlider.Value = 10;
                    Wheel2AngleSlider.Value = -15;
                    Wheel3AngleSlider.Value = 15;
                    SerialSend();
                    break;
                case 'D':
                    Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = 170;
                    Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 255;
                    Wheel0AngleSlider.Value = 15;
                    Wheel1AngleSlider.Value = -15;
                    Wheel2AngleSlider.Value = 10;
                    Wheel3AngleSlider.Value = -10;
                    SerialSend();
                    break;
                case 'S':
                    Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = -255;
                    SerialSend();
                    break;
                case 'Q':
                    Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = -255;
                    Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = 255;
                    Wheel0AngleSlider.Value = Wheel3AngleSlider.Value = -45;
                    Wheel1AngleSlider.Value = Wheel2AngleSlider.Value = 45;
                    SerialSend();
                    break;
                case 'E':
                    Wheel0SpeedSlider.Value = Wheel1SpeedSlider.Value = 255;
                    Wheel2SpeedSlider.Value = Wheel3SpeedSlider.Value = -255;
                    Wheel0AngleSlider.Value = Wheel3AngleSlider.Value = -45;
                    Wheel1AngleSlider.Value = Wheel2AngleSlider.Value = 45;
                    SerialSend();
                    break;
                #endregion

                #region ArmKeys
                case '1':
                    ArmRun[0] |= 0b00000001;
                    SerialSend();
                    break;
                case '2':
                    ArmRun[0] |= 0b00000010;
                    SerialSend();
                    break;
                case '3':
                    ArmRun[0] |= 0b00000100;
                    SerialSend();
                    break;
                case '4':
                    ArmRun[0] |= 0b00001000;
                    SerialSend();
                    break;
                case '5':
                    ArmRun[0] |= 0b00010000;
                    SerialSend();
                    break;
                case '6':
                    ArmRun[0] |= 0b00100000;
                    SerialSend();
                    break;
                case '7':
                    ArmRun[0] |= 0b01000000;
                    SerialSend();
                    break;
                case '8':
                    ArmRun[0] |= 0b10000000;
                    SerialSend();
                    break;
                case '9':
                    ArmRun[1] |= 0b00000001;
                    SerialSend();
                    break;
                case '0':
                    ArmRun[1] |= 0b00000010;
                    SerialSend();
                    break;
                    #endregion
            }
            e.Handled = true;
        }
    }
}
