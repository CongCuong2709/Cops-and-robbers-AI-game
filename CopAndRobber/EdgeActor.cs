using Guna.UI2.WinForms;
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
	public partial class EdgeActor : PictureBox
	{

		private int startId, endId;
		private int startPositionX, endPositionX, startPositionY, endPositionY;
		

		public EdgeActor(NodeActor nodeA, NodeActor nodeB)
		{
			this.startId = nodeA.getID();
			this.endId = nodeB.getID();

			this.startPositionX = nodeA.getPositionX();
			this.endPositionY = nodeB.getPositionY();
			this.startPositionY = nodeA.getPositionY();
			this.endPositionY = nodeB.getPositionY();

			this.Location = new Point(startPositionX, startPositionY);
			
			

		}

		public EdgeActor()
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			Point[] destinationPoints = {
				new Point(200, 20),   // destination for upper-left point of
                      // original
				new Point(110, 100),  // destination for upper-right point of
                      // original
				new Point(250, 30)};  // destination for lower-left point of
					  // original

			Image image = new Bitmap("menuInterface.png");

			// Draw the image unaltered with its upper-left corner at (0, 0).
			pe.Graphics.DrawImage(image, 0, 0);

			// Draw the image mapped to the parallelogram.
			pe.Graphics.DrawImage(image, destinationPoints);
		}
	}
}
