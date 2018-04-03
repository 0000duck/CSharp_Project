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
    public partial class CourseFrm : Form
    {
        public CourseFrm()
        {
            InitializeComponent();
        }

        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet("MySchool");
        private void ShowCourses()
        {
            string connString = @"Data Source=.;Initial Catalog=Peng;Integrated Security=True ";
            string sql = " select CourseName as 课程名称,CourseClass as 课程类别,Required as 是否必修,Credit as 学分,PrelectionCredit as 理论学时,ExperimentCredit as 实验学时 from tab_Course";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            da.SelectCommand = comm;
            sqlCommandBuilder builder = new sqlCommandBuilder(da);
            da.Fill(ds, "tab_Course");
            dgvCourse.DataSource = ds.Tables["tab_Course"];
            conn.Close();            
        }
        
        private void CourseFrm_Load(object sender, EventArgs e)
        {
            ShowCourses();
        }
        /// <summary>
        /// 保存更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbnSave_Click(object sender, EventArgs e)
        {
            da.Update(ds,"CourseMsg");
            MessageBox.Show("数据更新已成功!","注意",MessageBoxButtons.OK,MessageBoxIcon.Warning);                   
        }
        /// <summary>
        /// 取消更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你是否真的要取消目前添加、修改或删除操作?","注意!",MessageBoxButtons.OK,MessageBoxIcon.Question)==DialogResult.OK)
            {
                ds.Clear();
                ShowCourses();
                dgvCourse.Refresh();
            }
        }
    }
}
