
namespace Meeting_Timer
{
    partial class MeetingTimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetingTimerForm));
            this.beginTimerButton = new System.Windows.Forms.Button();
            this.pauseTimerButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.refreshTimerButton = new System.Windows.Forms.Button();
            this.recoverTimerButton = new System.Windows.Forms.Button();
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // beginTimerButton
            // 
            this.beginTimerButton.Location = new System.Drawing.Point(12, 36);
            this.beginTimerButton.Name = "beginTimerButton";
            this.beginTimerButton.Size = new System.Drawing.Size(75, 23);
            this.beginTimerButton.TabIndex = 0;
            this.beginTimerButton.Text = "开始计时";
            this.beginTimerButton.UseVisualStyleBackColor = true;
            this.beginTimerButton.Click += new System.EventHandler(this.begin_Click);
            // 
            // pauseTimerButton
            // 
            this.pauseTimerButton.Location = new System.Drawing.Point(175, 36);
            this.pauseTimerButton.Name = "pauseTimerButton";
            this.pauseTimerButton.Size = new System.Drawing.Size(75, 23);
            this.pauseTimerButton.TabIndex = 1;
            this.pauseTimerButton.Text = "暂停";
            this.pauseTimerButton.UseVisualStyleBackColor = true;
            this.pauseTimerButton.Click += new System.EventHandler(this.pause_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(10, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(209, 12);
            this.label.TabIndex = 2;
            this.label.Text = "请在此处输入会议时间，格式HH:MM:SS";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox.Location = new System.Drawing.Point(0, 0);
            this.maskedTextBox.Mask = "00:00:00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(262, 21);
            this.maskedTextBox.TabIndex = 3;
            this.maskedTextBox.Text = "000000";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.refreshTimerButton);
            this.splitContainer.Panel1.Controls.Add(this.pauseTimerButton);
            this.splitContainer.Panel1.Controls.Add(this.recoverTimerButton);
            this.splitContainer.Panel1.Controls.Add(this.beginTimerButton);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.windowsMediaPlayer);
            this.splitContainer.Panel2.Controls.Add(this.maskedTextBox);
            this.splitContainer.Size = new System.Drawing.Size(262, 158);
            this.splitContainer.SplitterDistance = 74;
            this.splitContainer.TabIndex = 5;
            // 
            // refreshTimerButton
            // 
            this.refreshTimerButton.Location = new System.Drawing.Point(94, 36);
            this.refreshTimerButton.Name = "refreshTimerButton";
            this.refreshTimerButton.Size = new System.Drawing.Size(75, 23);
            this.refreshTimerButton.TabIndex = 3;
            this.refreshTimerButton.Text = "还原计时器";
            this.refreshTimerButton.UseVisualStyleBackColor = true;
            this.refreshTimerButton.Click += new System.EventHandler(this.recoveryTimerButton_Click);
            // 
            // recoverTimerButton
            // 
            this.recoverTimerButton.Location = new System.Drawing.Point(13, 36);
            this.recoverTimerButton.Name = "recoverTimerButton";
            this.recoverTimerButton.Size = new System.Drawing.Size(75, 23);
            this.recoverTimerButton.TabIndex = 2;
            this.recoverTimerButton.Text = "恢复计时";
            this.recoverTimerButton.UseVisualStyleBackColor = true;
            this.recoverTimerButton.Click += new System.EventHandler(this.recoverTimer_Click);
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(0, 37);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(262, 43);
            this.windowsMediaPlayer.TabIndex = 4;
            // 
            // MeetingTimerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(262, 158);
            this.Controls.Add(this.label);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MeetingTimerForm";
            this.Text = "Meeting_Timer";
            this.Load += new System.EventHandler(this.MeetingTimerForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beginTimerButton;
        private System.Windows.Forms.Button pauseTimerButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button recoverTimerButton;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.Button refreshTimerButton;
    }
}

