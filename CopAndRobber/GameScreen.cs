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


		private SoundPlayer soundGame;
		public GameScreen()
		{
			InitializeComponent();
			game = new GameLogic(this, 1);
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


		public void generateAllEdge() {
			NodeActor nodeActor1 = new NodeActor(13, TRANSPORT_TYPE.TRAIN, 30, 80, null);
			NodeActor nodeActor2 = new NodeActor(20, TRANSPORT_TYPE.TRAIN, 130, 190, null);

			panelGameScreen.Controls.Add(new EdgeActor(nodeActor1, nodeActor2));
		}

		private void GameScreen_Load(object sender, EventArgs e)
		{
			game.startGame(this);
			/*
			 generate Game
			 */
			
		}
		//event nút tắt bật âm mà sound bật
		//event nút tắt bật dừng
		//event menu 3 gạch -> show dialog

	}
}
