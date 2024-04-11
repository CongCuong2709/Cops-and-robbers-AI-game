using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using static CopAndRobber.NodeActor;

namespace CopAndRobber
{
	public partial class GameScreen : Form
	{
		private GameLogic game;
		private Panel panel_GameScreen;
		private Panel panelTurnTable;
		private Panel panelMoveLog;
		WaveOutEvent waveOut;
        private Form activeForm = null;
        MainScreen mainScreen = null;
        SupportMethod supportMethod = new SupportMethod();




        private Boolean isMute = false;
		public GameScreen(WaveOutEvent waveout, MainScreen mainccreen)
		{
			InitializeComponent();
			listNode = new Dictionary<int, NodeActor>();
			game = new GameLogic(this);
		}

		public GameScreen(int numCat)
		{
			InitializeComponent();
			game = new GameLogic(this, numCat);
		}

		public TurnTable GetPanelTurnTable()
		{
			return this.panelTurnTable;
		}

		public LogMove GetPanelMoveLog()
		{
			return this.panelLogMove;
		}

		public Panel GetPanelGameScreen()
		{
			return this.panelGameScreen;
		}

						NodeActor nodeActor = new NodeActor(id, transportType, locationX, locationY, nodeAdj);
						listNode.Add(id, nodeActor);
						this.panelGameScreen.Controls.Add(nodeActor);
						Console.WriteLine(nodeActor);
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
				DialogResult = MessageBox.Show("he", "canh bao", MessageBoxButtons.YesNo);
			}
		}

		private void GameScreen_Load(object sender, EventArgs e)
		{
			
			generateAllNode();
			//generateAllEdge();

			Character cat = new Character();
			pictureBox1.Image = cat.getFrames()[0];
			pictureBox2.Image = cat.getFrames()[1];
			pictureBox3.Image = cat.getFrames()[2];
			pictureBox4.Image = cat.getFrames()[3];
			panelGameScreen.Controls.Add(cat);

			NodeActor nodeActor1 = new NodeActor(13, TRANSPORT_TYPE.TRAIN, 500, 0, null);
			NodeActor nodeActor2 = new NodeActor(20, TRANSPORT_TYPE.TRAIN, 500, 190, null);

			//panelGameScreen.Controls.Add(new EdgeActor(nodeActor1, nodeActor2));

			cat.moveTo(GetNodeActorByID(1));
			cat.moveTo(GetNodeActorByID(46));


			/*
			 generate Game
			 */
			
		}

		

		//event nút tắt bật âm mà sound bật
		//event nút tắt bật dừng
		//event menu 3 gạch -> show dialog

    }
}
