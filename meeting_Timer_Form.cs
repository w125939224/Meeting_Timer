using System;
using System.Windows.Forms;

namespace Meeting_Timer
{
    public partial class MeetingTimerForm : Form
    {
        /// <summary>
        /// 初始化变量
        /// </summary>
        private string HH;
        private string MM;
        private string SS;
        private bool istiming = false;
        private bool isfirst = true;
        private System.Timers.Timer timer_One_second_interval = new System.Timers.Timer();
        private System.Timers.Timer timer_user_define_interval = new System.Timers.Timer();

        public MeetingTimerForm()
        {
            InitializeComponent();
            this.Opacity = 1;
        }
        /// <summary>
        /// 界面初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MeetingTimerForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            timer_user_define_interval.Interval = 1000;
            beginTimerButton.Show();
            recoverTimerButton.Hide();
            refreshTimerButton.Hide();
            pauseTimerButton.Hide();
            windowsMediaPlayer.Hide();
            istiming = false;
        }
        /// <summary>
        /// 点击开始计时按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void begin_Click(object sender, EventArgs e)
        {
            var meetingtimer = maskedTextBox.Text.Split(':');
            HH = meetingtimer[0];
            MM = meetingtimer[1];
            SS = meetingtimer[2];
            try
            {
                if (Convert.ToInt32(HH) == 0 && Convert.ToInt32(MM) == 0 && Convert.ToInt32(SS) == 0 && istiming == false)
                {
                    MessageBox.Show("请输入非00：00：00的时间");
                }
                else
                {
                    timer_One_second_interval.Interval = (3600 * Convert.ToInt32(HH) + 60 * Convert.ToInt32(MM) + Convert.ToInt32(SS)) * 1000;
                    istiming = true;
                    timer_One_second_interval.Start();
                    timer_user_define_interval.Start();
                    timer_One_second_interval.Enabled = false;
                    timer_One_second_interval.Enabled = false;
                    if (isfirst == true)
                    {
                        timer_user_define_interval.Elapsed += timer_user_define_interval_Elapsed;
                        isfirst = false;
                    }
                    else
                    {

                    }
                    beginTimerButton.Hide();
                    recoverTimerButton.Hide();
                    refreshTimerButton.Hide();
                    pauseTimerButton.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 用户定义的计时器时间到点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_user_define_interval_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            var meetingtimer = maskedTextBox.Text.Split(':');
            HH = meetingtimer[0];
            MM = meetingtimer[1];
            SS = meetingtimer[2];
            try
            {
                if (Convert.ToInt32(SS) < 60 && 10 < Convert.ToInt32(SS))
                {
                    SS = Convert.ToString(Convert.ToInt32(SS) - 1);
                    maskedTextBox.Text = Convert.ToString(HH + ":" + MM + ":" + Convert.ToString(SS));
                }
                else if (Convert.ToInt32(SS) > 0 && Convert.ToInt32(SS) <= 10)
                {
                    SS = Convert.ToString(Convert.ToInt32(SS) - 1);
                    maskedTextBox.Text = Convert.ToString(HH + ":" + MM + ":" + "0" + Convert.ToString(SS));
                }
                else if (Convert.ToInt32(SS) == 0 && Convert.ToInt32(MM) < 60 && 10 < Convert.ToInt32(MM))
                {
                    MM = Convert.ToString(Convert.ToInt32(MM) - 1);
                    maskedTextBox.Text = Convert.ToString(HH + ":" + Convert.ToString(MM) + ":" + "59");
                }
                else if (Convert.ToInt32(SS) == 0 && Convert.ToInt32(MM) > 0 && Convert.ToInt32(MM) <= 10)
                {
                    MM = Convert.ToString(Convert.ToInt32(MM) - 1);
                    maskedTextBox.Text = Convert.ToString(HH + ":" + "0" + Convert.ToString(MM) + ":" + "59");
                }
                else if (Convert.ToInt32(SS) == 0 && Convert.ToInt32(MM) == 0 && Convert.ToInt32(HH) < 60 && 10 < Convert.ToInt32(HH))
                {
                    HH = Convert.ToString(Convert.ToInt32(HH) - 1);
                    maskedTextBox.Text = Convert.ToString(Convert.ToString(HH) + ":" + "59" + ":" + "59");
                }
                else if (Convert.ToInt32(SS) == 0 && Convert.ToInt32(MM) == 0 && Convert.ToInt32(HH) > 0 && Convert.ToInt32(HH) <= 10)
                {
                    HH = Convert.ToString(Convert.ToInt32(HH) - 1);
                    maskedTextBox.Text = Convert.ToString("0" + Convert.ToString(HH) + ":" + "59" + ":" + "59");
                }
                else
                {
                    if (istiming == true)
                    {
                        timer_One_second_interval.Stop();
                        timer_user_define_interval.Stop();
                        timer_One_second_interval.Enabled = true;
                        timer_user_define_interval.Enabled = true;
                        beginTimerButton.Show();
                        recoverTimerButton.Hide();
                        pauseTimerButton.Hide();
                        refreshTimerButton.Hide();
                        istiming = false;
                        windowsMediaPlayer.URL = @"C:\Windows\Media\Alarm02.wav";
                        windowsMediaPlayer.Ctlcontrols.play();
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 点击暂停按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pause_Click(object sender, EventArgs e)
        {
            timer_One_second_interval.Stop();
            timer_user_define_interval.Stop();
            recoverTimerButton.Show();
            pauseTimerButton.Hide();
            refreshTimerButton.Show();
        }
        /// <summary>
        /// 点击恢复计时按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recoverTimer_Click(object sender, EventArgs e)
        {
            timer_One_second_interval.Start();
            timer_user_define_interval.Start();
            recoverTimerButton.Hide();
            refreshTimerButton.Hide();
            pauseTimerButton.Show();
        }
        /// <summary>
        /// 点击还原计时器按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recoveryTimerButton_Click(object sender, EventArgs e)
        {
            maskedTextBox.Text = "00:00:00";
            timer_One_second_interval.Enabled = true;
            timer_user_define_interval.Enabled = true;
            timer_One_second_interval.Stop();
            timer_user_define_interval.Stop();
            beginTimerButton.Show();
            recoverTimerButton.Hide();
            pauseTimerButton.Hide();
            refreshTimerButton.Hide();
            istiming = false;
        }
    }
}

namespace ExtensionMethods
{
    /// <summary>
    //添加一个命名空间，设置一个额外的方法，需要用到这个命名空间内的方法，需要添加引用
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// 给 System.Timers.Timer 增加一个扩展方法 Restart 用于重新开始重置计时间隔
        /// </summary>
        /// <param name="timer"></param>
        /// <param name="invertal">重置计时间隔的长度</param>
        public static void Restart(this System.Timers.Timer timer, int invertal = 0)
        {
            //重新开始
            timer.Stop();

            if (invertal > 0)
            {
                timer.Interval = invertal;
            }
            else
            {
                //set <- get
                timer.Interval = timer.Interval;//利用内部的change方法
            }
            //重新开始
            timer.Start();
        }
    }
}
