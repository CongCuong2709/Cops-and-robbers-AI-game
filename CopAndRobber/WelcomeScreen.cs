using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopAndRobber
{
	public partial class WelcomeScreen : Form
	{
        SupportMethod supportMethod = new SupportMethod();
        private Form activeForm = null;
        public static MainScreen mainScreen ;

        AudioFileReader audioFile = new AudioFileReader(Application.StartupPath + "/Assets/Sound/" + GuiUtils.BGM);
        // Tạo một đối tượng WaveOut để phát âm thanh
        public static WaveOutEvent waveOut = new WaveOutEvent();
        GameScreen gameScreen;

        public WelcomeScreen(MainScreen screen)
		{
			InitializeComponent();
            gameScreen = new GameScreen(waveOut, mainScreen);
            mainScreen = screen;
            playBGM();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {            
            supportMethod.openChildFormDockFill(this.activeForm, new GameScreen(waveOut, mainScreen), mainScreen.getPanel());
            
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            mainScreen.Close();
        }

        public void playBGM()
        {
            waveOut.Init(audioFile);
            waveOut.Play();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            supportMethod.openChildFormDockFill(this.activeForm, new Setting(waveOut, waveOut.Volume, gameScreen), mainScreen.getPanel());
        }
    }
}
