using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopAndRobber
{
	public partial class ActionBar : UserControl
	{
		public ActionBar()
		{
			InitializeComponent();
		}

		public ActionBar(Character character)
		{
			InitializeComponent();
			pictureBoxIcon.Image = GuiUtils.getIcon(character);
			initProgressBar();
		}

		public void initProgressBar()
		{
			progressBarCountDown.Minimum = 0;
			progressBarCountDown.Maximum = 100;
			progressBarCountDown.Value = 100;
			progressBarCountDown.Visible = false;
		}

		public void startCountDown(int durationMilliseconds)
		{
			progressBarCountDown.Value = progressBarCountDown.Maximum;
			progressBarCountDown.Visible = true;

			Timer countTimer = new Timer();
			countTimer.Interval = 1000;
			countTimer.Tick += (sender, e) =>
			{
				if(progressBarCountDown.Value > 0)
				{
					progressBarCountDown.Value -= (int)(100 * countTimer.Interval / (double)durationMilliseconds);
				}
				else
				{
					countTimer.Stop();
					progressBarCountDown.Visible = false;
				}
			};

			countTimer.Start();
		}

		private void CountTimer_Tick(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}
