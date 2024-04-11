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
        MainScreen mainScreen = null;

        AudioFileReader audioFile = new AudioFileReader(GuiUtils.BGM);
        // Tạo một đối tượng WaveOut để phát âm thanh
        WaveOutEvent waveOut = new WaveOutEvent();

        public WelcomeScreen(MainScreen screen)
		{
			InitializeComponent();
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
            supportMethod.openChildFormDockFill(this.activeForm, new Setting(waveOut, waveOut.Volume), mainScreen.getPanel());
        }
    }
}
