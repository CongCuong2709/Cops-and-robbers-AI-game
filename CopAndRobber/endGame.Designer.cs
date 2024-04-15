namespace CopAndRobber
{
    partial class endGame
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
            this.buttonReplay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // buttonReplay
            // 
            this.buttonReplay.BackColor = System.Drawing.Color.Transparent;
            this.buttonReplay.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonReplay.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonReplay.Image = global::CopAndRobber.Properties.Resources.buttonreplay;
            this.buttonReplay.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonReplay.ImageRotate = 0F;
            this.buttonReplay.Location = new System.Drawing.Point(602, 545);
            this.buttonReplay.Name = "buttonReplay";
            this.buttonReplay.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonReplay.Size = new System.Drawing.Size(64, 64);
            this.buttonReplay.TabIndex = 0;
            this.buttonReplay.Click += new System.EventHandler(this.buttonReplay_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::CopAndRobber.Properties.Resources.buttonback;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(767, 545);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.TabIndex = 1;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // endGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CopAndRobber.Properties.Resources.jerrygameover;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 767);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.buttonReplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "endGame";
            this.Text = "endGame";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton buttonReplay;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}