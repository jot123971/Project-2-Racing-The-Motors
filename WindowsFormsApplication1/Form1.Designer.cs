namespace RacingMotors
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Motor1 = new System.Windows.Forms.PictureBox();
            this.Motor2 = new System.Windows.Forms.PictureBox();
            this.Motor3 = new System.Windows.Forms.PictureBox();
            this.Motor4 = new System.Windows.Forms.PictureBox();
            this.GoRace = new System.Windows.Forms.Button();
            this.MinBLabel = new System.Windows.Forms.Label();
            this.JamesButton = new System.Windows.Forms.RadioButton();
            this.BondsRadioButton = new System.Windows.Forms.RadioButton();
            this.AmarsRadioButton = new System.Windows.Forms.RadioButton();
            this.BetsLabel = new System.Windows.Forms.Label();
            this.JamesBLabel = new System.Windows.Forms.Label();
            this.BondsBLabel = new System.Windows.Forms.Label();
            this.AmarsBLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BetsButton = new System.Windows.Forms.Button();
            this.numericadjust = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPet = new System.Windows.Forms.NumericUpDown();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Motor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Motor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Motor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Motor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericadjust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPet)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Location = new System.Drawing.Point(18, 13);
            this.Picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(1244, 309);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            this.Picture.Click += new System.EventHandler(this.Picture_Click);
            // 
            // Motor1
            // 
            this.Motor1.Image = ((System.Drawing.Image)(resources.GetObject("Motor1.Image")));
            this.Motor1.Location = new System.Drawing.Point(33, 37);
            this.Motor1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Motor1.Name = "Motor1";
            this.Motor1.Size = new System.Drawing.Size(112, 32);
            this.Motor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Motor1.TabIndex = 1;
            this.Motor1.TabStop = false;
            this.Motor1.Click += new System.EventHandler(this.Motor1_Click);
            // 
            // Motor2
            // 
            this.Motor2.Image = ((System.Drawing.Image)(resources.GetObject("Motor2.Image")));
            this.Motor2.Location = new System.Drawing.Point(33, 105);
            this.Motor2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Motor2.Name = "Motor2";
            this.Motor2.Size = new System.Drawing.Size(112, 34);
            this.Motor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Motor2.TabIndex = 2;
            this.Motor2.TabStop = false;
            this.Motor2.Click += new System.EventHandler(this.Motor2_Click);
            // 
            // Motor3
            // 
            this.Motor3.Image = ((System.Drawing.Image)(resources.GetObject("Motor3.Image")));
            this.Motor3.Location = new System.Drawing.Point(33, 168);
            this.Motor3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Motor3.Name = "Motor3";
            this.Motor3.Size = new System.Drawing.Size(112, 37);
            this.Motor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Motor3.TabIndex = 3;
            this.Motor3.TabStop = false;
            // 
            // Motor4
            // 
            this.Motor4.Image = ((System.Drawing.Image)(resources.GetObject("Motor4.Image")));
            this.Motor4.Location = new System.Drawing.Point(33, 242);
            this.Motor4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Motor4.Name = "Motor4";
            this.Motor4.Size = new System.Drawing.Size(112, 37);
            this.Motor4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Motor4.TabIndex = 4;
            this.Motor4.TabStop = false;
            // 
            // GoRace
            // 
            this.GoRace.Location = new System.Drawing.Point(1019, 332);
            this.GoRace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GoRace.Name = "GoRace";
            this.GoRace.Size = new System.Drawing.Size(219, 64);
            this.GoRace.TabIndex = 5;
            this.GoRace.Text = "RacingMotors!";
            this.GoRace.UseVisualStyleBackColor = true;
            this.GoRace.Click += new System.EventHandler(this.Get_Set_Race);
            // 
            // MinBLabel
            // 
            this.MinBLabel.AutoSize = true;
            this.MinBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBLabel.Location = new System.Drawing.Point(14, 371);
            this.MinBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinBLabel.Name = "MinBLabel";
            this.MinBLabel.Size = new System.Drawing.Size(0, 20);
            this.MinBLabel.TabIndex = 6;
            // 
            // JamesButton
            // 
            this.JamesButton.AutoSize = true;
            this.JamesButton.Location = new System.Drawing.Point(299, 372);
            this.JamesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JamesButton.Name = "JamesButton";
            this.JamesButton.Size = new System.Drawing.Size(126, 24);
            this.JamesButton.TabIndex = 7;
            this.JamesButton.TabStop = true;
            this.JamesButton.Text = "radioButton1";
            this.JamesButton.UseVisualStyleBackColor = true;
            this.JamesButton.CheckedChanged += new System.EventHandler(this.JamesButton_CheckedChanged);
            // 
            // BondsRadioButton
            // 
            this.BondsRadioButton.AutoSize = true;
            this.BondsRadioButton.Location = new System.Drawing.Point(299, 430);
            this.BondsRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BondsRadioButton.Name = "BondsRadioButton";
            this.BondsRadioButton.Size = new System.Drawing.Size(126, 24);
            this.BondsRadioButton.TabIndex = 8;
            this.BondsRadioButton.TabStop = true;
            this.BondsRadioButton.Text = "radioButton1";
            this.BondsRadioButton.UseVisualStyleBackColor = true;
            this.BondsRadioButton.CheckedChanged += new System.EventHandler(this.BondsRadioButton_CheckedChanged_1);
            // 
            // AmarsRadioButton
            // 
            this.AmarsRadioButton.AutoSize = true;
            this.AmarsRadioButton.Location = new System.Drawing.Point(299, 497);
            this.AmarsRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AmarsRadioButton.Name = "AmarsRadioButton";
            this.AmarsRadioButton.Size = new System.Drawing.Size(126, 24);
            this.AmarsRadioButton.TabIndex = 9;
            this.AmarsRadioButton.TabStop = true;
            this.AmarsRadioButton.Text = "radioButton2";
            this.AmarsRadioButton.UseVisualStyleBackColor = true;
            this.AmarsRadioButton.CheckedChanged += new System.EventHandler(this.AmarsRadioButton_CheckedChanged_1);
            // 
            // BetsLabel
            // 
            this.BetsLabel.AutoSize = true;
            this.BetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetsLabel.Location = new System.Drawing.Point(295, 332);
            this.BetsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BetsLabel.Name = "BetsLabel";
            this.BetsLabel.Size = new System.Drawing.Size(48, 20);
            this.BetsLabel.TabIndex = 10;
            this.BetsLabel.Text = "Bets";
            // 
            // JamesBLabel
            // 
            this.JamesBLabel.AutoSize = true;
            this.JamesBLabel.Location = new System.Drawing.Point(592, 369);
            this.JamesBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JamesBLabel.Name = "JamesBLabel";
            this.JamesBLabel.Size = new System.Drawing.Size(51, 20);
            this.JamesBLabel.TabIndex = 11;
            this.JamesBLabel.Text = "label1";
            // 
            // BondsBLabel
            // 
            this.BondsBLabel.AutoSize = true;
            this.BondsBLabel.Location = new System.Drawing.Point(592, 430);
            this.BondsBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BondsBLabel.Name = "BondsBLabel";
            this.BondsBLabel.Size = new System.Drawing.Size(51, 20);
            this.BondsBLabel.TabIndex = 12;
            this.BondsBLabel.Text = "label1";
            // 
            // AmarsBLabel
            // 
            this.AmarsBLabel.AutoSize = true;
            this.AmarsBLabel.Location = new System.Drawing.Point(592, 501);
            this.AmarsBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmarsBLabel.Name = "AmarsBLabel";
            this.AmarsBLabel.Size = new System.Drawing.Size(51, 20);
            this.AmarsBLabel.TabIndex = 13;
            this.AmarsBLabel.Text = "label1";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(14, 552);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 20);
            this.NameLabel.TabIndex = 14;
            // 
            // BetsButton
            // 
            this.BetsButton.Location = new System.Drawing.Point(503, 545);
            this.BetsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BetsButton.Name = "BetsButton";
            this.BetsButton.Size = new System.Drawing.Size(176, 35);
            this.BetsButton.TabIndex = 15;
            this.BetsButton.Text = "Bets";
            this.BetsButton.UseVisualStyleBackColor = true;
            this.BetsButton.Click += new System.EventHandler(this.BetsButton_Click);
            // 
            // numericadjust
            // 
            this.numericadjust.Location = new System.Drawing.Point(773, 546);
            this.numericadjust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericadjust.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericadjust.Name = "numericadjust";
            this.numericadjust.Size = new System.Drawing.Size(118, 26);
            this.numericadjust.TabIndex = 16;
            this.numericadjust.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 597);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "bucks on Motor number ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDownPet
            // 
            this.numericUpDownPet.Location = new System.Drawing.Point(773, 591);
            this.numericUpDownPet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownPet.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownPet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPet.Name = "numericUpDownPet";
            this.numericUpDownPet.Size = new System.Drawing.Size(118, 26);
            this.numericUpDownPet.TabIndex = 18;
            this.numericUpDownPet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(1019, 541);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(219, 76);
            this.ResetButton.TabIndex = 19;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1251, 631);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.numericUpDownPet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericadjust);
            this.Controls.Add(this.BetsButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AmarsBLabel);
            this.Controls.Add(this.BondsBLabel);
            this.Controls.Add(this.JamesBLabel);
            this.Controls.Add(this.BetsLabel);
            this.Controls.Add(this.AmarsRadioButton);
            this.Controls.Add(this.BondsRadioButton);
            this.Controls.Add(this.JamesButton);
            this.Controls.Add(this.MinBLabel);
            this.Controls.Add(this.GoRace);
            this.Controls.Add(this.Motor4);
            this.Controls.Add(this.Motor3);
            this.Controls.Add(this.Motor2);
            this.Controls.Add(this.Motor1);
            this.Controls.Add(this.Picture);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Motor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Motor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Motor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Motor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericadjust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.PictureBox Motor1;
        private System.Windows.Forms.PictureBox Motor2;
        private System.Windows.Forms.PictureBox Motor3;
        private System.Windows.Forms.PictureBox Motor4;
        private System.Windows.Forms.Button GoRace;
        private System.Windows.Forms.Label MinBLabel;
        private System.Windows.Forms.RadioButton JamesButton;
        private System.Windows.Forms.RadioButton BondsRadioButton;
        private System.Windows.Forms.RadioButton AmarsRadioButton;
        private System.Windows.Forms.Label BetsLabel;
        private System.Windows.Forms.Label JamesBLabel;
        private System.Windows.Forms.Label BondsBLabel;
        private System.Windows.Forms.Label AmarsBLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button BetsButton;
        private System.Windows.Forms.NumericUpDown numericadjust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPet;
        private System.Windows.Forms.Button ResetButton;
    }
}