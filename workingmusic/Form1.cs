using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workingmusic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            work_show();
            button1.Hide();
            play();
        }
        public void play()
        {
            fire.Ctlcontrols.play();
            people.Ctlcontrols.play();
            rain.Ctlcontrols.play();
            thunder.Ctlcontrols.play();

        }
        public void display()
        {
            fire.Ctlcontrols.stop();
            people.Ctlcontrols.stop();
            rain.Ctlcontrols.stop();
            thunder.Ctlcontrols.stop();

        }
        public void init()
        {
            fire.URL = Define.MisPath + "fire.mp4";
            people.URL = Define.MisPath + "people.mp4";
            rain.URL = Define.MisPath + "rain.mp4";
            thunder.URL = Define.MisPath + "thunder.mp4";
            fire.settings.setMode("loop", true);
            people.settings.setMode("loop", true);
            rain.settings.setMode("loop", true);
            thunder.settings.setMode("loop", true);
        }
        
        public void work_show()
        {
            trackBar1.Show();
            trackBar2.Show();
            trackBar3.Show();
            trackBar4.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            button2.Show();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            thunder.settings.volume = trackBar3.Value;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            fire.settings.volume = trackBar1.Value;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            rain.settings.volume = trackBar4.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            people.settings.volume = trackBar2.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Play_Hide();
            button1.Show();
            display();
        }

        public void Play_Hide()
        {
            trackBar1.Hide();
            trackBar2.Hide();
            trackBar3.Hide();
            trackBar4.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            button2.Hide();
        }
    }
    public static class Define
    {
        public static string MisPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"music\";

    }
}
