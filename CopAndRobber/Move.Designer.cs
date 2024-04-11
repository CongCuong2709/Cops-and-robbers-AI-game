namespace CopAndRobber
{
	partial class Move
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
			this.textBoxMove = new Guna.UI2.WinForms.Guna2TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxIcon
			// 
			this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxIcon.ImageRotate = 0F;
			this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxIcon.Name = "pictureBoxIcon";
			this.pictureBoxIcon.Size = new System.Drawing.Size(35, 36);
			this.pictureBoxIcon.TabIndex = 0;
			this.pictureBoxIcon.TabStop = false;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Panel1.Location = new System.Drawing.Point(35, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(12, 36);
			this.guna2Panel1.TabIndex = 1;
			// 
			// textBoxMove
			// 
			this.textBoxMove.BackColor = System.Drawing.Color.Transparent;
			this.textBoxMove.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxMove.DefaultText = "";
			this.textBoxMove.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.textBoxMove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.textBoxMove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBoxMove.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.textBoxMove.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxMove.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.textBoxMove.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.textBoxMove.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.textBoxMove.Location = new System.Drawing.Point(47, 0);
			this.textBoxMove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxMove.Name = "textBoxMove";
			this.textBoxMove.PasswordChar = '\0';
			this.textBoxMove.PlaceholderText = "";
			this.textBoxMove.SelectedText = "";
			this.textBoxMove.Size = new System.Drawing.Size(175, 36);
			this.textBoxMove.TabIndex = 2;
			// 
			// Move
			// 
			this.Controls.Add(this.textBoxMove);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.pictureBoxIcon);
			this.Name = "Move";
			this.Size = new System.Drawing.Size(222, 36);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2PictureBox pictureBoxIcon;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2TextBox textBoxMove;
	}
}
