using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RacingMotors
{
    public partial class Form1 : Form
    {
        MotorRidder[] Motor_Betting;
        Motorhound[] Motor;
        MotorRidder Actual_Betting;

        public Form1()
        {
            InitializeComponent();
            Random Pick_Motor_Randon = new Random();

           
            Motor_Betting = new MotorRidder[3];
            Motor = new Motorhound[4];

            //Persons
            Motor_Betting[0] = new MotorRidder();
            Motor_Betting[0].Name = "James";
            Motor_Betting[0].RadioMotorButton = JamesButton;
            Motor_Betting[0].Motor_Label = JamesBLabel;
            Motor_Betting[0].Bugs = 50;
            Motor_Betting[0].UpdateTheBetLabels();

            Motor_Betting[1] = new MotorRidder();
            Motor_Betting[1].Name = "Bonds";
            Motor_Betting[1].RadioMotorButton = BondsRadioButton;
            Motor_Betting[1].Motor_Label = BondsBLabel;
            Motor_Betting[1].Bugs = 75;
            Motor_Betting[1].UpdateTheBetLabels();

            Motor_Betting[2] = new MotorRidder();
            Motor_Betting[2].Name = "Amars";
            Motor_Betting[2].RadioMotorButton = AmarsRadioButton;
            Motor_Betting[2].Motor_Label = AmarsBLabel;
            Motor_Betting[2].Bugs = 45;
            Motor_Betting[2].UpdateTheBetLabels();


            int StartPosition = Motor1.Location.X;
            int distance = Picture.Width;
            for (int i = 0; i < 4; i++)
            {
                Motor[i] = new Motorhound();
                Motor[i].Pick_Motor_Randon = Pick_Motor_Randon;
                Motor[i].Motor_Track = distance;
                Motor[i].Location = Motor[i].StartLine = StartPosition;
            }

            Motor[0].Motor_Track_Picture = Motor1;
            Motor[1].Motor_Track_Picture = Motor2;
            Motor[2].Motor_Track_Picture = Motor3;
            Motor[3].Motor_Track_Picture = Motor4;

            Actual_Betting = Motor_Betting[0];
        }


        private void JamesButton_CheckedChanged(object sender, EventArgs e)
        {
            FitBetting(0);
        }

        private void BondsRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            FitBetting(1);
        }

        private void AmarsRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            FitBetting(2);
        }




        private void FitBetting(int index)
        {
            Actual_Betting = Motor_Betting[index];
            NameLabel.Text = Actual_Betting.Name;
            if (Actual_Betting.Create_Bet != null)
            {
                numericadjust.Value = Actual_Betting.Create_Bet.Value;
                numericUpDownPet.Value = Actual_Betting.Create_Bet.Motor;
            }
            else
            {
                numericadjust.Value = numericadjust.Minimum;
                numericUpDownPet.Value = 1;
            }
        }
        private void Get_Set_Race(object sender, EventArgs e)
        {
            int WinnerBike = 0;
            int num_wins = 0;

            while (num_wins == 0)
            {
                for (int i = 0; i < Motor.Length; i++)
                {
                    if (Motor[i].Motor_Race_Run())
                    {
                        num_wins++;
                        WinnerBike = i + 1;
                    }
                }
                Application.DoEvents();
                System.Threading.Thread.Sleep(3);
            }



            for (int i = 0; i < Motor.Length; i++)
            {
                Motor[i].Track_Point();
            }
            string messageContent = "Congratulations \n";
            bool anyoneWins = false;
            for (int i = 0; i < Motor_Betting.Length; i++)
            {
                if (Motor_Betting[i].Create_Bet.Motor == WinnerBike)
                {
                    anyoneWins = true;
                    messageContent += Motor_Betting[i].Name + "\n";
                }
                Motor_Betting[i].Collect(WinnerBike);
                Motor_Betting[i].CleanToResetBet();
                Motor_Betting[i].UpdateTheBetLabels();
            }
            if (anyoneWins)
            {
               
                MessageBox.Show(" Motor Number" + WinnerBike + "wins!\n" + messageContent);
            }

            if (num_wins > 1)
                MessageBox.Show("We have " + num_wins + " wins");
            else if (!anyoneWins)
            {
                MessageBox.Show(" Motor Number" + WinnerBike + "wins!");
            }
            numericadjust.Value = numericadjust.Minimum;
            numericUpDownPet.Value = numericUpDownPet.Minimum;
            ResetGame();
        }

        private void ResetGame()
        {
            Motor1.Location = new Point(61, 32);
            Motor2.Location = new Point(61, 84);
            Motor3.Location = new Point(61, 131);
            Motor4.Location = new Point(61, 181);
        }

        

        private void BetsButton_Click(object sender, EventArgs e)
        {
            Actual_Betting.BetSetters((int)numericadjust.Value, (int)numericUpDownPet.Value);
            Actual_Betting.UpdateTheBetLabels();
        }
        

        


        private void frmbtnRacing_Click(object sender, EventArgs e)
        {
            int WinnerBike = 0;
            int winbike = 0;
            int count = 0;
            for (int i = 0; i < Motor_Betting.Length; i++)
            {
                if (Motor_Betting[1].Create_Bet != null)
                {
                    count++;
                }
            }

            if (count == Motor_Betting.Length)
            {
                while (WinnerBike == 0)
                {
                    for (int i = 0; i < Motor.Length; i++)
                    {
                        if (Motor[i].Motor_Race_Run())
                        {
                            WinnerBike++;
                            winbike = i + 1;
                            for (int i2 = 0; i2 < Motor_Betting.Length; i2++)
                            {
                                Motor_Betting[i2].Collect(i + 1);
                            }
                        }
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(3);
                    }
                }
                if (WinnerBike > 1)
                {
                    MessageBox.Show("Multiple wins!", "WOW");
                }
                else
                {
                    MessageBox.Show("The WinnerBike was Motor Po" + winbike);
                }
                for (int i = 0; i < Motor_Betting.Length; i++)
                {
                    Motor_Betting[i].CleanToResetBet(true);
                }
                for (int i = 0; i < Motor.Length; i++)
                {
                    Motor[i].Track_Point();
                }
            }
            else
            {
                MessageBox.Show("Not all players have placed their bets!", "Wait wait!");
            }
        }

        private void Picture_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Motor2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MinBLabel.Text = "Minimum BetMotor $5.00";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void Motor1_Click(object sender, EventArgs e)
        {

        }
    }
}
