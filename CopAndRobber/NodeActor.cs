using Guna.UI2.WinForms;
using System;
using System.CodeDom;
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
	public partial class NodeActor :Button
	{
		private int _id;
		private int position_X, position_Y;
		private HashSet<int> nodeAdj;

		public enum TRANSPORT_TYPE
		{
			TRAIN,
			BUS,
			WALK
		}


		public NodeActor (int id, TRANSPORT_TYPE transportType, int position_X, int position_Y, HashSet<int> nodeAdj)
		{
			_id = id;
			this.position_X = position_X;
			this.position_Y = position_Y;
			this.nodeAdj = nodeAdj;
			this.Location = new Point(position_X, position_Y);
			this.BackgroundImage = GuiUtils.LOGO;
			this.Visible = true;
			this.Anchor = AnchorStyles.Left | AnchorStyles.Top;

			this.Text = _id.ToString();
		}

		public int getPositionX()
		{
			return this.position_X;
		}

		public int getPositionY()
		{
			return this.position_Y;
		}

		public int getID()
		{
			return _id;
		}

		public NodeActor()
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			
			base.OnPaint(pe);
		}

		public override string ToString()
		{
			return _id + " " + position_X + " " + position_Y;
		}
	}
}
