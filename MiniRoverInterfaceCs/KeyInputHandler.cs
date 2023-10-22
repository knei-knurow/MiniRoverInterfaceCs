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
            SerialSend();
        }

        private void Interface_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            switch ((char)e.KeyData) 
            {
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
            }
            e.Handled = true;
        }
    }
}
