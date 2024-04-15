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

            using (Pen pen = new Pen(Color.Black, 30)) // Tạo một bút đen với độ dày 2
            {
                // Vẽ đường thẳng nối giữa hai nút
                pe.Graphics.DrawLine(pen, startPositionX, startPositionY, endPositionX, endPositionY);
            }
        }
    }
}
