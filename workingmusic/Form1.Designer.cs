namespace workingmusic
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.people = new AxWMPLib.AxWindowsMediaPlayer();
            this.rain = new AxWMPLib.AxWindowsMediaPlayer();
            this.thunder = new AxWMPLib.AxWindowsMediaPlayer();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fire = new AxWMPLib.AxWindowsMediaPlayer();
            this.button2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelTimerConfig = new System.Windows.Forms.Panel();
            this.radioCountdown = new System.Windows.Forms.RadioButton();
            this.radioStopwatch = new System.Windows.Forms.RadioButton();
            this.labelDuration = new System.Windows.Forms.Label();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn45 = new System.Windows.Forms.Button();
            this.btn60 = new System.Windows.Forms.Button();
            this.btn90 = new System.Windows.Forms.Button();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panelTimerConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.people)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thunder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button1.Location = new System.Drawing.Point(205, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(12, 75);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // people
            // 
            this.people.Enabled = true;
            this.people.Location = new System.Drawing.Point(200, 232);
            this.people.Name = "people";
            this.people.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("people.OcxState")));
            this.people.Size = new System.Drawing.Size(53, 42);
            this.people.TabIndex = 3;
            this.people.Visible = false;
            // 
            // rain
            // 
            this.rain.Enabled = true;
            this.rain.Location = new System.Drawing.Point(259, 232);
            this.rain.Name = "rain";
            this.rain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rain.OcxState")));
            this.rain.Size = new System.Drawing.Size(59, 41);
            this.rain.TabIndex = 4;
            this.rain.Visible = false;
            // 
            // thunder
            // 
            this.thunder.Enabled = true;
            this.thunder.Location = new System.Drawing.Point(374, 177);
            this.thunder.Name = "thunder";
            this.thunder.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("thunder.OcxState")));
            this.thunder.Size = new System.Drawing.Size(98, 97);
            this.thunder.TabIndex = 5;
            this.thunder.Visible = false;
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(127, 75);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 7;
            this.trackBar2.Visible = false;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.LargeChange = 1;
            this.trackBar3.Location = new System.Drawing.Point(347, 75);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 8;
            this.trackBar3.Visible = false;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.LargeChange = 1;
            this.trackBar4.Location = new System.Drawing.Point(237, 75);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(104, 45);
            this.trackBar4.TabIndex = 9;
            this.trackBar4.Visible = false;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "fire";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(161, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "people";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label3.Location = new System.Drawing.Point(268, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "rain";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(381, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "thunder";
            this.label4.Visible = false;
            // 
            // fire
            // 
            this.fire.Enabled = true;
            this.fire.Location = new System.Drawing.Point(7, 177);
            this.fire.Name = "fire";
            this.fire.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("fire.OcxState")));
            this.fire.Size = new System.Drawing.Size(123, 95);
            this.fire.TabIndex = 14;
            this.fire.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "结束";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Workingmusic";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.暂停ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            this.contextMenuStrip1.Text = "workingmusic";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.暂停ToolStripMenuItem.Text = "暂停";
            this.暂停ToolStripMenuItem.Click += new System.EventHandler(this.暂停ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 6;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 6;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            //
            // labelTimer
            //
            this.labelTimer.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.labelTimer.Location = new System.Drawing.Point(0, 2);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(484, 42);
            this.labelTimer.TabIndex = 31;
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTimer.Visible = false;
            //
            // panelTimerConfig
            //
            this.panelTimerConfig.Controls.Add(this.labelNote);
            this.panelTimerConfig.Controls.Add(this.labelMin);
            this.panelTimerConfig.Controls.Add(this.numMinutes);
            this.panelTimerConfig.Controls.Add(this.btn90);
            this.panelTimerConfig.Controls.Add(this.btn60);
            this.panelTimerConfig.Controls.Add(this.btn45);
            this.panelTimerConfig.Controls.Add(this.btn25);
            this.panelTimerConfig.Controls.Add(this.labelDuration);
            this.panelTimerConfig.Controls.Add(this.radioStopwatch);
            this.panelTimerConfig.Controls.Add(this.radioCountdown);
            this.panelTimerConfig.Location = new System.Drawing.Point(0, 26);
            this.panelTimerConfig.Name = "panelTimerConfig";
            this.panelTimerConfig.Size = new System.Drawing.Size(484, 136);
            this.panelTimerConfig.TabIndex = 30;
            //
            // radioCountdown
            //
            this.radioCountdown.Checked = true;
            this.radioCountdown.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.radioCountdown.Location = new System.Drawing.Point(40, 4);
            this.radioCountdown.Name = "radioCountdown";
            this.radioCountdown.Size = new System.Drawing.Size(90, 24);
            this.radioCountdown.TabIndex = 16;
            this.radioCountdown.TabStop = true;
            this.radioCountdown.Text = "倒计时";
            this.radioCountdown.UseVisualStyleBackColor = true;
            this.radioCountdown.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            //
            // radioStopwatch
            //
            this.radioStopwatch.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.radioStopwatch.Location = new System.Drawing.Point(150, 4);
            this.radioStopwatch.Name = "radioStopwatch";
            this.radioStopwatch.Size = new System.Drawing.Size(120, 24);
            this.radioStopwatch.TabIndex = 17;
            this.radioStopwatch.TabStop = true;
            this.radioStopwatch.Text = "正向计时";
            this.radioStopwatch.UseVisualStyleBackColor = true;
            this.radioStopwatch.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            //
            // labelDuration
            //
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelDuration.Location = new System.Drawing.Point(40, 40);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(38, 17);
            this.labelDuration.TabIndex = 18;
            this.labelDuration.Text = "时长：";
            //
            // btn25
            //
            this.btn25.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn25.Location = new System.Drawing.Point(86, 34);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(48, 27);
            this.btn25.TabIndex = 19;
            this.btn25.Tag = 25;
            this.btn25.Text = "25";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.presetButton_Click);
            //
            // btn45
            //
            this.btn45.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn45.Location = new System.Drawing.Point(138, 34);
            this.btn45.Name = "btn45";
            this.btn45.Size = new System.Drawing.Size(48, 27);
            this.btn45.TabIndex = 20;
            this.btn45.Tag = 45;
            this.btn45.Text = "45";
            this.btn45.UseVisualStyleBackColor = true;
            this.btn45.Click += new System.EventHandler(this.presetButton_Click);
            //
            // btn60
            //
            this.btn60.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn60.Location = new System.Drawing.Point(190, 34);
            this.btn60.Name = "btn60";
            this.btn60.Size = new System.Drawing.Size(48, 27);
            this.btn60.TabIndex = 21;
            this.btn60.Tag = 60;
            this.btn60.Text = "60";
            this.btn60.UseVisualStyleBackColor = true;
            this.btn60.Click += new System.EventHandler(this.presetButton_Click);
            //
            // btn90
            //
            this.btn90.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn90.Location = new System.Drawing.Point(242, 34);
            this.btn90.Name = "btn90";
            this.btn90.Size = new System.Drawing.Size(48, 27);
            this.btn90.TabIndex = 22;
            this.btn90.Tag = 90;
            this.btn90.Text = "90";
            this.btn90.UseVisualStyleBackColor = true;
            this.btn90.Click += new System.EventHandler(this.presetButton_Click);
            //
            // numMinutes
            //
            this.numMinutes.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.numMinutes.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinutes.Location = new System.Drawing.Point(310, 36);
            this.numMinutes.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(64, 23);
            this.numMinutes.TabIndex = 23;
            this.numMinutes.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            //
            // labelMin
            //
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.labelMin.Location = new System.Drawing.Point(378, 40);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(38, 17);
            this.labelMin.TabIndex = 24;
            this.labelMin.Text = "分钟";
            //
            // labelNote
            //
            this.labelNote.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNote.ForeColor = System.Drawing.Color.Gray;
            this.labelNote.Location = new System.Drawing.Point(40, 74);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(420, 22);
            this.labelNote.TabIndex = 25;
            this.labelNote.Text = "点「开始」开启倒计时，归零自动停止白噪音";
            //
            // timer3
            //
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            //
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 270);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.thunder);
            this.Controls.Add(this.rain);
            this.Controls.Add(this.people);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelTimerConfig);
            this.Controls.Add(this.labelTimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workingmusic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.people)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thunder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            this.panelTimerConfig.ResumeLayout(false);
            this.panelTimerConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private AxWMPLib.AxWindowsMediaPlayer people;
        private AxWMPLib.AxWindowsMediaPlayer rain;
        private AxWMPLib.AxWindowsMediaPlayer thunder;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private AxWMPLib.AxWindowsMediaPlayer fire;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelTimerConfig;
        private System.Windows.Forms.RadioButton radioCountdown;
        private System.Windows.Forms.RadioButton radioStopwatch;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btn60;
        private System.Windows.Forms.Button btn90;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timer3;
    }
}

