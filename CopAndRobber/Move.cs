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
	public partial class Move : UserControl
	{
		public Move()
		{
			InitializeComponent();
		}

		public Move(Character character, NodeActor atNode, NodeActor endNode)
		{
			InitializeComponent();

			this.Dock = DockStyle.Top;
			pictureBoxIcon.BackgroundImage = GuiUtils.getIcon(character);
			textBoxMove.Text = atNode.getID().ToString() + " -> " + endNode.getID().ToString();
		}
	}
}
