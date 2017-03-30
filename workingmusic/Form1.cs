using System;
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
            workingflag = true;
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
        public static bool workingflag = false;
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
            workingflag = false;
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
            workingflag = false;
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (workingflag == true)
            {
                //窗体关闭原因为单击"关闭"按钮或Alt+F4
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;           //取消关闭操作 表现为不关闭窗体
                    notifyIcon1.Visible = true;   //设置图标可见
                    this.Hide();               //隐藏窗体
                    MessageBox.Show("WM已被你打入冷宫", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //点击"是(YES)"退出程序
                if (MessageBox.Show("确定要离开?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    notifyIcon1.Visible = false;   //设置图标不可见
                    this.Dispose();                //释放资源
                    Application.Exit();            //关闭应用程序窗体
                }
                else
                {
                    e.Cancel = true;           //取消关闭操作 表现为不关闭窗体
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //双击鼠标"左键"发生
            if (e.Button == MouseButtons.Left)
            {
                this.Visible = true;                        //窗体可见
                this.WindowState = FormWindowState.Normal;  //窗体默认大小
                this.notifyIcon1.Visible = true;            //设置图标可见
            }
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();                                //窗体显示
            this.WindowState = FormWindowState.Normal;  //窗体状态默认大小
            this.Activate();                            //激活窗体给予焦点
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //点击"是(YES)"退出程序
            if (MessageBox.Show("确定要离开?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                notifyIcon1.Visible = false;   //设置图标不可见
                this.Dispose();                //释放资源
                Application.Exit();            //关闭应用程序窗体
            }
        }

        private void 暂停ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Play_Hide();
            button1.Show();
            display();
            workingflag = false;
            this.Show();                                //窗体显示
            this.WindowState = FormWindowState.Normal;  //窗体状态默认大小
            this.Activate();                            //激活窗体给予焦点
        }
    }
    public static class Define
    {
        public static string MisPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"music\";

    }
}
