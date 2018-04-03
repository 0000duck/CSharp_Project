using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        /// <summary>
        /// 确定 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {

            #region
            string userName = txtName.Text;
            string userPwd = txtPwd.Text;
            //string connString = @"Data Source=.\sqlexpress;Initial Catalog=MySchool;Integrated Security=true";
            string connString = @"Data Source=.;Initial Catalog=MySchool;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            //获取用户名和密码匹配的行的数量的SQL语句
            string sql = String.Format("select count(*) from [tab_User] where UserName='{0}' and Password='{1}'", userName, userPwd);
            try
            {
                conn.Open();//打开数据路链接
                SqlCommand comm = new SqlCommand(sql, conn);//创建 Command对象
                int n = (int)comm.ExecuteScalar();//执行查询语句,返回匹配的行数
                if (n == 1)
                {
                    //this.DialogResult = DialogResult.OK;
                    this.Tag = true;
                    MessageBox.Show("登录成功", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("您输入的用户名或密码错误!请重新输入!", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtName.Focus();
                    txtName.Clear();
                    txtPwd.Clear();
                    this.Tag = false;//登陆失败并记录
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "操作数据库出错!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Tag = false;
            }
            finally
            {
                conn.Close();//关闭数据库链接
            }
            #endregion
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPwd.Clear();
            txtName.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
