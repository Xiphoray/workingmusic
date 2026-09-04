using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;

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
            BeginTiming();       // 依所选模式启动计时
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
            thunder.settings.volume = trackBar3.Value;
            rain.settings.volume = trackBar4.Value;
            fire.settings.volume = trackBar1.Value;
            people.settings.volume = trackBar2.Value;


        }
        public void display()
        {
            fire.Ctlcontrols.stop();
            people.Ctlcontrols.stop();
            rain.Ctlcontrols.stop();
            thunder.Ctlcontrols.stop();

        }
        public static bool workingflag = false;

        // ---- 计时相关状态 ----
        private bool stopwatchMode;          // true=正向计时；false=倒计时
        private DateTime sessionStart;       // 正向计时：本次会话起点
        private DateTime countdownEnd;       // 倒计时：目标结束时刻

        // 依据当前选择的模式启动计时，隐藏配置面板、显示大时钟
        private void BeginTiming()
        {
            stopwatchMode = radioStopwatch.Checked;
            panelTimerConfig.Hide();
            labelTimer.Show();
            if (stopwatchMode)
            {
                sessionStart = DateTime.Now;          // 正向计时：从 0 累计
                labelTimer.Text = "00:00";
            }
            else
            {
                countdownEnd = DateTime.Now.AddMinutes((double)numMinutes.Value); // 倒计时：算好目标时刻，避免节拍器累计漂移
                labelTimer.Text = FormatSeconds((int)numMinutes.Value * 60);
            }
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (stopwatchMode)
            {
                int sec = (int)(DateTime.Now - sessionStart).TotalSeconds;
                labelTimer.Text = FormatSeconds(sec);
            }
            else
            {
                int remain = (int)Math.Ceiling((countdownEnd - DateTime.Now).TotalSeconds);
                if (remain <= 0)
                {
                    timer3.Stop();
                    labelTimer.Text = "00:00";
                    CountdownFinished();
                    return;
                }
                labelTimer.Text = FormatSeconds(remain);
            }
        }

        // 倒计时归零：响铃提醒 + 声音自动淡出停止（复用现有淡出逻辑）
        private void CountdownFinished()
        {
            System.Media.SystemSounds.Asterisk.Play();
            StartFade();
            MessageBox.Show("时间到啦！白噪音已经自动停止。" + Environment.NewLine +
                "选好模式与时长，再点「开始」再来一轮吧。",
                "倒计时结束", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 计时会话结束/复位：停表、隐藏时钟、回到模式选择面板
        private void ResetTimerUI()
        {
            timer3.Stop();
            labelTimer.Hide();
            labelTimer.Text = "";
            panelTimerConfig.Show();
        }

        // 声音淡出启动（「结束」/托盘「暂停」/倒计时归零共用）
        private void StartFade()
        {
            if (fire.settings.volume > 20 || rain.settings.volume > 20 ||
                people.settings.volume > 20 || thunder.settings.volume > 20)
            {
                timer1.Interval = 3;
            }
            else
            {
                timer1.Interval = 50;
            }
            timer1.Start();
        }

        private static string FormatSeconds(int s)
        {
            if (s >= 3600)
            {
                return string.Format("{0}:{1:00}:{2:00}", s / 3600, (s % 3600) / 60, s % 60);
            }
            return string.Format("{0:00}:{1:00}", s / 60, s % 60);
        }

        // 模式切换：只有倒计时模式才需要显示时长预设与自定义输入
        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            bool countdown = radioCountdown.Checked;
            labelDuration.Visible = countdown;
            btn25.Visible = countdown;
            btn45.Visible = countdown;
            btn60.Visible = countdown;
            btn90.Visible = countdown;
            numMinutes.Visible = countdown;
            labelMin.Visible = countdown;
            labelNote.Text = countdown
                ? "选好时长后点「开始」开启倒计时，归零自动停止白噪音"
                : "点「开始」开启正向计时，需要结束时点「结束」";
        }

        // 预设时长按钮：把分钟数写入自定义输入框
        private void presetButton_Click(object sender, EventArgs e)
        {
            numMinutes.Value = Convert.ToInt32(((Button)sender).Tag);
        }

        public void init()
        {
            fire.URL = Define.MisPath + "fire.mp4";
            people.URL = Define.MisPath + "people.mp4";
            rain.URL = Define.MisPath + "rain.mp4";
            thunder.URL = Define.MisPath + "thunder.mp4";
            if (Directory.Exists(Define.DataPath) == false)
            {
                Directory.CreateDirectory(Define.DataPath);
            }
            if (!File.Exists(Define.Datafile))
            {
                File.WriteAllText(Define.Datafile, "<fire10> <people0> <rain0> <thunder0>");
            }
            string dataStr = "";
            StreamReader reader = new StreamReader(Define.Datafile, Encoding.Default);
            while (!reader.EndOfStream)
            {
                dataStr += reader.ReadLine();
            }
            reader.Close();
            string fireStr = "<fire(?<fire>\\d+)> <people(?<people>\\d+)> <rain(?<rain>\\d+)> <thunder(?<thunder>\\d+)>";
            Match TitleMatch = Regex.Match(dataStr, fireStr, RegexOptions.IgnoreCase);

            int fires = int.Parse(TitleMatch.Groups["fire"].Value), 
                peos = int.Parse(TitleMatch.Groups["people"].Value),
                rais = int.Parse(TitleMatch.Groups["rain"].Value),
                thus = int.Parse(TitleMatch.Groups["thunder"].Value);

            fire.settings.setMode("loop", true);
            people.settings.setMode("loop", true);
            rain.settings.setMode("loop", true);
            thunder.settings.setMode("loop", true);
            fire.settings.volume = trackBar1.Value = fires;
            people.settings.volume = trackBar2.Value = peos;
            rain.settings.volume = trackBar4.Value = rais;
            thunder.settings.volume = trackBar3.Value = thus;
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
            StartFade();
        }

        public void savedata()
        {
            
            StreamWriter writer = new StreamWriter(Define.Datafile, false, Encoding.Default);
            writer.WriteLine("<fire{0}> <people{1}> <rain{2}> <thunder{3}>", trackBar1.Value, trackBar2.Value, trackBar4.Value, trackBar3.Value);
            writer.Close();
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
                    savedata();
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
                savedata();
                if (fire.settings.volume > 20 || rain.settings.volume > 20 || people.settings.volume > 20 || thunder.settings.volume > 20)
                {
                    timer2.Interval = 3;
                }
                else
                {
                    timer2.Interval = 50;
                }
                timer2.Start();
            }
        }

        private void 暂停ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartFade();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fire.settings.volume != 0)
            {
                fire.settings.volume--;
            }
            if (rain.settings.volume != 0)
            {
                rain.settings.volume--;
            }
            if (people.settings.volume != 0)
            {
                people.settings.volume--;
            }
            if (thunder.settings.volume != 0)
            {
                thunder.settings.volume--;
            }
            if(fire.settings.volume == 0 && rain.settings.volume == 0 && people.settings.volume == 0 && thunder.settings.volume == 0)
            {
                timer1.Stop();
                Play_Hide();
                button1.Show();
                workingflag = false;
                display();
                ResetTimerUI();                         //计时会话结束：回到模式选择面板
                this.Show();                                //窗体显示
                this.WindowState = FormWindowState.Normal;  //窗体状态默认大小
                this.Activate();                            //激活窗体给予焦点
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (fire.settings.volume != 0)
            {
                fire.settings.volume--;
            }
            if (rain.settings.volume != 0)
            {
                rain.settings.volume--;
            }
            if (people.settings.volume != 0)
            {
                people.settings.volume--;
            }
            if (thunder.settings.volume != 0)
            {
                thunder.settings.volume--;
            }
            if (fire.settings.volume == 0 && rain.settings.volume == 0 && people.settings.volume == 0 && thunder.settings.volume == 0)
            {
                timer2.Stop();
                notifyIcon1.Visible = false;   //设置图标不可见
                this.Dispose();                //释放资源
                Application.Exit();            //关闭应用程序窗体
            }
        }
    }
    public static class Define
    {
        public static string MisPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"music\";
        public static string DataPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"data"; 
        public static string Datafile = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"data\data.txt";
    }
}
