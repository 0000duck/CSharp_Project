using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
public partial class Admin_HomeWorkStatus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ArrayList array = new ArrayList();
            array.Add("所有记录");
            array.Add("教师工号");
            array.Add("教师姓名");
            array.Add("周次");
            DropDownList1.DataSource = array;
            DropDownList1.DataBind();
        }      
    }
    private void bindDataTable(string limit,string limitValue)
    {
        string sql = "SELECT distinct TimePunch,TeacherID,TeacherName,WeekTh,Week,Time,CourseName,Type FROM TabStatusHomework WHERE " + limit + "='" + limitValue + "'";
        DataTable dt = new DataTable();
        dt = DAL.ConnHELPer.GetDatatable(sql);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    private void bindDataTableByWeek(int weekTH)
    {
        BLL.Ptime stamp = new BLL.Ptime();
        string start = Application["Start"].ToString();
        Dictionary<string, double> startPunchAndEndPunch =stamp.getStart2End(Application["Start"].ToString(),weekTH);

        string sql = "SELECTSELECT distinct TimePunch,TeacherID,TeacherName,WeekTh,Week,Time,CourseName,Type FROM TabStatusHomework TimePunch>" + startPunchAndEndPunch["start"]+" and TimePunch<"+startPunchAndEndPunch["end"];
        DataTable dt = new DataTable();
        dt = DAL.ConnHELPer.GetDatatable(sql);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string limit = DropDownList1.SelectedItem.Value;
        if (limit== "所有记录")
        {
            bindDataTable("1", "1");
        }
        if (limit == "教师工号")
        {
            bindDataTable("TeacherID", TextBox1.Text);
        }
        if (limit == "教师姓名")
        {
            bindDataTable("TeacherName", TextBox1.Text);
        }
        if (limit == "周次")
        {
            int weekTh = Convert.ToInt32(DropDownList2.SelectedItem.Value[2]);
            
            bindDataTableByWeek(weekTh);
        }
    }

    protected void DropDownList1_TextChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.Value == "周次")
        {
            TextBox1.Visible = false;
            DropDownList2.Visible = true;
            WeekBind();
        }
        else
        {
            TextBox1.Visible = true;
            DropDownList2.Visible = false;
        }
    }
    private void WeekBind()
    {
        BLL.Ptime stamp = new BLL.Ptime();
        DropDownList2.DataSource = stamp.getPastWeekList(Application["Start"].ToString());
        DropDownList2.DataBind();
    }
}