namespace MySchool
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSysteMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStudentMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStuMsgMag = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCurMsgMag = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbStuMsgMag = new System.Windows.Forms.ToolStripButton();
            this.tsbNewCourse = new System.Windows.Forms.ToolStripButton();
            this.tsbCurMsgMag = new System.Windows.Forms.ToolStripButton();
            this.tsbScoreMsg = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSysteMsg,
            this.tsmStudentMsg,
            this.课程管理CToolStripMenuItem,
            this.tsmHelp,
            this.成绩管理AToolStripMenuItem,
            this.成绩管理0ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSysteMsg
            // 
            this.tsmSysteMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogin,
            this.tsmExit});
            this.tsmSysteMsg.Name = "tsmSysteMsg";
            this.tsmSysteMsg.Size = new System.Drawing.Size(83, 21);
            this.tsmSysteMsg.Text = "系统管理(S)";
            // 
            // tsmLogin
            // 
            this.tsmLogin.Name = "tsmLogin";
            this.tsmLogin.Size = new System.Drawing.Size(160, 22);
            this.tsmLogin.Text = "登录(&L)";
            this.tsmLogin.Click += new System.EventHandler(this.tsmLogin_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmExit.Size = new System.Drawing.Size(160, 22);
            this.tsmExit.Text = "退出(X)";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmStudentMsg
            // 
            this.tsmStudentMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewStudent,
            this.tsmStuMsgMag});
            this.tsmStudentMsg.Name = "tsmStudentMsg";
            this.tsmStudentMsg.Size = new System.Drawing.Size(92, 21);
            this.tsmStudentMsg.Text = " 学生管理(&M)";
            // 
            // tsmNewStudent
            // 
            this.tsmNewStudent.Name = "tsmNewStudent";
            this.tsmNewStudent.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmNewStudent.Size = new System.Drawing.Size(242, 22);
            this.tsmNewStudent.Text = "添加学生信息(A)";
            this.tsmNewStudent.Click += new System.EventHandler(this.tsmNewStudent_Click);
            // 
            // tsmStuMsgMag
            // 
            this.tsmStuMsgMag.Name = "tsmStuMsgMag";
            this.tsmStuMsgMag.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmStuMsgMag.Size = new System.Drawing.Size(242, 22);
            this.tsmStuMsgMag.Text = "学生信息管理(T)";
            this.tsmStuMsgMag.Click += new System.EventHandler(this.tsmStuMsgMag_Click);
            // 
            // 课程管理CToolStripMenuItem
            // 
            this.课程管理CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewCourse,
            this.tsmCurMsgMag});
            this.课程管理CToolStripMenuItem.Name = "课程管理CToolStripMenuItem";
            this.课程管理CToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.课程管理CToolStripMenuItem.Text = "课程管理(C)";
            // 
            // tsmNewCourse
            // 
            this.tsmNewCourse.Name = "tsmNewCourse";
            this.tsmNewCourse.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.tsmNewCourse.Size = new System.Drawing.Size(219, 22);
            this.tsmNewCourse.Text = "添加课程(A)";
            this.tsmNewCourse.Click += new System.EventHandler(this.tsmNewCourse_Click);
            // 
            // tsmCurMsgMag
            // 
            this.tsmCurMsgMag.Name = "tsmCurMsgMag";
            this.tsmCurMsgMag.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmCurMsgMag.Size = new System.Drawing.Size(219, 22);
            this.tsmCurMsgMag.Text = "课程信息管理(T)";
            this.tsmCurMsgMag.Click += new System.EventHandler(this.tsmCurMsgMag_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmHelp.Text = "帮助(H)";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.About.Size = new System.Drawing.Size(161, 22);
            this.About.Text = "关于(A)";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // 成绩管理AToolStripMenuItem
            // 
            this.成绩管理AToolStripMenuItem.Name = "成绩管理AToolStripMenuItem";
            this.成绩管理AToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.成绩管理AToolStripMenuItem.Text = "成绩管理(A)";
            // 
            // 成绩管理0ToolStripMenuItem
            // 
            this.成绩管理0ToolStripMenuItem.Name = "成绩管理0ToolStripMenuItem";
            this.成绩管理0ToolStripMenuItem.Size = new System.Drawing.Size(12, 21);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewStudent,
            this.tsbStuMsgMag,
            this.tsbNewCourse,
            this.tsbCurMsgMag,
            this.tsbScoreMsg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(768, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "常用命令";
            // 
            // tsbNewStudent
            // 
            this.tsbNewStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewStudent.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewStudent.Image")));
            this.tsbNewStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewStudent.Name = "tsbNewStudent";
            this.tsbNewStudent.Size = new System.Drawing.Size(28, 28);
            this.tsbNewStudent.Text = "添加学生信息";
            // 
            // tsbStuMsgMag
            // 
            this.tsbStuMsgMag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStuMsgMag.Image = ((System.Drawing.Image)(resources.GetObject("tsbStuMsgMag.Image")));
            this.tsbStuMsgMag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStuMsgMag.Name = "tsbStuMsgMag";
            this.tsbStuMsgMag.Size = new System.Drawing.Size(28, 28);
            this.tsbStuMsgMag.Text = "学生信息管理";
            // 
            // tsbNewCourse
            // 
            this.tsbNewCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewCourse.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewCourse.Image")));
            this.tsbNewCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewCourse.Name = "tsbNewCourse";
            this.tsbNewCourse.Size = new System.Drawing.Size(28, 28);
            this.tsbNewCourse.Text = "添加课程信息";
            // 
            // tsbCurMsgMag
            // 
            this.tsbCurMsgMag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCurMsgMag.Image = ((System.Drawing.Image)(resources.GetObject("tsbCurMsgMag.Image")));
            this.tsbCurMsgMag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCurMsgMag.Name = "tsbCurMsgMag";
            this.tsbCurMsgMag.Size = new System.Drawing.Size(28, 28);
            this.tsbCurMsgMag.Text = "课程信息管理";
            // 
            // tsbScoreMsg
            // 
            this.tsbScoreMsg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbScoreMsg.Image = ((System.Drawing.Image)(resources.GetObject("tsbScoreMsg.Image")));
            this.tsbScoreMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScoreMsg.Name = "tsbScoreMsg";
            this.tsbScoreMsg.Size = new System.Drawing.Size(28, 28);
            this.tsbScoreMsg.Text = "成绩管理";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(768, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Image = ((System.Drawing.Image)(resources.GetObject("tssStatus.Image")));
            this.tssStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(48, 17);
            this.tssStatus.Text = "就绪";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssMsg
            // 
            this.tssMsg.Name = "tssMsg";
            this.tssMsg.Size = new System.Drawing.Size(705, 17);
            this.tssMsg.Spring = true;
            this.tssMsg.Text = "请选择一个操作";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 477);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "学生成绩管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSysteMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmStudentMsg;
        private System.Windows.Forms.ToolStripMenuItem 课程管理CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmNewStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmStuMsgMag;
        private System.Windows.Forms.ToolStripMenuItem tsmNewCourse;
        private System.Windows.Forms.ToolStripMenuItem tsmCurMsgMag;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewStudent;
        private System.Windows.Forms.ToolStripButton tsbStuMsgMag;
        private System.Windows.Forms.ToolStripButton tsbNewCourse;
        private System.Windows.Forms.ToolStripButton tsbCurMsgMag;
        private System.Windows.Forms.ToolStripButton tsbScoreMsg;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssMsg;
        private System.Windows.Forms.ToolStripMenuItem tsmLogin;
    }
}