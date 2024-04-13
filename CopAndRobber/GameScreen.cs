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
        private Boolean isPause = false;
        public GameScreen(WaveOutEvent waveout, MainScreen mainscreen)
        {
            InitializeComponent();
            game = new GameLogic(this, 2);
            mainScreen = mainscreen;
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
        public GameLogic getGameLogic()
        {
            return game;
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
            this.Dispose();
            
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            supportMethod.openChildFormDockFill(this.activeForm, new Setting(waveOut, waveOut.Volume, this), mainScreen.getPanel());
            PauseButton_Click(sender,e);
            isPause = true;
            

        }

        //event nút tắt bật dừng
        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (!isPause)
            {
                foreach (Character c in game.getListTurnAction())
                {
                    c.stopAnimation();
                    c.stopSound();
                }
                isPause = true;
            }
            else
            {
                foreach (Character c in game.getListTurnAction())
                {
                    c.startAnimation();
                    c.playSound();
                }
                isPause = false;
            }
            
        }

        public Boolean getIsPause()
        {
            return isPause;
        }

        public void setIsPause(Boolean b)
        {
            isPause = b;
        }
        
        //event menu 3 gạch -> show dialog
        public TextBox GetTextBoxConsole()
        {
            return this.textBoxConsole;
        }
    }
}
