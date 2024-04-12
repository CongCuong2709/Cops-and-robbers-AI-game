using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        WaveOutEvent waveOut;
        private Form activeForm = null;
        MainScreen mainScreen = null;
        SupportMethod supportMethod = new SupportMethod();



        private Boolean isMute = false;
        public GameScreen(WaveOutEvent waveout, MainScreen mainccreen)
        {
            InitializeComponent();
            game = new GameLogic(this, 1);
            mainScreen = mainccreen;
            waveOut = waveout;
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


        private void GameScreen_Load(object sender, EventArgs e)
        {
            game.startGame(this);
            /*
			 generate Game
			 */

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
