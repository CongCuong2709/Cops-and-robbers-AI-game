namespace CopAndRobber
{
	partial class GameScreen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panelGameScreen = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.buttonBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SettingButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PauseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SoundButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logMove1 = new CopAndRobber.LogMove();
            this.turnTable1 = new CopAndRobber.TurnTable();
            this.panelGameScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGameScreen
            // 
            this.panelGameScreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelGameScreen.Controls.Add(this.SettingButton);
            this.panelGameScreen.Controls.Add(this.PauseButton);
            this.panelGameScreen.Controls.Add(this.SoundButton);
            this.panelGameScreen.Controls.Add(this.logMove1);
            this.panelGameScreen.Controls.Add(this.turnTable1);
            this.panelGameScreen.Controls.Add(this.pictureBox4);
            this.panelGameScreen.Controls.Add(this.pictureBox3);
            this.panelGameScreen.Controls.Add(this.pictureBox2);
            this.panelGameScreen.Controls.Add(this.pictureBox1);
            this.panelGameScreen.Controls.Add(this.textBoxConsole);
            this.panelGameScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGameScreen.Location = new System.Drawing.Point(0, 0);
            this.panelGameScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGameScreen.Name = "panelGameScreen";
            this.panelGameScreen.Size = new System.Drawing.Size(1422, 720);
            this.panelGameScreen.TabIndex = 1;
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(381, 550);
            this.textBoxConsole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.Size = new System.Drawing.Size(706, 170);
            this.textBoxConsole.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.Image = global::CopAndRobber.Properties.Resources.buttonback;
            this.buttonBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonBack.ImageRotate = 0F;
            this.buttonBack.Location = new System.Drawing.Point(1194, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonBack.Size = new System.Drawing.Size(64, 54);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SettingButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.SettingButton.Image = global::CopAndRobber.Properties.Resources.settingbutton;
            this.SettingButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.SettingButton.ImageRotate = 0F;
            this.SettingButton.Location = new System.Drawing.Point(1114, 12);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SettingButton.Size = new System.Drawing.Size(64, 54);
            this.SettingButton.TabIndex = 11;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.PauseButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.PauseButton.Image = global::CopAndRobber.Properties.Resources.pausebutton;
            this.PauseButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.PauseButton.ImageRotate = 0F;
            this.PauseButton.Location = new System.Drawing.Point(1044, 12);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.PauseButton.Size = new System.Drawing.Size(64, 54);
            this.PauseButton.TabIndex = 10;
            // 
            // SoundButton
            // 
            this.SoundButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SoundButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.SoundButton.Image = global::CopAndRobber.Properties.Resources.soundbutton;
            this.SoundButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.SoundButton.ImageRotate = 0F;
            this.SoundButton.Location = new System.Drawing.Point(974, 12);
            this.SoundButton.Name = "SoundButton";
            this.SoundButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SoundButton.Size = new System.Drawing.Size(64, 54);
            this.SoundButton.TabIndex = 9;
            this.SoundButton.Click += new System.EventHandler(this.SoundButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(901, 274);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(93, 80);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(782, 274);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 80);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(672, 274);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 80);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(540, 274);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // logMove1
            // 
            this.logMove1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logMove1.BackColor = System.Drawing.Color.MistyRose;
            this.logMove1.Location = new System.Drawing.Point(1093, 550);
            this.logMove1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logMove1.Name = "logMove1";
            this.logMove1.Size = new System.Drawing.Size(329, 170);
            this.logMove1.TabIndex = 8;
            // 
            // turnTable1
            // 
            this.turnTable1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.turnTable1.BackColor = System.Drawing.SystemColors.Info;
            this.turnTable1.Location = new System.Drawing.Point(0, 564);
            this.turnTable1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.turnTable1.Name = "turnTable1";
            this.turnTable1.Size = new System.Drawing.Size(387, 156);
            this.turnTable1.TabIndex = 7;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panelGameScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.panelGameScreen.ResumeLayout(false);
            this.panelGameScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Panel panelGameScreen;
		private System.Windows.Forms.TextBox textBoxConsole;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private TurnTable turnTable1;
		private LogMove logMove1;
        private Guna.UI2.WinForms.Guna2ImageButton PauseButton;
        private Guna.UI2.WinForms.Guna2ImageButton SoundButton;
        private Guna.UI2.WinForms.Guna2ImageButton SettingButton;
        private Guna.UI2.WinForms.Guna2ImageButton buttonBack;
    }
}