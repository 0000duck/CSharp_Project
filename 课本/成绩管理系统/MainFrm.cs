using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 成绩管理系统;

namespace MySchool
{
    public partial class MainFrm : Form
    {
        //bool型的字段 记录用户是否登录成功
        private bool isLogined = true;//记录登录凭证
        public MainFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//关闭所有应用程序窗体
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.MdiParent = this;
            about.Show();
            tssMsg.Text = about.Text;
        }
        
        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmNewStudent_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                StudentMsgFrm sForm = new StudentMsgFrm();//创建子窗体对象
                sForm.MdiParent = this;//指定当前窗体为MDI窗体
                sForm.Show();
                
                tssMsg.Text = sForm.Text;
            }
            else
            {
                tssMsg.Text = "注意必须先登陆才能使用本系统！";
            }
        }
        /// <summary>
        /// 添加课程信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmNewCourse_Click(object sender, EventArgs e)
        {
            CourseMsgFrm cForm = new CourseMsgFrm();
            cForm.MdiParent = this;
            cForm.Show();
            tssMsg.Text = cForm.Text;//在状态中显示操作的内容
        }
        /// <summary>
        /// 课程信息管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmCurMsgMag_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                CourseFrm cForm = new CourseFrm();
                cForm.MdiParent = this;
                cForm.Show();
                tssMsg.Text = cForm.Text;
            }
            else
            {
                tssMsg.Text = "注意必须先登录才能使用本系统!";
            }
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmLogin_Click(object sender, EventArgs e)
        {
            Login lf = new Login();

            //lf.Show();
            tssMsg.Text = lf.Text;
            //显示用户登录窗体,并检测用户是否点击过登录按钮
            if (lf.ShowDialog() == DialogResult.OK)
            {
                if ((bool)lf.Tag)//如果登陆成功
                {
                    isLogined = true;
                    tssMsg.Text = "恭喜你,登陆成功！";
                }
                else
                {
                    isLogined = false;
                    tssMsg.Text = "注意必须先登陆才能实用本系统！";
                }

            }
        }
        /// <summary>
        /// 学生信息管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmStuMsgMag_Click(object sender, EventArgs e)
        {
            if (isLogined)
            {
                StudentFrm sForm = new StudentFrm();
                sForm.MdiParent = this;
                sForm.Show();
                tssMsg.Text = sForm.Text;
            }
            else
            {
                tssMsg.Text = "注意,必须先登录才能使用本系统!";
            }
        }
    }
}
