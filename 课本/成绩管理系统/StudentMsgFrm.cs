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
    public partial class StudentMsgFrm : Form
    {
        public StudentMsgFrm()
        {
            InitializeComponent();
        }

        private void StudentMsgFrm_Load(object sender, EventArgs e)
        {
            rdoMale.Checked = true;//默认为男生
            cboDept.SelectedIndex = 0;
            dtBirthday.MaxDate = DateTime.Now;
            dtBirthday.Value = dtBirthday.MaxDate;//设置出生日期默认值为最小值
            timeGo.Enabled = true;//启动计时器            
        }
        /// <summary>
        /// 根据组合框中选择的不同系别,向列表框中加载该系的专业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDept.SelectedIndex)
            {
                case 0:
                    lstSpec.Items.Clear();
                    lstSpec.Items.Add("计算机科学与技术");
                    lstSpec.Items.Add("信息与科学技术");
                    break;
                case 1:
                    lstSpec.Items.Clear();
                    lstSpec.Items.Add("集成电路与集成系统");
                    lstSpec.Items.Add("集成电路设计与集成系统");
                    break;
                case 2:
                    lstSpec.Items.Clear();
                    lstSpec.Items.Add("通信工程");
                    lstSpec.Items.Add("电子信息工程");
                    lstSpec.Items.Add("电磁场与无线技术");
                    lstSpec.Items.Add("机械设计制造及其自动化");
                    break;
                case 3:
                    lstSpec.Items.Clear();
                    lstSpec.Items.Add("国际经济与贸易");
                    lstSpec.Items.Add("电子商务");
                    lstSpec.Items.Add("信息管理与信息系统");
                    lstSpec.Items.Add("财务管理");
                    break;
                default:
                    lstSpec.Items.Clear();
                    lstSpec.Items.Add("数字插画");
                    lstSpec.Items.Add("影视动画");
                    lstSpec.Items.Add("商用插画");
                    break;
            }
            lstSpec.SelectedIndex = 0;//设置默认专业为第一个选项
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 添加学生信息确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (rdoMale.Checked)
            {
                sex = rdoMale.Text;
            }
            else
            {
                sex = rdoFemale.Text;
            }
            string dept = cboDept.SelectedItem.ToString();
            string spet = lstSpec.SelectedItem.ToString();
            string hobby = "";
            if (checkBox1.Checked) hobby += checkBox1.Text;
            if (checkBox2.Checked) hobby += "、" + checkBox2.Text;
            if (checkBox3.Checked) hobby += "、" + checkBox3.Text;
            if (checkBox4.Checked) hobby += "、" + checkBox4.Text;
            if (checkBox5.Checked) hobby += "、" + checkBox5.Text;
            if (checkBox6.Checked) hobby += "、" + checkBox6.Text;
            //sql语句
            string sql = String.Format("insert into tab_StudentMsg(StudentName,Sex,Birthday,Department,Speciality,Hobby) values('{0}','{1}','{2}','{3}','{4}','{5}')",txtName.Text, sex,dtBirthday.Value,dept,spet,hobby);
            string connString = @"Data Source=.;Initial Catalog=MySchool;Integrated Security=True";
            using ( SqlConnection conn=new SqlConnection(connString) )
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql,conn);//创建Command对象
                int n = comm.ExecuteNonQuery();//执行添加命令 返回为更新的行数
                if (n>0)
                {
                    MessageBox.Show("添加学生信息成功","添加成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加学生信息失败","添加失败",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            //string info = "您的姓名是:" + txtName.Text;
            //info += "\n性别为:" + sex;
            //info += "\n出生年月为:" + dtBirthday.Value.ToShortDateString();
            //info += "\n您是" + dept + "系" + spet + "专业的学生";
            //info += "\n您的兴趣有"+hobby;
            //MessageBox.Show(info,"学生信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void timeGo_Tick(object sender, EventArgs e)
        {
            if (lblTip.Left > this.Width)
            {
                lblTip.Left = 0;
            }
            lblTip.Left += 1;
        }
    }
}
