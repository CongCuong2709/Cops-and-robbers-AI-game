using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
		private CHARACTER_NAME character;
		private Timer animationTimer;
		private Image[] frames;

		private int distanceX, distanceY; //Khoang cach toa do tu atNode -> endNode
		private int deltaX = 0, deltaY = 0;
		private int speed = 4;

		private int currentFrame;

		private SoundPlayer soundPlayer;
		private bool isPlayable;
		private Boolean isChased;


		public Character()
		{		
			InitializeComponent();
			animationTimer = new Timer();
			animationTimer.Interval = 100;
			animationTimer.Tick += animation_Tick;
			setState(STATE_CHARACTER.WAIT);
			//frames = new Image[4];

			this.BringToFront();
			frames = GuiUtils.getSprite(character, state, GuiUtils.getNumFrame(character, state));
			this.Location = new Point(400, 200);
			this.BackColor = Color.Transparent;
			pictureBoxCat.SizeMode = PictureBoxSizeMode.Zoom;
			//this.Size = new Size(Size.Width, Size.Height);
		
			soundPlayer = new SoundPlayer();
			startAnimation();
		}

		public Character(CHARACTER_NAME name, NodeActor atNode)
		{
			InitializeComponent();
			animationTimer = new Timer();
			animationTimer.Interval = 100;
			animationTimer.Tick += animation_Tick;

			setState(STATE_CHARACTER.WAIT);

			this.character = name;
			this.atNode = atNode;
			this.endNode = null;

			this.BringToFront();
			this.Location = new Point(atNode.getPositionX(), atNode.getPositionY() - this.Height);
			this.BackColor = Color.Transparent;
			pictureBoxCat.SizeMode = PictureBoxSizeMode.Zoom;
			//this.Size = new Size(Size.Width, Size.Height);

			frames = GuiUtils.getSprite(character, state, GuiUtils.getNumFrame(character, state));
			soundPlayer = new SoundPlayer();
			startAnimation();

		}

		public NodeActor getAtNode()
		{
			return atNode;
		}

		public void moveTo(NodeActor nodeActor)
		{
			this.endNode = nodeActor;
			this.textBoxX.Text = endNode.getID().ToString();

			int destinationX = endNode.getPositionX();
			int destinationY = endNode.getPositionY() - this.Height;

			distanceX = Math.Abs(destinationX - this.Location.X);
			distanceY = Math.Abs(destinationY - this.Location.Y);

			double angle = 0;
			//Tính tốc độ theo trục 
			try
			{
				angle = Math.Atan2(distanceY, distanceX);
				
			} catch(DivideByZeroException ex)
			{
				
			}
			finally
			{
				deltaX = (int)Math.Ceiling(Math.Cos(angle) * speed);
				deltaY = (int)Math.Ceiling(Math.Sin(angle) * speed);
			}

			//Set up hướng đi
			if (destinationX < this.Location.X)
			{
				setState(STATE_CHARACTER.GO_LEFT);
			}
			else setState(STATE_CHARACTER.GO_RIGHT);

		}

		public Image[] getFrames()
		{
			return frames;
		}

		public CHARACTER_NAME getCharacterName()
		{
			return this.character;
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
					stopSound();
					frames = GuiUtils.getSprite(character, state, GuiUtils.getNumFrame(character, state));
					this.textBoxY.Text = state.ToString();
					break;
				case STATE_CHARACTER.GO_LEFT:
					playSound();
					frames = GuiUtils.getSprite(character, state, GuiUtils.getNumFrame(character, state));
					this.textBoxY.Text = state.ToString();
					break;
				case STATE_CHARACTER.GO_RIGHT:
					playSound();
					frames = GuiUtils.getSprite(character, state, GuiUtils.getNumFrame(character, state));
					this.textBoxY.Text = state.ToString();
					break;
				case STATE_CHARACTER.CATCH:
					playSound();
					frames = GuiUtils.getSprite(character, state, GuiUtils.getNumFrame(character, state));
					this.textBoxY.Text = state.ToString();
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
						/*if(endNode.getPositionX() == atNode.getPositionX())
						{
							int newLocationX = this.Location.X;
							int newLocationY = this.Location.Y + deltaY;

							this.Location = new Point(newLocationX, newLocationY);
						}*/

						if(this.Location.Y <= endNode.getPositionY() - this.Height)
						{
							int newLocationX = this.Location.X - deltaX;
							int newLocationY = this.Location.Y + deltaY;



							if (newLocationX <= endNode.getPositionX() && newLocationY >= (endNode.getPositionY() - this.Height))
							{
								
								setState(STATE_CHARACTER.WAIT);
								return;
							}

							this.Location = new Point(newLocationX, newLocationY);
							
						}
						else
						{
							int newLocationX = this.Location.X - deltaX;
							int newLocationY = this.Location.Y - deltaY;

							if (newLocationX <= endNode.getPositionX() && newLocationY <= endNode.getPositionY() - this.Height)
							{
								if (newLocationX <= endNode.getPositionX()) newLocationX += deltaX;
								if (newLocationY <= endNode.getPositionY() - this.Height) newLocationY += deltaY;
								setState(STATE_CHARACTER.WAIT);
								return;
							}

							this.Location = new Point(newLocationX, newLocationY);
							
						}
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

						if (this.Location.Y <= endNode.getPositionY() - this.Height)
						{
							int newLocationX = this.Location.X + deltaX;
							int newLocationY = this.Location.Y + deltaY;

							if (newLocationX >= endNode.getPositionX() && newLocationY >= endNode.getPositionY() - this.Height)
							{
								setState(STATE_CHARACTER.WAIT);
								break;
							}


							this.Location = new Point(newLocationX, newLocationY);
						}
						else
						{
							int newLocationX = this.Location.X + deltaX;
							int newLocationY = this.Location.Y - deltaY;

							

							this.Location = new Point(newLocationX, newLocationY);
						}

						if(this.Location.X >= endNode.getPositionX() && this.Location.Y <= endNode.getPositionY() + this.Height)
						{
							setState(STATE_CHARACTER.WAIT);
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

						/*if(endNode != null)
						{
							atNode = endNode;
							endNode = null;
						}*/
						break;
					}
				case STATE_CHARACTER.CATCH:
					
					break;
				default:
					{
						break;
					}
			}
		}

		private void playSound()
		{
			if(this.state == STATE_CHARACTER.GO_LEFT || this.state == STATE_CHARACTER.GO_RIGHT)
			{
				soundPlayer = GuiUtils.SOUND_CAT_WALK;
				soundPlayer.PlayLooping();
			}
			if(this.state == STATE_CHARACTER.CATCH)
			{
				soundPlayer = GuiUtils.SOUND_CAT_CATCH;
				soundPlayer.PlayLooping();
			}
		}

		private void stopSound()
		{
			if(soundPlayer != null)
				soundPlayer.Stop();
		}
	}
}
