namespace CopAndRobber
{
	partial class MainScreen
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
			this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.panelMainScreen = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2CustomGradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2CustomGradientPanel1
			// 
			this.guna2CustomGradientPanel1.Controls.Add(this.panelMainScreen);
			this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
			this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1600, 900);
			this.guna2CustomGradientPanel1.TabIndex = 0;
			// 
			// panelMainScreen
			// 
			this.panelMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMainScreen.Location = new System.Drawing.Point(0, 0);
			this.panelMainScreen.Name = "panelMainScreen";
			this.panelMainScreen.Size = new System.Drawing.Size(1600, 900);
			this.panelMainScreen.TabIndex = 1;
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1600, 900);
			this.Controls.Add(this.guna2CustomGradientPanel1);
			this.Name = "MainScreen";
			this.Text = "Tom & Jerry chase";
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.guna2CustomGradientPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
		private Guna.UI2.WinForms.Guna2Panel panelMainScreen;
	}
}

