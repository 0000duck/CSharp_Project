using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _07老师或是学生登录
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rdoStudent.Checked||rdoTeacher.Checked)
            {
                string name = txtName.Text.Trim();
                string pwd = txtPwd.Text;
                if (rdoStudent.Checked)
                {
                    if (name == "stu" && pwd == "stu")
                    {
                        MessageBox.Show("学生登录成功");
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误，请重新输入");
                        txtName.Clear();
                        txtPwd.Clear();
                        txtName.Focus();
                    }
                }
                else//选择的是老师
                {
                    if (name == "teacher" && pwd == "teacher")
                    {
                        MessageBox.Show("老师登录成功");
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误,清重新输入");
                        txtName.Clear();
                        txtPwd.Clear();
                        txtName.Focus();
                    }
                }
            }
            else//什么都没选
            {
                MessageBox.Show("请首先选择登录身份");
            }
        }
    }
}
