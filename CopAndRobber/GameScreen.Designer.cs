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
			this.panelLogMove = new CopAndRobber.LogMove();
			this.panelTurnTable = new CopAndRobber.TurnTable();
			this.panelGameScreen.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelGameScreen
			// 
			this.panelGameScreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelGameScreen.Controls.Add(this.panelLogMove);
			this.panelGameScreen.Controls.Add(this.panelTurnTable);
			this.panelGameScreen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelGameScreen.Location = new System.Drawing.Point(0, 0);
			this.panelGameScreen.Name = "panelGameScreen";
			this.panelGameScreen.Size = new System.Drawing.Size(1600, 900);
			this.panelGameScreen.TabIndex = 1;
			// 
			// panelLogMove
			// 
			this.panelLogMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panelLogMove.BackColor = System.Drawing.Color.MistyRose;
			this.panelLogMove.Location = new System.Drawing.Point(1230, 688);
			this.panelLogMove.Name = "panelLogMove";
			this.panelLogMove.Size = new System.Drawing.Size(370, 212);
			this.panelLogMove.TabIndex = 8;
			// 
			// panelTurnTable
			// 
			this.panelTurnTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panelTurnTable.BackColor = System.Drawing.SystemColors.Info;
			this.panelTurnTable.Location = new System.Drawing.Point(0, 705);
			this.panelTurnTable.Name = "panelTurnTable";
			this.panelTurnTable.Size = new System.Drawing.Size(435, 195);
			this.panelTurnTable.TabIndex = 7;
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
			this.ResumeLayout(false);

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Panel panelGameScreen;
		private TurnTable panelTurnTable;
		private LogMove panelLogMove;
	}
}