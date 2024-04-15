namespace CopAndRobber
{
    partial class Setting
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
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.volSlider = new NAudio.Gui.VolumeSlider();
            this.buttonReset = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SoundButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 15;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(134, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 45);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // volSlider
            // 
            this.volSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volSlider.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.volSlider.BackColor = System.Drawing.SystemColors.Control;
            this.volSlider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.volSlider.Location = new System.Drawing.Point(351, 199);
            this.volSlider.Name = "volSlider";
            this.volSlider.Size = new System.Drawing.Size(128, 35);
            this.volSlider.TabIndex = 2;
            this.volSlider.VolumeChanged += new System.EventHandler(this.volSlider_VolumeChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReset.BackColor = System.Drawing.Color.Transparent;
            this.buttonReset.CheckedState.ImageSize = new System.Drawing.Size(48, 48);
            this.buttonReset.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.buttonReset.Image = global::CopAndRobber.Properties.Resources.resetbutton;
            this.buttonReset.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonReset.ImageRotate = 0F;
            this.buttonReset.ImageSize = new System.Drawing.Size(48, 48);
            this.buttonReset.Location = new System.Drawing.Point(365, 309);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.buttonReset.Size = new System.Drawing.Size(64, 54);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // SoundButton
            // 
            this.SoundButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SoundButton.BackColor = System.Drawing.Color.Transparent;
            this.SoundButton.CheckedState.ImageSize = new System.Drawing.Size(48, 48);
            this.SoundButton.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.SoundButton.Image = global::CopAndRobber.Properties.Resources.soundbutton;
            this.SoundButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.SoundButton.ImageRotate = 0F;
            this.SoundButton.ImageSize = new System.Drawing.Size(48, 48);
            this.SoundButton.Location = new System.Drawing.Point(365, 240);
            this.SoundButton.Name = "SoundButton";
            this.SoundButton.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.SoundButton.Size = new System.Drawing.Size(64, 54);
            this.SoundButton.TabIndex = 10;
            this.SoundButton.Click += new System.EventHandler(this.SoundButton_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::CopAndRobber.Properties.Resources._12096731;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.SoundButton);
            this.Controls.Add(this.volSlider);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private NAudio.Gui.VolumeSlider volSlider;
        private Guna.UI2.WinForms.Guna2ImageButton SoundButton;
        private Guna.UI2.WinForms.Guna2ImageButton buttonReset;
    }
}