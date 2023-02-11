﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Drawing.Text;

namespace MiniRoverInterfaceCs
{
    public partial class Interface
    {
        public string SerialSend()
        {
            byte[] SendBytes = new byte[21];
            SendBytes[0] = 65;                                          //AT+
            SendBytes[1] = 84;
            SendBytes[2] = 43;
            SendBytes[3] = (byte)Math.Abs(Wheel0SpeedSlider.Value);     //Wheel Speed
            SendBytes[4] = (byte)Math.Abs(Wheel1SpeedSlider.Value);
            SendBytes[5] = (byte)Math.Abs(Wheel2SpeedSlider.Value);
            SendBytes[6] = (byte)Math.Abs(Wheel3SpeedSlider.Value);
            if (Wheel0SpeedSlider.Value < 0) SendBytes[7] = 0;          //Wheel Speed Orientation
            else SendBytes[7] = 1;
            if (Wheel1SpeedSlider.Value < 0) SendBytes[8] = 0;
            else SendBytes[8] = 1;
            if (Wheel2SpeedSlider.Value < 0) SendBytes[9] = 0;
            else SendBytes[9] = 1;
            if (Wheel3SpeedSlider.Value < 0) SendBytes[10] = 0;
            else SendBytes[10] = 1;
            SendBytes[11] = 0;                                          //Wheel Angle
            SendBytes[12] = 0;                                          //Need to figure them out
            SendBytes[13] = 0;
            SendBytes[14] = 0;
            SendBytes[15] = ArmRun[0];                                  //Arm Directions
            SendBytes[16] = ArmRun[1];
            SendBytes[17] = ArmRun[2];
            SendBytes[18] = ArmRun[3];
            SendBytes[19] = ArmRun[4];
            return Encoding.ASCII.GetString(SendBytes);
        }
    }
}
