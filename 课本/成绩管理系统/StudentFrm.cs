using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MySchool
{
    public partial class StudentFrm : Form
    {
        private int current = 1;
        string connString = @"Data Source=.;Initial Catalog=MySchool;Integrated Security=True";
        public StudentFrm()
        {
            InitializeComponent();
            current = 1;
            ShowCurrentStudent();//如果第一个学生存在,则显示
        }
        private void ShowCurrentStudent()
        {
            //sql语句
            string sql = String.Format("select *from tab_StudentMsg where StudentName='{0}'", current);
            using (SqlConnection conn=new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql,conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())                     //读取数据行
                {
                    txtName.Text = reader.GetString(1);//显示学生姓名
                    string sex = reader.GetString(2);
                    if (sex=="男")
                    {
                        rdoMale.Checked = true;
                    }
                    else
                    {
                        rdoFemale.Checked = true;
                    }
                    dtBirthday.Value = reader.GetDateTime(3);//显示学生出生年月
                    txtDept.Text = reader.GetString(4);
                    txtSpec.Text = reader.GetString(5);
                    string[] hobbies = new string[6];
                    hobbies = reader.GetString(6).Split('、');
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;
                    checkBox6.Checked = false;
                    foreach (string item in hobbies)
                    {
                        switch (item)
                        {
                            case "阅读":
                                checkBox1.Checked = true;
                                break;
                            case "体育":
                                checkBox2.Checked = true;
                                break;
                            case "音乐":
                                checkBox3.Checked = true;
                                break;
                            case "上网":
                                checkBox4.Checked = true;
                                break;
                            case "旅游":
                                checkBox5.Checked = true;
                                break;
                            default:
                                checkBox6.Checked = true;
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("前面或后面已经没有数据了","没有数据",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                reader.Close();
            }
        }
        /// <summary>
        /// 上一个
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            current--;
            ShowCurrentStudent();
        }
        /// <summary>
        /// 下一个
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            current++;
            ShowCurrentStudent();
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sex = null;
            if (rdoMale.Checked)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            string hobby = null;
            if (checkBox1.Checked) hobby += checkBox1.Text;
            if (checkBox2.Checked) hobby +="、"+checkBox2.Text;
            if (checkBox3.Checked) hobby += "、" + checkBox3.Text;
            if (checkBox4.Checked) hobby += "、" + checkBox4.Text;
            if (checkBox5.Checked) hobby += "、" + checkBox5.Text;
            if (checkBox6.Checked) hobby += "、" + checkBox6.Text;
            //sql语句
            string sql = String.Format("update _tabStudentMsg set StudentName='{0}',Sex='{1}',Birthday='{2}',Department='{3}',Speciality='{4}',Hobby='{5}' where StudentName='admin'", txtName.Text,sex,dtBirthday.Value,txtDept.Text,txtSpec.Text,hobby);
            string connString = @"Data Source=.;Initial Catalog=MySchool;Integrated Security=True";
            using (SqlConnection conn=new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql,conn);
                int n = comm.ExecuteNonQuery();
                if (n<=0)
                {
                    MessageBox.Show("数据更新操作失败,请检查数据格式!","操作数据库出错！",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = String.Format("delete from tab_StudentMsg where StudentName='{0}'",current);
            string connString = @"Data Source=.;Initial Catalog=MySchool;Integrated Security=True";
            using (SqlConnection conn=new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql,conn);
                int n = comm.ExecuteNonQuery();
                if (n<=0)
                {
                    MessageBox.Show("删除失败,请与管理员联系!","操作数据库出错!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else//删除当前记录后,刷新对话框以显示上一条记录
                {
                    current--;
                    ShowCurrentStudent();
                }
            }
        }
    }
}
