namespace _0505.NET基础班第二十一天
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
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlayOrPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInformation = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTurnDown = new System.Windows.Forms.Button();
            this.btnTurnUp = new System.Windows.Forms.Button();
            this.lblSongText = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDown = new System.Windows.Forms.ToolStripButton();
            this.pbPlayOrPause = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbUp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayOrPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).BeginInit();
            this.SuspendLayout();
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(2, 208);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(220, 46);
            this.musicPlayer.TabIndex = 0;
            // 
            // btnPlayOrPause
            // 
            this.btnPlayOrPause.Location = new System.Drawing.Point(240, 63);
            this.btnPlayOrPause.Name = "btnPlayOrPause";
            this.btnPlayOrPause.Size = new System.Drawing.Size(75, 23);
            this.btnPlayOrPause.TabIndex = 5;
            this.btnPlayOrPause.Text = "播放";
            this.btnPlayOrPause.UseVisualStyleBackColor = true;
            this.btnPlayOrPause.Click += new System.EventHandler(this.btnPlayOrPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(240, 92);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(346, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(137, 196);
            this.listBox1.TabIndex = 8;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(247, 247);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(41, 12);
            this.lblInformation.TabIndex = 11;
            this.lblInformation.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTurnDown
            // 
            this.btnTurnDown.Location = new System.Drawing.Point(189, 293);
            this.btnTurnDown.Name = "btnTurnDown";
            this.btnTurnDown.Size = new System.Drawing.Size(31, 23);
            this.btnTurnDown.TabIndex = 13;
            this.btnTurnDown.Text = "-";
            this.btnTurnDown.UseVisualStyleBackColor = true;
            this.btnTurnDown.Click += new System.EventHandler(this.btnTurnDown_Click);
            // 
            // btnTurnUp
            // 
            this.btnTurnUp.Location = new System.Drawing.Point(189, 257);
            this.btnTurnUp.Name = "btnTurnUp";
            this.btnTurnUp.Size = new System.Drawing.Size(31, 23);
            this.btnTurnUp.TabIndex = 12;
            this.btnTurnUp.Text = "+";
            this.btnTurnUp.UseVisualStyleBackColor = true;
            this.btnTurnUp.Click += new System.EventHandler(this.btnTurnUp_Click);
            // 
            // lblSongText
            // 
            this.lblSongText.AutoSize = true;
            this.lblSongText.Location = new System.Drawing.Point(344, 283);
            this.lblSongText.Name = "lblSongText";
            this.lblSongText.Size = new System.Drawing.Size(29, 12);
            this.lblSongText.TabIndex = 14;
            this.lblSongText.Text = "歌词";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 167);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen,
            this.编辑ToolStripMenuItem,
            this.播放方式ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 25);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmOpen
            // 
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(44, 21);
            this.tsmOpen.Text = "打开";
            this.tsmOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 播放方式ToolStripMenuItem
            // 
            this.播放方式ToolStripMenuItem.Name = "播放方式ToolStripMenuItem";
            this.播放方式ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.播放方式ToolStripMenuItem.Text = "播放方式";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnUp,
            this.toolStripBtnDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(660, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnUp
            // 
            this.toolStripBtnUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnUp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnUp.Image")));
            this.toolStripBtnUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUp.Name = "toolStripBtnUp";
            this.toolStripBtnUp.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnUp.Text = "toolStripButton1";
            this.toolStripBtnUp.Click += new System.EventHandler(this.toolStripBtnUp_Click);
            // 
            // toolStripBtnDown
            // 
            this.toolStripBtnDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnDown.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnDown.Image")));
            this.toolStripBtnDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDown.Name = "toolStripBtnDown";
            this.toolStripBtnDown.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnDown.Text = "toolStripButton2";
            this.toolStripBtnDown.Click += new System.EventHandler(this.toolStripBtnDown_Click);
            // 
            // pbPlayOrPause
            // 
            this.pbPlayOrPause.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayOrPause.Image")));
            this.pbPlayOrPause.Location = new System.Drawing.Point(71, 271);
            this.pbPlayOrPause.Name = "pbPlayOrPause";
            this.pbPlayOrPause.Size = new System.Drawing.Size(40, 34);
            this.pbPlayOrPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayOrPause.TabIndex = 18;
            this.pbPlayOrPause.TabStop = false;
            this.pbPlayOrPause.Click += new System.EventHandler(this.pbPlayOrPause_Click);
            // 
            // pbNext
            // 
            this.pbNext.Image = ((System.Drawing.Image)(resources.GetObject("pbNext.Image")));
            this.pbNext.Location = new System.Drawing.Point(129, 271);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(39, 34);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNext.TabIndex = 19;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // pbUp
            // 
            this.pbUp.Image = ((System.Drawing.Image)(resources.GetObject("pbUp.Image")));
            this.pbUp.Location = new System.Drawing.Point(12, 271);
            this.pbUp.Name = "pbUp";
            this.pbUp.Size = new System.Drawing.Size(42, 34);
            this.pbUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUp.TabIndex = 20;
            this.pbUp.TabStop = false;
            this.pbUp.Click += new System.EventHandler(this.pbUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 323);
            this.Controls.Add(this.pbUp);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbPlayOrPause);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblSongText);
            this.Controls.Add(this.btnTurnDown);
            this.Controls.Add(this.btnTurnUp);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlayOrPause);
            this.Controls.Add(this.musicPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "播放器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayOrPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private System.Windows.Forms.Button btnPlayOrPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTurnDown;
        private System.Windows.Forms.Button btnTurnUp;
        private System.Windows.Forms.Label lblSongText;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放方式ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnUp;
        private System.Windows.Forms.ToolStripButton toolStripBtnDown;
        private System.Windows.Forms.PictureBox pbPlayOrPause;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbUp;
    }
}

