using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using DAL;
public partial class Teacher_Punch : System.Web.UI.Page
{
    private DataTable dt;
    BLL.Ptime stamp = new Ptime();
    protected void Page_Load(object sender, EventArgs e)
    {
        bind();
    }
  
    private void insertAbnormal(string TimePuch,string WeekTh,string Week,string Time,string TeacherName,string StuDepartment,string StuID, string Class, string StuName,string Course,string Type)
    {
        string sql = "insert into TabStuUnpunchList values('"+TimePuch+"','"+WeekTh+"','"+Week+"','"+Time+"','"+TeacherName+"','"+StuDepartment+"','"+StuID+"','"+Class+"','"+StuName+"','"+Course+"','"+Type+"')";
        ConnHELPer.ExecuteNoneQueryOperation(sql);
    }
    private void bind()
    {
        string ClassID = Session["ClassID"].ToString();
        string sql = "SELECT * FROM TabClass WHERE CourseID='" + ClassID + "'";
        dt= DAL.ConnHELPer.GetDatatable(sql);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach(GridViewRow gr in GridView1.Rows)
        {
            //将考勤异常的学生数据插入到数据库

            //考勤情况

            string TimePunch = Session["ClassID"].ToString().Split('=')[2];
            string StuDepartment= gr.Cells[0].Text.ToString();
            string Class = gr.Cells[1].Text.ToString();
            string stuID = gr.Cells[2].Text.ToString();
            string stuName = gr.Cells[3].Text.ToString();
            Dictionary<string, string> TimePunchMessage = stamp.getTimePunchMessage(TimePunch);
            string weekTH = Session["NowWeek"].ToString();
            string Week = TimePunchMessage["星期"];
            string Time = TimePunchMessage["时间"];
            string TeacherName = Session["Name"].ToString();
            string Course = Session["NowCourse"].ToString();

            if ((gr.FindControl("RadioButton1") as RadioButton).Checked)
            {
                string type = "请假";
                insertAbnormal(TimePunch, weekTH, Week, Time, TeacherName, StuDepartment, stuID, Class, stuName, Course, type);
            }
            if ((gr.FindControl("RadioButton2") as RadioButton).Checked)
            {
                string type = "迟到";
                insertAbnormal(TimePunch, weekTH, Week, Time, TeacherName, StuDepartment, stuID, Class, stuName, Course, type);
            }
            if ((gr.FindControl("RadioButton3") as RadioButton).Checked)
            {
                string type = "早退";
                insertAbnormal(TimePunch, weekTH, Week, Time, TeacherName, StuDepartment, stuID, Class, stuName, Course, type);
            }
            if ((gr.FindControl("RadioButton4") as RadioButton).Checked)
            {
                string type = "旷课";
                insertAbnormal(TimePunch, weekTH, Week, Time, TeacherName, StuDepartment, stuID, Class, stuName, Course, type);
            }
            //正常不插入

            //考勤完成:未考勤-->以考勤
            DAL.ConnHELPer.ExecuteNoneQueryOperation("update TabCourse set PunchType='已考勤'  FROM TabCourse where ClassID='" + Session["ClassID"] + "'");
        }
        Response.Redirect("ContentPage.aspx");
    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        //请假
    }

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        //迟到
    }

    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        //早退
    }

    protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {
        //旷课
    }
}