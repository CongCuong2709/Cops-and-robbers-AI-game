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
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBoxConsole = new System.Windows.Forms.TextBox();
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
			this.panelGameScreen.Controls.Add(this.logMove1);
			this.panelGameScreen.Controls.Add(this.turnTable1);
			this.panelGameScreen.Controls.Add(this.pictureBox4);
			this.panelGameScreen.Controls.Add(this.pictureBox3);
			this.panelGameScreen.Controls.Add(this.pictureBox2);
			this.panelGameScreen.Controls.Add(this.pictureBox1);
			this.panelGameScreen.Controls.Add(this.textBoxConsole);
			this.panelGameScreen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelGameScreen.Location = new System.Drawing.Point(0, 0);
			this.panelGameScreen.Name = "panelGameScreen";
			this.panelGameScreen.Size = new System.Drawing.Size(1600, 900);
			this.panelGameScreen.TabIndex = 1;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(1014, 342);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(105, 100);
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(880, 342);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(105, 100);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(756, 342);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(105, 100);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(620, 342);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(105, 100);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// textBoxConsole
			// 
			this.textBoxConsole.Location = new System.Drawing.Point(80, 494);
			this.textBoxConsole.Name = "textBoxConsole";
			this.textBoxConsole.Size = new System.Drawing.Size(621, 26);
			this.textBoxConsole.TabIndex = 0;
			// 
			// logMove1
			// 
			this.logMove1.BackColor = System.Drawing.Color.MistyRose;
			this.logMove1.Location = new System.Drawing.Point(1230, 688);
			this.logMove1.Name = "logMove1";
			this.logMove1.Size = new System.Drawing.Size(370, 212);
			this.logMove1.TabIndex = 8;
			// 
			// turnTable1
			// 
			this.turnTable1.BackColor = System.Drawing.SystemColors.Info;
			this.turnTable1.Location = new System.Drawing.Point(0, 705);
			this.turnTable1.Name = "turnTable1";
			this.turnTable1.Size = new System.Drawing.Size(435, 195);
			this.turnTable1.TabIndex = 7;
			// 
			// GameScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1600, 900);
			this.Controls.Add(this.panelGameScreen);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
	}
}