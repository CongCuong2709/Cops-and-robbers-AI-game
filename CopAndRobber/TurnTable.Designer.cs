namespace CopAndRobber
{
	partial class TurnTable
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelTurnList = new Guna.UI2.WinForms.Guna2Panel();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(25, 195);
			this.panel1.TabIndex = 0;
			// 
			// panelTurnList
			// 
			this.panelTurnList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTurnList.Location = new System.Drawing.Point(25, 0);
			this.panelTurnList.Name = "panelTurnList";
			this.panelTurnList.Size = new System.Drawing.Size(410, 195);
			this.panelTurnList.TabIndex = 1;
			// 
			// TurnTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.panelTurnList);
			this.Controls.Add(this.panel1);
			this.Name = "TurnTable";
			this.Size = new System.Drawing.Size(435, 195);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2Panel panelTurnList;
	}
}
