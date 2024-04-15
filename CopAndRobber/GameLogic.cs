﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using static CopAndRobber.NodeActor;
using System.Windows.Forms;
using NAudio.Wave;

namespace CopAndRobber
{
    public class GameLogic
    {
        private Dictionary<int, NodeActor> listNode;
        private Queue<Character> listTurnAction;
        private Stack<Move> moveStack;

        private NodeActor JerryAtNode;
        private NodeActor NodeClicked;
        private Character currentCharacter;
        private int numCat;

        private GameScreen screen;
        private Graph graph;
        private A_star a_Star;

        ActionBar actionBar;
        Timer countTimer;
        private int remainingTime = 0;

        SupportMethod supportMethod = new SupportMethod();
        private Form activeForm = null;
        public GameLogic()
        {

        }

        public GameLogic(GameScreen screen, int numCat)
        {

            listNode = new Dictionary<int, NodeActor>();
            listTurnAction = new Queue<Character>();
            moveStack = new Stack<Move>();
            this.numCat = numCat;
            this.screen = screen;
            
        }

        public void stopGame(Character c)
        {
            
        }

        public void continueGame(GameScreen screen)
        {
            
        }

        public void startGame(GameScreen screen)
        {
            this.screen = screen;   //???
            generateGame(screen, numCat);
            string testActionTurn = string.Empty;
			graph = new Graph(this, 256);
			a_Star = new A_star(graph);

			currentCharacter = listTurnAction.Peek();
			changeTurn(currentCharacter);

			foreach (NodeActor node in listNode.Values)
			{
                node.nodeClicked += HandleNodeClicked;
			}
		}

		void HandleNodeClicked(object sender, EventArgs args)
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
				if (currentCharacter.getCharacterName() == GuiUtils.CHARACTER_NAME.JERRY)
				{
					JerryAtNode = nodeActor;
				}

				currentCharacter.moveTo(nodeActor);
				updateLogMove(screen, currentCharacter, currentCharacter.getAtNode(), nodeActor);
				setNodeAdjDisable(currentCharacter);

                currentCharacter.StateChanged -= HandleCharacterStateChanged;
                currentCharacter.StateChanged += HandleCharacterStateChanged;

                if (countTimer != null)
                    stopCount();

            }
		}
        public void setCharacterAt(Character c, NodeActor node)
        {
            c.setAtNode(node);
            //currentCharacter.setAtNode(nodeActor);
            actionBar = new ActionBar(c);
            screen.GetPanelTurnTable().Controls.Clear();
            screen.GetPanelTurnTable().Controls.Add(actionBar);
            actionBar.setImage();
            
            startCount10s(10000);
        }

        public void startCount10s(int durationMilliseconds)
        {
            // Khởi tạo Timer
            countTimer = new Timer();
            countTimer.Interval = durationMilliseconds;
            remainingTime = durationMilliseconds;
            countTimer.Tick += (sender, e) =>
            {
                countTimer.Stop();
                screen.endGame();
            };

            // Bắt đầu đếm ngược
            countTimer.Start();
        }
        public void stopCount()
        {
            if (countTimer != null)
            {
                countTimer.Stop();
                // Lưu thời gian còn lại
                //remainingTime -= countTimer.Interval;
            }
        }

        public void resumeCount()
        {
            // Tiếp tục đếm ngược với thời gian còn lại
            startCount10s(remainingTime);
        }

        void HandleCharacterStateChanged(object sender, EventArgs args)
		{
			Character character = (Character)sender;
			if (character.getState() == GuiUtils.STATE_CHARACTER.WAIT)
			{
				//isEndGame(character);

				character.setAtNode(character.getAtNode()); // Không cần gán nodeActor ở đây vì đã được xử lý khi click
				listTurnAction.Enqueue(listTurnAction.Dequeue());
				/*testActionTurn += listTurnAction.Peek().ToString();
				screen.GetTextBoxConsole().Text = testActionTurn;*/
				changeTurn(listTurnAction.Peek());
                setCharacterAt(listTurnAction.Peek(), character.getAtNode());

            }
            else
            {
                if (countTimer != null && actionBar != null)
                    screen.GetPanelTurnTable().GetActionBar().PauseCountDown();


            }
		}

		private void changeTurn(Character nextCharacter)
        {
            if (nextCharacter.isPlayer())
            {
                highLightAllNodeCanMove(nextCharacter);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ai tủn ", " ", MessageBoxButtons.YesNo);
                AIMove(nextCharacter);
            }

}

        public void isEndGame(Character character)
        {
            if(character.getCharacterName() != GuiUtils.CHARACTER_NAME.JERRY)
            {
                if(character.getAtNode() == JerryAtNode)
                {
                    character.setState(GuiUtils.STATE_CHARACTER.CATCH);
                    //do end game
                    //stop game
                    //Hiện kết quả, lưu vào file 
                }
            }
        }

        private void AIMove(Character character)
        {
            if(!character.isPlayer())
            {
                if(character.getState() == GuiUtils.STATE_CHARACTER.WAIT)
                {
                    int finish = 8;
                    a_Star.search(graph, character.getAtNode().getID(), finish);
					Queue<int> shortestPath = a_Star.getEdgeTo(graph, finish);
                    DialogResult dialogResult = MessageBox.Show("sap get ", "", MessageBoxButtons.YesNo);
                    NodeActor nextNode = GetNodeActorByID(shortestPath.Peek());
                    if(nextNode == null)
                    {
                        DialogResult dialogResult1 = MessageBox.Show("next node null: " + shortestPath.Dequeue(), "",
                            MessageBoxButtons.YesNo);
                    }

                   // NodeActor nextNode = GetNodeActorByID(2);

					character.moveTo(nextNode);
					//character.moveTo(GetNodeActorByID(2));
                    //............

					character.setAtNode(nextNode);
                    listTurnAction.Enqueue(listTurnAction.Dequeue());
                    changeTurn(listTurnAction.Peek());
				}


			}
        }

        public void highLightAllNodeCanMove(Character character)
        {
            NodeActor nodeActor = character.getAtNode();
            foreach (int id in nodeActor.getNodeAdj())
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

        public Dictionary<int, NodeActor> getListNode()
        {
            return listNode;
        }

        public void updateLogMove(GameScreen screen, Character character, NodeActor atNode, NodeActor endNode)
        {
            Move move = new Move(character, atNode, endNode);
            moveStack.Push(move);
            Stack<Move> moves = new Stack<Move>();

            foreach (var item in moveStack)
            {
                moves.Push(item);
            }
            screen.GetPanelMoveLog().Controls.Clear();
            foreach (Move move1 in moves)
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

        public Queue<Character> getListTurnAction()
        {
            return listTurnAction;
        }

        public void generateGame(GameScreen gameScreen, int numCat)
        {

            generateAllNode(gameScreen);
            /*Character jerry = new Character();
			listTurnAction.Enqueue(jerry);*/

            for (int num = 0; num < numCat; num++)
            {
                int nodeID = 1; //random
                NodeActor nodeActor = GetNodeActorByID(nodeID);
                switch (num)
                {
                    case 0:
                        Character tom = new Character(GuiUtils.CHARACTER_NAME.TOM, nodeActor);
                        tom.setIsPlayable(true);
                        gameScreen.GetPanelGameScreen().Controls.Add(tom);
                        listTurnAction.Enqueue(tom);
                        break;
                    case 1:
                        Character butch = new Character(GuiUtils.CHARACTER_NAME.BUTCH, nodeActor);
                        butch.setIsPlayable(false);
                        gameScreen.GetPanelGameScreen().Controls.Add(butch);
                        listTurnAction.Enqueue(butch);

                        break;
                    case 2:
                        Character jones = new Character(GuiUtils.CHARACTER_NAME.JONES, nodeActor);
                        gameScreen.GetPanelGameScreen().Controls.Add(jones);
                        jones.setIsPlayable(false);
                        listTurnAction.Enqueue(jones);
                        break;
                    default:
                        break;
                }
            }
        }

        

    }
}
