using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;

namespace RacingMotors
{
    public class Motorhound
    {
        public int StartLine;
        public Random Pick_Motor_Randon;
        public int Motor_Track;

       

        public void Track_Point()
        {
        StartLine = 0;
        }

        public bool Motor_Race_Run()
        {
        int Motor_Fow = Pick_Motor_Randon.Next(1, 4);
        Point initial = Motor_Track_Picture.Location;
        initial.X += Motor_Fow;
        Motor_Track_Picture.Location = initial;
        if (initial.X >= Motor_Track)
        return true;
        else
        return false;
        }
        public int Location = 0;
        public PictureBox Motor_Track_Picture = null;
    }
}