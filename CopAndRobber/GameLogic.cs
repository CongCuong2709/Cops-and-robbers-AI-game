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
		private Stack<Move> moveStack;

        private int numCat;

        private bool isEndGame = false;
        public GameLogic()
        {

        }

        public GameLogic(GameScreen screen, int numCat)
        {

			listNode = new Dictionary<int, NodeActor>();
			listTurnAction = new Queue<Character>();
			moveStack = new Stack<Move>();
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

			Character currentCharacter = listTurnAction.Peek();

			changeTurn(currentCharacter);
			//listTurnAction.Enqueue(jerry);

			foreach (NodeActor node in listNode.Values)
			{
				node.nodeClicked += (sender, args) =>
				{
					NodeActor nodeActor = (NodeActor)sender;
					if (currentCharacter.getState() == GuiUtils.STATE_CHARACTER.WAIT)
					{
						currentCharacter = listTurnAction.Peek();
						//init button ...	
						changeTurn(currentCharacter);
					}
					if (currentCharacter == listTurnAction.Peek())
					{
						currentCharacter.moveTo(nodeActor);
						
						updateLogMove(screen, currentCharacter, currentCharacter.getAtNode(), nodeActor);
						setNodeAdjDisable(currentCharacter);

						currentCharacter.StateChanged += (s, e) =>
						{
							Character character = (Character)s;
							if(character.getState() == GuiUtils.STATE_CHARACTER.WAIT)
							{
								character.setAtNode(nodeActor);
								listTurnAction.Enqueue(listTurnAction.Dequeue());
								changeTurn(listTurnAction.Peek());

							}
						};						
					}
					
				};
			}
		}

		private void changeTurn(Character character)
		{
			highLightAllNodeCanMove(character);

		}

		public void highLightAllNodeCanMove(Character character)
		{
			NodeActor nodeActor = character.getAtNode();
			foreach(int id in nodeActor.getNodeAdj())
			{
				NodeActor nodeAdj = GetNodeActorByID(id);
				nodeAdj.Enabled = true;
				nodeAdj.makeLightNodeActor();
				
			}

			//make light edge
			
		}

		public void setNodeAdjDisable(Character character)
		{
			foreach(int id in character.getAtNode().getNodeAdj())
			{
				try
				{
					NodeActor nodeAdj = GetNodeActorByID(id);
					nodeAdj.Enabled = false;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}

		public void updateLogMove(GameScreen screen ,Character character, NodeActor atNode, NodeActor endNode)
		{
			Move move = new Move(character, atNode, endNode);
			moveStack.Push(move);
			Stack<Move> moves = new Stack<Move>();

            foreach (var item in moveStack)
            {
				moves.Push(item);
            }
            screen.GetPanelMoveLog().Controls.Clear();
			foreach(Move move1 in moves)
			{
				screen.GetPanelMoveLog().Controls.Add(move1);
			}
			
		}

		public void updateActionTable(Character character)
		{

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

        public void generateGame(GameScreen gameScreen, int numCat)
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
						listTurnAction.Enqueue(tom);
						break;
					case 1:
						Character butch = new Character(GuiUtils.CHARACTER_NAME.BUTCH, nodeActor);
						gameScreen.GetPanelGameScreen().Controls.Add(butch);
						listTurnAction.Enqueue(butch);
						
						break;
					case 2:
						Character jones = new Character(GuiUtils.CHARACTER_NAME.JONES, nodeActor);
						gameScreen.GetPanelGameScreen().Controls.Add(jones);
						listTurnAction.Enqueue(jones);
						break;				
					default:
						break;
				}
			}
		}
	}
}
