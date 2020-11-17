using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RacingMotors
{
    public class MotorRidder
    {
        public RadioButton RadioMotorButton;
        public Label Motor_Label;
        public string Name; 
        public BetMotor Create_Bet = null;
        public int Bugs;
       
        public void CleanToResetBet(bool FinishMotorRace)
        {
        if (FinishMotorRace)
        {
        Create_Bet = null;
        }
        else
        {
        if (this.Create_Bet != null)
        {
        Bugs += this.Create_Bet.Value;
        this.Create_Bet = null;
        }
        else
        {
        this.Create_Bet = null;
        }
        }
        UpdateTheBetLabels();
        }

        public void UpdateTheBetLabels()
        {
        if (Create_Bet == null)
        Motor_Label.Text = Name + " Have Nothing Bet for Motors";
        else
        Motor_Label.Text = Create_Bet.Describe();
        RadioMotorButton.Text = Name + " Having " + Bugs + " Bugs";
        }

        public bool BetSetters(int Value, int Motor)
        {
        if (Value > Bugs)
        {
        MessageBox.Show("I Have no Bugs Left now for BetMotor", Name + " saying");
        return false;
        }
        else
        {
        if (this.Create_Bet == null)
        {
        this.Create_Bet = new BetMotor() { Value = Value, BetBikes = this, Motor = Motor };
        this.Bugs -= Value;
        this.UpdateTheBetLabels();
        return true;
        }
        else
        {
        this.Bugs += this.Create_Bet.Value;
        this.Create_Bet = null;
        this.Create_Bet = new BetMotor() { Value = Value, BetBikes = this, Motor = Motor };
        this.Bugs -= Value;
        this.UpdateTheBetLabels();
        return true;
        }
        }
        }

        static void Main()
        {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
        }

        internal void Collect(int WinnerBike)
        {

        //throw new NotImplementedException();
        }

        internal void CleanToResetBet()
        {
       // throw new NotImplementedException();
        }
    }
}
