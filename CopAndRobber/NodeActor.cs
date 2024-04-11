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
	public partial class NodeActor : Button
	{
		public event EventHandler nodeClicked;

		private int _id;
		private TRANSPORT_TYPE type;
		private int position_X, position_Y;
		private HashSet<int> nodeAdj;

		private bool isChoosen;
		public enum TRANSPORT_TYPE
		{
			TRAIN,
			BUS,
			WALK
		}

		public NodeActor()
		{
			InitializeComponent();
		}

		public NodeActor (int id, TRANSPORT_TYPE transportType, int position_X, int position_Y, HashSet<int> nodeAdj)
		{
			_id = id;
			this.position_X = position_X;
			this.position_Y = position_Y;
			this.nodeAdj = nodeAdj;
			this.type = transportType;

			this.Click += nodeActor_click;
			//this.Enabled = false;
			this.Location = new Point(position_X, position_Y);
			switch (type)
			{
				case TRANSPORT_TYPE.TRAIN:
					this.BackgroundImage = GuiUtils.NODE_TRAIN;
					break;
				case TRANSPORT_TYPE.BUS:
					this.BackgroundImage = GuiUtils.NODE_BUS;
					break;
				case TRANSPORT_TYPE.WALK:
					this.BackgroundImage = GuiUtils.NODE_WALK;
					break;
				default:
					break;
			}
			
			this.BackgroundImageLayout = ImageLayout.Stretch;
			
			this.Visible = true;
			this.Anchor = AnchorStyles.Left | AnchorStyles.Top;
			this.Text = _id.ToString();
		}

		public int getPositionX()
		{
			return this.Location.X;
		}

		public int getPositionY()
		{
			return this.Location.Y;
		}

		public int getID()
		{
			return _id;
		}

		public HashSet<int> getNodeAdj()
		{
			return this.nodeAdj;
		}

		public void makeLightNodeActor()
		{

		}

		public void notChoosen()
		{
			this.Enabled = isChoosen;
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}

		public override string ToString()
		{
			return _id + " " + position_X + " " + position_Y;
		}

		private void nodeActor_click(object sender, EventArgs e)
		{
			nodeClicked?.Invoke(this, EventArgs.Empty);
		}
	}
}
