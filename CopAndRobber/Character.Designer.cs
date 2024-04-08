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
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxCat
			// 
			this.pictureBoxCat.BackColor = System.Drawing.Color.Silver;
			this.pictureBoxCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxCat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxCat.ImageRotate = 0F;
			this.pictureBoxCat.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxCat.Name = "pictureBoxCat";
			this.pictureBoxCat.Size = new System.Drawing.Size(112, 107);
			this.pictureBoxCat.TabIndex = 0;
			this.pictureBoxCat.TabStop = false;
			// 
			// Character
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.pictureBoxCat);
			this.Name = "Character";
			this.Size = new System.Drawing.Size(112, 107);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCat)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2PictureBox pictureBoxCat;
	}
}
