using Guna.UI2.WinForms;
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
        MainScreen mainScreen;
        SupportMethod supportMethod = new SupportMethod();

        private Timer timer;
        private int seconds;

        private Boolean isMute = false;
        private Boolean isPause = false;

        
        public GameScreen(WaveOutEvent waveout, MainScreen screen)
        {
            InitializeComponent();
            game = new GameLogic(this, 2);
            mainScreen = screen;
            waveOut = waveout;
            
            timer = new Timer();
            timer.Interval = 1000;

            // Đăng ký sự kiện Tick của Timer
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Tăng biến đếm thời gian mỗi giây
            seconds++;

            // Hiển thị thời gian đếm trên Label
            lblTime.Text = TimeSpan.FromSeconds(seconds).ToString(@"mm\:ss");
        }

        
        public GameScreen(int numCat)
        {
            InitializeComponent();
            game = new GameLogic(this, numCat);
        }

        public GameScreen()
        {
            InitializeComponent();
            
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
        public MainScreen GetMainScreen() { 
            return this.mainScreen;
        }

        public WaveOutEvent GetWaveOut()
        {
            return waveOut;
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
            timer.Stop();

        }

        public void endGame()
        {
            supportMethod.AddChildFormDockFill(new endGame(mainScreen, waveOut), mainScreen.getPanel());
        }

        public Guna2Panel getPanelGameScreen()
        {
            return panelGameScreen;
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
                    timer.Stop();
                    PauseButton.Image = Properties.Resources.pausebutton;
                    game.stopCount();
                }
                isPause = true;
            }
            else
            {
                foreach (Character c in game.getListTurnAction())
                {
                    c.startAnimation();
                    c.playSound();
                    timer.Start();
                    PauseButton.Image = Properties.Resources.pausebutton1;
                    //game.resumeCount();
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
        public Boolean GetIsMute()
        {
            return isMute;
        }
        public Guna2ImageButton getSoundButton()
        {
            return SoundButton;
        }
        //event menu 3 gạch -> show dialog
        
    }
}
