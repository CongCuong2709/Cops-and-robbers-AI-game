using Guna.UI2.WinForms;
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
using static CopAndRobber.GuiUtils;

namespace CopAndRobber
{
    public partial class endGame : Form
    {
        SupportMethod supportMethod = new SupportMethod();
        MainScreen mainScreen;
        
        public static WaveOutEvent waveOut ;      

        public endGame(MainScreen main, WaveOutEvent wave)
        {
            InitializeComponent();
            mainScreen = main;
            waveOut = wave;
        }
        public endGame()
        {
            InitializeComponent();
        }
        public endGame(ActionBar actionBar)
        {
            InitializeComponent();
        }
       

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            waveOut.Stop();
            supportMethod.AddChildFormDockFill(new WelcomeScreen(mainScreen), mainScreen.getPanel());
            this.Close();
            this.Dispose();

        }

        private void buttonReplay_Click(object sender, EventArgs e)
        {
            supportMethod.AddChildFormDockFill(new GameScreen(waveOut, mainScreen), mainScreen.getPanel());
            //waveOut.Play();
        }
    }
}
