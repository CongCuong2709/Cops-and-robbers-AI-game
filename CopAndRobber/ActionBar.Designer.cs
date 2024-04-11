namespace CopAndRobber
{
	partial class ActionBar
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
			this.pictureBoxIcon = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
			this.progressBarCountDown = new Guna.UI2.WinForms.Guna2ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxIcon
			// 
			this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxIcon.ImageRotate = 0F;
			this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxIcon.Name = "pictureBoxIcon";
			this.pictureBoxIcon.Size = new System.Drawing.Size(47, 47);
			this.pictureBoxIcon.TabIndex = 0;
			this.pictureBoxIcon.TabStop = false;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Panel1.Location = new System.Drawing.Point(47, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(12, 47);
			this.guna2Panel1.TabIndex = 1;
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel2.Location = new System.Drawing.Point(59, 0);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(223, 10);
			this.guna2Panel2.TabIndex = 2;
			// 
			// guna2Panel3
			// 
			this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.guna2Panel3.Location = new System.Drawing.Point(59, 34);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.Size = new System.Drawing.Size(223, 13);
			this.guna2Panel3.TabIndex = 3;
			// 
			// progressBarCountDown
			// 
			this.progressBarCountDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressBarCountDown.Location = new System.Drawing.Point(59, 10);
			this.progressBarCountDown.Name = "progressBarCountDown";
			this.progressBarCountDown.Size = new System.Drawing.Size(223, 24);
			this.progressBarCountDown.TabIndex = 4;
			this.progressBarCountDown.Text = "guna2ProgressBar1";
			this.progressBarCountDown.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// ActionBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.progressBarCountDown);
			this.Controls.Add(this.guna2Panel3);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.pictureBoxIcon);
			this.Name = "ActionBar";
			this.Size = new System.Drawing.Size(282, 47);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2PictureBox pictureBoxIcon;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
		private Guna.UI2.WinForms.Guna2ProgressBar progressBarCountDown;
	}
}
