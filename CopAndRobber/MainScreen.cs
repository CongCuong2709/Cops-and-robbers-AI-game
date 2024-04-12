
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
	public partial class MainScreen : Form
	{
		SupportMethod supportMethod = new SupportMethod();
		private Form activeForm = null;
		public MainScreen()
		{
			InitializeComponent();
			
		}

		private void MainScreen_Load(object sender, EventArgs e)
		{
			supportMethod.openChildFormDockFill(this.activeForm, new WelcomeScreen(this), this.panelMainScreen);
		}
		public Panel getPanel()
		{
			return panelMainScreen;

        }
		
	}
}
