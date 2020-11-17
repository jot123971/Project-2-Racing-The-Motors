using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RacingMotors
{
    public class BetMotor
    {
        public int Value; 
        public int Motor; 
        public MotorRidder BetBikes; 
        public string Describe()
        {
                if (Value > 0)
                return BetBikes.Name + " Bet Motor " + Value + " bucks Of Motor No." + Motor;
                else
                return BetBikes.Name + " BetMotor Not Choosen";
        }
        public int Payments(int WinnerBike)
        {
                if (WinnerBike == Motor)
                   {
                int Payments = Value * 2;
                return Payments;
                   }
                else
                {
                int Payments = 0;
                return Payments;
                }
        }
    }
}