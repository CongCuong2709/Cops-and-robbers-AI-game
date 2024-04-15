namespace CopAndRobber
{
	partial class WelcomeScreen
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
            this.buttonSetting = new Guna.UI2.WinForms.Guna2GradientButton();
            this.buttonExit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.buttonPlay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // buttonSetting
            // 
            this.buttonSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSetting.BorderRadius = 15;
            this.buttonSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSetting.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSetting.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.ForeColor = System.Drawing.Color.White;
            this.buttonSetting.Location = new System.Drawing.Point(171, 302);
            this.buttonSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(195, 80);
            this.buttonSetting.TabIndex = 5;
            this.buttonSetting.Text = "Setting";
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.BorderRadius = 15;
            this.buttonExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonExit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonExit.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(171, 483);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(195, 80);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = " Exit";
            this.buttonExit.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlay.BorderRadius = 15;
            this.buttonPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPlay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPlay.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.White;
            this.buttonPlay.Location = new System.Drawing.Point(171, 131);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(195, 80);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CopAndRobber.Properties.Resources.minimalism_tom_and_jerry_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WelcomeScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GradientButton buttonSetting;
		private Guna.UI2.WinForms.Guna2GradientButton buttonExit;
		private Guna.UI2.WinForms.Guna2GradientButton buttonPlay;
	}
}