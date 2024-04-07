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
			this.buttonHelp = new Guna.UI2.WinForms.Guna2GradientButton();
			this.buttonPlay = new Guna.UI2.WinForms.Guna2GradientButton();
			this.SuspendLayout();
			// 
			// buttonSetting
			// 
			this.buttonSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.buttonSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.buttonSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.buttonSetting.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.buttonSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.buttonSetting.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.buttonSetting.ForeColor = System.Drawing.Color.White;
			this.buttonSetting.Location = new System.Drawing.Point(420, 729);
			this.buttonSetting.Name = "buttonSetting";
			this.buttonSetting.Size = new System.Drawing.Size(180, 45);
			this.buttonSetting.TabIndex = 5;
			this.buttonSetting.Text = " ";
			// 
			// buttonHelp
			// 
			this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonHelp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.buttonHelp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.buttonHelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.buttonHelp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.buttonHelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.buttonHelp.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.buttonHelp.ForeColor = System.Drawing.Color.White;
			this.buttonHelp.Location = new System.Drawing.Point(201, 729);
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.Size = new System.Drawing.Size(180, 45);
			this.buttonHelp.TabIndex = 4;
			this.buttonHelp.Text = " ";
			// 
			// buttonPlay
			// 
			this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.buttonPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.buttonPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.buttonPlay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.buttonPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.buttonPlay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPlay.ForeColor = System.Drawing.Color.White;
			this.buttonPlay.Location = new System.Drawing.Point(201, 577);
			this.buttonPlay.Name = "buttonPlay";
			this.buttonPlay.Size = new System.Drawing.Size(219, 100);
			this.buttonPlay.TabIndex = 3;
			this.buttonPlay.Text = "Play";
			// 
			// WelcomeScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1600, 900);
			this.Controls.Add(this.buttonSetting);
			this.Controls.Add(this.buttonHelp);
			this.Controls.Add(this.buttonPlay);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "WelcomeScreen";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GradientButton buttonSetting;
		private Guna.UI2.WinForms.Guna2GradientButton buttonHelp;
		private Guna.UI2.WinForms.Guna2GradientButton buttonPlay;
	}
}