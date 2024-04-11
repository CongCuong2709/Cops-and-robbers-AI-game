using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using static CopAndRobber.NodeActor;
using System.Windows.Forms;

namespace CopAndRobber
{
	internal class GameLogic
	{
		private Dictionary<int, NodeActor> listNode;
		private Queue<Character> listTurnAction;

		private int numCat;

		private bool isEndGame = false;
		public GameLogic() {
			
		}

		public GameLogic(GameScreen screen, int numCat) {

			listNode = new Dictionary<int, NodeActor>();
			listTurnAction = new Queue<Character>();
			this.numCat = numCat;
		}

		private void stopGame()
		{

		}

		private void continueGame(GameScreen screen)
		{

		}

		public void startGame(GameScreen screen)
		{
			generateGame(screen, numCat);
			
			foreach(NodeActor node in listNode.Values)
			{
				node.nodeClicked += (sender, args) =>
				{
					Character character = listTurnAction.Peek();
					NodeActor nodeActor = (NodeActor)sender;

					character.moveTo(nodeActor);

					
				};
			}
		}

		private void Turn(Character character)
		{
			/*
			 High light các node actor khả thi
			Nếu người dùng click 1 node actor trong số đó thì di chuyển nhân vật đến đó. 
			chuyển sang lượt nhân vật khác
			 */
		}

		public void generateAllNode(GameScreen gameScreen)
		{
			try
			{
				string path = Path.Combine(Directory.GetCurrentDirectory(), "Assets\\NodeList.txt");
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
						gameScreen.GetPanelGameScreen().Controls.Add(nodeActor);
						Console.WriteLine(nodeActor);
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
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

		public void generateAllEdge(GameScreen gameScreen)
		{
			NodeActor nodeActor1 = new NodeActor(13, TRANSPORT_TYPE.TRAIN, 30, 80, null);
			NodeActor nodeActor2 = new NodeActor(20, TRANSPORT_TYPE.TRAIN, 130, 190, null);

			gameScreen.GetPanelGameScreen().Controls.Add(new EdgeActor(nodeActor1, nodeActor2));
		}

		public void generateGame(GameScreen gameScreen , int numCat)
		{

			generateAllNode(gameScreen);
			/*Character jerry = new Character();

			listTurnAction.Enqueue(jerry);*/
			
			for(int num = 0; num < numCat; num++)
			{
				int nodeID = 1; //random
				NodeActor nodeActor = GetNodeActorByID(nodeID);
				switch(num)
				{
					case 0:
						Character tom = new Character(GuiUtils.CHARACTER_NAME.TOM, nodeActor);
						gameScreen.GetPanelGameScreen().Controls.Add(tom);
						//tom.moveTo(GetNodeActorByID(46));
						listTurnAction.Enqueue(tom);
						break;
					case 1:
						Character butch = new Character(GuiUtils.CHARACTER_NAME.BUTCH, nodeActor);
						listTurnAction.Enqueue(butch);
						break;
					case 2:
						Character jones = new Character(GuiUtils.CHARACTER_NAME.JONES, nodeActor);
						listTurnAction.Enqueue(jones);
						break;				
					default:
						break;
				}
			}
		}
	}
}
