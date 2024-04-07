using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

		public GameScreen()
		{
			InitializeComponent();
			listNode = new Dictionary<int, NodeActor>();
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
				DialogResult = MessageBox.Show("he", "canh bao", MessageBoxButtons.YesNo);
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

			Character cat = new Character();
			pictureBox1.Image = cat.getFrames()[0];
			pictureBox2.Image = cat.getFrames()[1];
			pictureBox3.Image = cat.getFrames()[2];
			pictureBox4.Image = cat.getFrames()[3];
			panelGameScreen.Controls.Add(cat);

			//generateAllEdge();
		}
	}
}
