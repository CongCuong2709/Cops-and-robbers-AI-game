using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CopAndRobber
{
	internal class GameLogic
	{
		private Panel panelMoveLog;
		private Panel panelTurnTable;
		private Panel panelGameScreen;
		private Queue<Character> listTurnAction;
		public GameLogic() {
			
		}



		public GameLogic(GameScreen screen, int numCat) { 
			
		}

		private void stopGame()
		{

		}

		private void continueGame(GameScreen screen)
		{

		}

		private void startGame(GameScreen screen)
		{

		}

		private void changeTurnTo(Character character)
		{

		}

		public void generateGame(GameScreen gameScreen , int numCat)
		{
			Character jerry = new Character();
			
			for(int num = 0; num < numCat; num++)
			{
				int nodeID = num; //random
				NodeActor nodeActor = gameScreen.GetNodeActorByID(nodeID);
				switch(num)
				{
					case 0:
						Character tom = new Character(0, nodeActor);
						panelGameScreen.Controls.Add(tom);
						break;
					case 1:
						Character butch = new Character(0, nodeActor);
						break;
					case 2:
						Character jones = new Character(0, nodeActor);
						break;
					case 3:
						Character chigo = new Character(0, nodeActor);
						break;
					default:
						break;
				}
			}
		}
	}
}
