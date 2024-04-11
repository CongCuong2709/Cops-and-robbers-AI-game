using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CopAndRobber.NodeActor;

namespace CopAndRobber
{
	public partial class GameScreen : Form
	{
		private Dictionary<int, NodeActor> listNode;
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
			mainScreen = mainccreen;
			waveOut = waveout;


            //game = new GameLogic(this);
        }
		

        public GameScreen(int numCat)
		{
			InitializeComponent();

		}

		public Panel GetPanelTurnTable()
		{
			return panelTurnTable;
		}

		public Panel GetPanelMoveLog()
		{
			return panelMoveLog;
		}

		public Panel GetPanelGameScreen()
		{
			return panel_GameScreen;
		}

		public void generateAllNode()
		{
			try
			{
				string path = Path.Combine(Directory.GetCurrentDirectory(), "Assets\\NodeList.txt");
				textBoxConsole.Text = path;
				using (StreamReader sr = new StreamReader(path))
				{
					while (!sr.EndOfStream)
					{
						string line = sr.ReadLine();
						string[] paths = line.Split(' ');
						int id = int.Parse(paths[0]);
						TRANSPORT_TYPE transportType;
						if (paths[1].Equals("T"))
						{
							transportType = TRANSPORT_TYPE.TRAIN;
						}
						else if (paths[1].Equals("B"))
						{
							transportType = TRANSPORT_TYPE.BUS;
						}
						else
						{
							transportType = TRANSPORT_TYPE.WALK;
						}
						int locationX = int.Parse(paths[2]);
						int locationY = int.Parse(paths[3]);
						HashSet<int> nodeAdj = new HashSet<int>();
						if (paths.Length > 4)
						{

							for (int index = 4; index < paths.Length; index++)
							{
								nodeAdj.Add(int.Parse(paths[index]));
							}
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
				DialogResult = MessageBox.Show("Huh?", "canh bao", MessageBoxButtons.YesNo);
			}
		}

		public NodeActor GetNodeActorByID(int id)
		{
			if (listNode.ContainsKey(id))
			{
				return listNode[id];
			}
			return null;
		}

		public void generateAllEdge() {
			NodeActor nodeActor1 = new NodeActor(13, TRANSPORT_TYPE.TRAIN, 30, 80, null);
			NodeActor nodeActor2 = new NodeActor(20, TRANSPORT_TYPE.TRAIN, 130, 190, null);

			panelGameScreen.Controls.Add(new EdgeActor(nodeActor1, nodeActor2));
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
			


			/*
			 generate Game
			 */
			
		}


		private void generateGame(int numCat)
		{
			//Init turn table
			//Init clock
			//put character
		}

        //event nút tắt bật âm mà sound bật
        private void SoundButton_Click(object sender, EventArgs e)
        {
            if (!isMute)
            {
                waveOut.Pause();
                isMute = true;
                SoundButton.Image = Properties.Resources.soundbuttonmute;

            }
            else
            {
                waveOut.Play();
                isMute = false;
                SoundButton.Image = Properties.Resources.soundbutton;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            supportMethod.openChildFormDockFill(this.activeForm, new Setting(waveOut, waveOut.Volume), mainScreen.getPanel());
        }




        //event nút tắt bật dừng
        //event menu 3 gạch -> show dialog

    }
}
