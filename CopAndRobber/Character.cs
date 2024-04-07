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

	public partial class Character : UserControl
	{

		private NodeActor atNode;
		private NodeActor endNode;
		private STATE_CHARACTER state;
		private CHARACTER character;
		private Timer animationTimer;
		private Image[] frames;

		private int distanceX, distanceY; //Khoang cach toa do tu atNode -> endNode
		private int speed = 4;

		private int currentFrame;
		

		public Character()
		{
			
			InitializeComponent();
			animationTimer = new Timer();
			animationTimer.Interval = 100;
			animationTimer.Tick += animation_Tick;
			setState(STATE_CHARACTER.WAIT);
			frames = new Image[4];
			frames = GuiUtils.TOM_GO_LEFT_SPRITE;
			this.Location = new Point(100, 100);
			this.BackColor = Color.Transparent;
			pictureBoxCat.SizeMode = PictureBoxSizeMode.Zoom;
			//this.Size = new Size(Size.Width, Size.Height);
			startAnimation();
		}

		public void moveTo(NodeActor nodeActor)
		{
			int destinationX = nodeActor.getPositionX();
			int destinationY = nodeActor.getPositionY();

			if (destinationX < this.Location.X)
			{
				setState(STATE_CHARACTER.GO_LEFT);
				if(this.Location.X <= destinationX)
				{
					
				}
			}
			else setState(STATE_CHARACTER.GO_RIGHT);
		}

		public Image[] getFrames()
		{
			return frames;
		}

		private void setAtNode(NodeActor node)
		{
			this.atNode = node;
		}

		private void startAnimation()
		{
			currentFrame = 0;
			animationTimer.Start();
		}

		private void stopAnimation()
		{
			animationTimer.Stop();
		}

		private void setState(STATE_CHARACTER state)
		{
			currentFrame = 0;
			this.state = state;

			switch (state)
			{
				case STATE_CHARACTER.WAIT:
					frames = GuiUtils.TOM_WAIT;
					break;
				case STATE_CHARACTER.GO_LEFT:
					frames = GuiUtils.TOM_GO_LEFT_SPRITE;
					break;
				case STATE_CHARACTER.GO_RIGHT:
					frames = GuiUtils.TOM_GO_LEFT_SPRITE;
					break;
				case STATE_CHARACTER.CATCH: 
					frames = GuiUtils.TOM_GO_LEFT_SPRITE;
					break;
				default: break;
			}
		}

		private void animation_Tick(object sender, EventArgs e)
		{
			switch (state)
			{
				case STATE_CHARACTER.GO_LEFT:
					{
						pictureBoxCat.Image = frames[currentFrame];
						currentFrame++;

						if(currentFrame >= frames.Length)
						{
							currentFrame = 0;
						}

						int deltaX = this.Location.X - endNode.getPositionY();
						int deltaY = Math.Abs(this.Location.Y - endNode.getPositionY());


						
						break;
					}

				case STATE_CHARACTER.GO_RIGHT:
					{
						
						pictureBoxCat.Image = frames[currentFrame];
						currentFrame++;

						if (currentFrame >= frames.Length)
						{
							currentFrame = 0;
						}
						break;
					}

				case STATE_CHARACTER.WAIT:
					{
						
						pictureBoxCat.Image = frames[currentFrame];
						currentFrame++;

						if (currentFrame == 4)
						{
							currentFrame = 0;
						}
						break;
					}

				default:
					{
						break;
					}
			}
		}
	}
}
