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
    public partial class CourseMsgFrm : Form
    {
        //string courseNumber;
        string courseName;
        string courseClass;
        string required;
        int credit;
        int prelectionCredit;
        int experimentCredit;
        public CourseMsgFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 下一步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            //如果课程名为空，则弹出对话框告知用户
            if (txtName.Text.Trim().Length==0)
            {
                MessageBox.Show("输入信息不完整!", "信息不完整",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                ShowCourseInformation();
                tabControl1.SelectedIndex = 1;//显示  确认信息  选项卡
                //创建链接对象
                string connString = @"Data Source=.;Initial Catalog=MySchool;Integrated Security=True";
                string sql = String.Format("insert into tab_Course(CourseName,CourseClass,Required,Credit,PrelectionCredit,ExperimentCredit) values('{0}','{1}','{2}','{3}','{4}','{5}')", courseName, courseClass, required, credit, prelectionCredit, experimentCredit);
                //
                using (SqlConnection conn=new SqlConnection(connString))
                {
                    conn.Open();
                    //创建Command对象
                    SqlCommand comm = new SqlCommand(sql,conn);
                    int n = comm.ExecuteNonQuery();
                    if (n>0)
                    {
                        MessageBox.Show("添加课程信息成功","添加成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("添加课程信息失败","添加失败",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }                
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedIndex == 1)
                {
                    if (txtName.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("输入信息不完整!", "信息不完整", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tabControl1.SelectedIndex = 0;//显示第一个选项卡
                    }
                }
                else
                {
                    ShowCourseInformation();
                    string message = String.Format("课程号:{0}\n课程名:{1}\n课程类别:{2}\n课程性质:{3}\n学分:{4}\n理论学时:{5}\n实验学时:{6}", courseName, courseClass, required, credit, prelectionCredit, experimentCredit);
                    rtbInfo.Text = message;
                }
            }
            catch { }
           
        }
        /// <summary>
        ///  
        /// </summary>
        private void ShowCourseInformation()
        {
            //courseNumber = cboNumber.SelectedItem.ToString();
            
            courseName = txtName.Text;
            courseClass = cboClass.SelectedItem.ToString();
            required = rdoRequired.Checked ? "必修" : "选修";
            credit = (int)nudCredit.Value;
            prelectionCredit = (int)nudPrelection.Value;
            experimentCredit = (int)nudExp.Value;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog()==DialogResult.OK)
            {
                rtbInfo.Font = fd.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog()==DialogResult.OK)
            {
                rtbInfo.ForeColor = cd.Color;
            }
        }
    }
}
