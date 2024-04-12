using System;
using System.Windows.Forms;

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
            this.SettingButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PauseButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SoundButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelLogMove = new CopAndRobber.LogMove();
            this.panelTurnTable = new CopAndRobber.TurnTable();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.buttonBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelGameScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGameScreen
            // 
            this.panelGameScreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelGameScreen.Controls.Add(this.SettingButton);
            this.panelGameScreen.Controls.Add(this.PauseButton);
            this.panelGameScreen.Controls.Add(this.SoundButton);
            this.panelGameScreen.Controls.Add(this.panelLogMove);
            this.panelGameScreen.Controls.Add(this.panelTurnTable);
            this.panelGameScreen.Controls.Add(this.textBoxConsole);
            this.panelGameScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGameScreen.Location = new System.Drawing.Point(0, 0);
            this.panelGameScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGameScreen.Name = "panelGameScreen";
            this.panelGameScreen.Size = new System.Drawing.Size(1422, 720);
            this.panelGameScreen.TabIndex = 1;
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
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
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
            // panelLogMove
            // 
            this.panelLogMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogMove.BackColor = System.Drawing.Color.MistyRose;
            this.panelLogMove.Location = new System.Drawing.Point(1093, 550);
            this.panelLogMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogMove.Name = "panelLogMove";
            this.panelLogMove.Size = new System.Drawing.Size(329, 170);
            this.panelLogMove.TabIndex = 8;
            // 
            // panelTurnTable
            // 
            this.panelTurnTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTurnTable.BackColor = System.Drawing.SystemColors.Info;
            this.panelTurnTable.Location = new System.Drawing.Point(0, 564);
            this.panelTurnTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTurnTable.Name = "panelTurnTable";
            this.panelTurnTable.Size = new System.Drawing.Size(387, 156);
            this.panelTurnTable.TabIndex = 7;
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
            this.ResumeLayout(false);

		}

       

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelGameScreen;
		private System.Windows.Forms.TextBox textBoxConsole;
        private Guna.UI2.WinForms.Guna2ImageButton PauseButton;
        private Guna.UI2.WinForms.Guna2ImageButton SoundButton;
        private Guna.UI2.WinForms.Guna2ImageButton SettingButton;
        private Guna.UI2.WinForms.Guna2ImageButton buttonBack;
		private LogMove panelLogMove;
        private TurnTable panelTurnTable;
    }
}