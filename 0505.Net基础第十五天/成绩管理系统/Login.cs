using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 成绩管理系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string userPwd = txtPwd.Text;
            if (userName=="admin"&&userPwd=="123456")
            {
                MessageBox.Show("欢迎进入成绩管理系统!", "登录成功", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                txtName.Clear();
                txtPwd.Clear();
                txtName.Focus();
                MessageBox.Show("您输入的用户名或密码错误,清重新输入","登录失败",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();//txtName.Text = ""; 
            txtPwd.Clear();//xtPwd.Text = "";
            txtName.Focus();
                
        }
    }
}
