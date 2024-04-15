using Guna.UI2.WinForms;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CopAndRobber.GuiUtils;

namespace CopAndRobber
{
	public partial class ActionBar : UserControl
	{
		GameScreen gameScreen;
		Timer countTimer;
		SupportMethod supportMethod = new SupportMethod();
		Character charr;

        public ActionBar()
        {
            InitializeComponent();
            initProgressBar();
            startCountDown(10000);
            this.Dock = DockStyle.Top;

        }

        public ActionBar(Character character)
		{
			InitializeComponent();
			initProgressBar();
			startCountDown(10000);
            this.Dock = DockStyle.Top;
            charr = character;
		}

		public void initProgressBar()
		{
			progressBarCountDown.Minimum = 0;
			progressBarCountDown.Maximum = 100;
			progressBarCountDown.Value = 100;
			progressBarCountDown.Visible = false;
		}

        private int currentProgressBarValue;
        public void startCountDown(int durationMilliseconds)
		{
			progressBarCountDown.Value = progressBarCountDown.Maximum;
			progressBarCountDown.Visible = true;

			countTimer = new Timer();
			countTimer.Interval = 1000;
			countTimer.Tick += (sender, e) =>
			{
				if(progressBarCountDown.Value > 0)
				{                   
                    progressBarCountDown.Value -= (int)(100 * countTimer.Interval / (double)durationMilliseconds);
                    currentProgressBarValue = progressBarCountDown.Value;
                }
				else
				{
					countTimer.Stop();
					progressBarCountDown.Visible = false;

					//supportMethod.AddChildFormDockFill(new endGame(this), guna2Panel1);
				}
			};

			countTimer.Start();
		}
        public void PauseCountDown()
        {
            // Dừng đồng hồ đếm
            countTimer.Stop();
        }

        // Tạo một phương thức để tiếp tục đếm ngược từ vị trí trước đó
        public void ContinueCountDown()
        {
            // Khởi động lại đồng hồ đếm với giá trị hiện tại của progress bar
            progressBarCountDown.Value = currentProgressBarValue;
            countTimer.Start();
        }
        public void setImage()
		{
			pictureBoxIcon.BackgroundImage = GuiUtils.getIcon(charr);
		}
        

    }
}
