using NAudio.Gui;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopAndRobber
{
    public partial class Setting : Form       
    {
        WaveOutEvent waveOut;        
        private Boolean isMute = false;
        GameScreen gamescreen;
        private Form activeForm = null;
        SupportMethod supportMethod = new SupportMethod();
        public Setting(WaveOutEvent waveout, float volume, GameScreen gameScreen)
        {
            InitializeComponent();
            waveOut = waveout;
            volSlider.Volume = volume;
            gamescreen = gameScreen;



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (gamescreen.getGameLogic().getListTurnAction().Any())
                {
                    foreach (Character c in gamescreen.getGameLogic().getListTurnAction())
                    {
                        c.startAnimation();
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                // Xử lý lỗi ở đây
                Console.WriteLine("Đã xảy ra lỗi NullReferenceException: " + ex.Message);
            }
            this.Close();
        }

        private void volSlider_VolumeChanged(object sender, EventArgs e)
        {
            float volume = volSlider.Volume;
            waveOut.Volume = volume;
        }

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

        private void buttonReset_Click(object sender, EventArgs e)
        {           
            MainScreen mainScreen = gamescreen.GetMainScreen();
            gamescreen.Close();
            gamescreen = new GameScreen(waveOut, mainScreen);
            supportMethod.openChildFormDockFill(this.activeForm, new GameScreen(waveOut, mainScreen), mainScreen.getPanel());
            this.Close();
            this.Dispose();
        }
    }
}
