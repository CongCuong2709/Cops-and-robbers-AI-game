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
        private const int MIN_VOLUME = 0;
        private const int MAX_VOLUME = 100;
        private Boolean isMute = false;


        public Setting(WaveOutEvent waveout, float volume)
        {
            InitializeComponent();
            waveOut = waveout;
            volSlider.Volume = volume;
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
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
    }
}
