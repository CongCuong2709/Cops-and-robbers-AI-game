namespace CopAndRobber
{
	partial class Character
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
			this.pictureBoxCat = new Guna.UI2.WinForms.Guna2PictureBox();
			this.textBoxX = new System.Windows.Forms.TextBox();
			this.textBoxY = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxCat
			// 
			this.pictureBoxCat.BackColor = System.Drawing.Color.Silver;
			this.pictureBoxCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxCat.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxCat.ImageRotate = 0F;
			this.pictureBoxCat.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxCat.Name = "pictureBoxCat";
			this.pictureBoxCat.Size = new System.Drawing.Size(112, 107);
			this.pictureBoxCat.TabIndex = 0;
			this.pictureBoxCat.TabStop = false;
			// 
			// textBoxX
			// 
			this.textBoxX.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxX.Location = new System.Drawing.Point(112, 0);
			this.textBoxX.Name = "textBoxX";
			this.textBoxX.Size = new System.Drawing.Size(99, 26);
			this.textBoxX.TabIndex = 1;
			// 
			// textBoxY
			// 
			this.textBoxY.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxY.Location = new System.Drawing.Point(112, 26);
			this.textBoxY.Name = "textBoxY";
			this.textBoxY.Size = new System.Drawing.Size(99, 26);
			this.textBoxY.TabIndex = 2;
			// 
			// Character
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.Controls.Add(this.textBoxY);
			this.Controls.Add(this.textBoxX);
			this.Controls.Add(this.pictureBoxCat);
			this.Name = "Character";
			this.Size = new System.Drawing.Size(211, 107);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2PictureBox pictureBoxCat;
		private System.Windows.Forms.TextBox textBoxX;
		private System.Windows.Forms.TextBox textBoxY;
	}
}
