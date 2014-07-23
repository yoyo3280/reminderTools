/********************************************************************************
** 作者：		yoyo
** 创始时间：	2012-3-17
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace reminderTools
{
    public partial class Form1 : Form
    {
        // 显示的图标 
        private Icon ico1 = Properties.Resources.Icon1;

        private Image image1 = Properties.Resources.Image1;

        private Image image2 = Properties.Resources.Image2;

        private Image image3 = Properties.Resources.Image3;

        private Image image4 = Properties.Resources.Image4;

        private Image image5 = Properties.Resources.Image5;

        private Image image6 = Properties.Resources.Image6;

        private Image image7 = Properties.Resources.Image7;

        private Image image8 = Properties.Resources.Image8;

        System.Timers.Timer t;

        // 刷新间隔
        int refreshTime = 1000;

        Boolean flg = false;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.TopMost = true;
            this.Icon = ico1;
            SetTimer();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.notifyIcon1.Icon = ico1;

            this.notifyIcon1.ContextMenuStrip = contextMenuStrip1;

        }

        protected override void WndProc(ref Message m)
        {

            const int WM_SYSCOMMAND = 0x0112;

            const int SC_CLOSE = 0xF060;

            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            { //捕捉关闭窗体消息       

                //   User   clicked   close   button       

                this.WindowState = FormWindowState.Minimized;

                return;

            }

            base.WndProc(ref    m);

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.notifyIcon1.Icon = ico1;

            this.Show();

            this.WindowState = FormWindowState.Normal;

            this.Activate();

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = false;

            this.Close();

            this.Dispose();

            Application.Exit();
        }

        private void SetTimer()
        {
            // 实例化Timer类
            t = new System.Timers.Timer();

            t.Elapsed += new System.Timers.ElapsedEventHandler(theout);

            t.SynchronizingObject = this;

            t.AutoReset = true;

            t.Interval = refreshTime;

            t.Enabled = true;
        }

        private void theout(object source, System.Timers.ElapsedEventArgs e)
        {
            if (!flg) 
            {
                string longTime = DateTime.Now.ToLongTimeString();

                if ("00".Equals(longTime.Split(':')[2]))
                {
                    refreshTime = 60000;

                    flg = true;

                    t.Interval = refreshTime;
                }
            }
            
            string time = DateTime.Now.ToShortTimeString();

            if ("9:00".Equals(time))
            {
                refreshTime = 60000;

                t.Interval = refreshTime;

                flg = true;

                this.Size = new Size(470, 255);

                tabControl1.Size = new Size(460, 220);

                pictureBox1.Image = image1;

                this.label13.Text = "每个醒后的早晨都是一件礼物，那个请打水去。。。";

                this.tabControl1.SelectedIndex = 1;

                this.Show();

                this.WindowState = FormWindowState.Normal;

                this.Activate();
            }
            else if ("10:00".Equals(time))
            {
                refreshTime = 60000;

                t.Interval = refreshTime;

                flg = true;

                this.Size = new Size(470, 255);

                tabControl1.Size = new Size(460, 220);

                pictureBox1.Image = image2;

                this.label13.Text = "喝杯水抖擞精神，开始下半场的工作。。。";

                this.tabControl1.SelectedIndex = 1;

                this.Show();

                this.WindowState = FormWindowState.Normal;

                this.Activate();
            }
            else if ("11:00".Equals(time))
            {
                refreshTime = 60000;

                t.Interval = refreshTime;

                flg = true;

                this.Size = new Size(470, 255);

                tabControl1.Size = new Size(460, 220);

                pictureBox1.Image = image3;

                this.label13.Text = "还在忙么，别忘了给自己一个微笑。。。";

                this.tabControl1.SelectedIndex = 1;

                this.Show();

                this.WindowState = FormWindowState.Normal;

                this.Activate();
            }
            else if ("11:40".Equals(time))
            {
                refreshTime = 60000;

                t.Interval = refreshTime;

                flg = true;

                this.Size = new Size(470, 255);

                tabControl1.Size = new Size(460, 220);

                pictureBox1.Image = image4;

                this.label13.Text = "工作再忙，午餐可不能少，午饭要好好吃哇..幸福是吃到饱。。。";

                this.tabControl1.SelectedIndex = 1;

                this.Show();

                this.WindowState = FormWindowState.Normal;

                this.Activate();
            }
            else if ("14:00".Equals(time))
            {
                refreshTime = 60000;

                t.Interval = refreshTime;

                flg = true;

                this.Size = new Size(470, 255);

                tabControl1.Size = new Size(460, 220);

                pictureBox1.Image = image5;

                this.label13.Text = "午后的小憩,偷得片刻惬意,换来百倍抖擞。。。";

                this.tabControl1.SelectedIndex = 1;

                this.Show();

                this.WindowState = FormWindowState.Normal;

                this.Activate();
            }
            else if ("15:00".Equals(time))
            {
                refreshTime = 60000;

                t.Interval = refreshTime;

                flg = true;

                this.Size = new Size(470, 255);

                tabControl1.Size = new Size(460, 220);

                pictureBox1.Image = image6;

                this.label13.Text = "今天运动了没？打字不算哦。。。";

                this.tabControl1.SelectedIndex = 1;

                this.Show();

                this.WindowState = FormWindowState.Normal;

                this.Activate();
            }
            else if ("16:00".Equals(time))
            {
                refreshTime = 60000;

                t.Interval = refreshTime;

                flg = true;

                this.Size = new Size(470, 255);

                tabControl1.Size = new Size(460, 220);

                pictureBox1.Image = image7;

                this.label13.Text = "下午好，累了就发发呆吧.停下来听首歌吧。。。";

                this.tabControl1.SelectedIndex = 1;

                this.Show();

                this.WindowState = FormWindowState.Normal;

                this.Activate();
            }
            else if ("17:00".Equals(time))
            {
                refreshTime = 60000;

                t.Interval = refreshTime;

                flg = true;

                this.Size = new Size(470, 435);

                tabControl1.Size = new Size(460, 400);
           
                pictureBox1.Image = image8;

                this.label13.Text = "";

                this.tabControl1.SelectedIndex = 1;

                this.Show();

                this.WindowState = FormWindowState.Normal;

                this.Activate();
            }
        }
    }
}
