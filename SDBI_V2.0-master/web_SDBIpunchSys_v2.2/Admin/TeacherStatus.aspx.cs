using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
public partial class Admin_TeacherStatus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList array = new ArrayList();
        array.Add("所有记录");
        array.Add("按周次查询");
        array.Add("按工号查询");
        array.Add("按教工姓名查找");
        DropDownList1.DataSource = array;
        DropDownList1.DataBind();
    }
    private void bindDataTable(string limit,string limitValue)
    {
        string sql = "select distinct TeacherID,TeacherName,TrueWeek,Weeks,Times,Course from TabTeacherAttendance where TrueWeek = '"+Session["TrueWeek"]+"'";
        int TrueWeek = Convert.ToInt32( Session["TrueWeek"]);
        for(int i = 2; i <= TrueWeek; i++)
        {
            sql += "  and TrueWeek='" + i + "'";
        }
        sql += " and " + limit + "='" + limitValue + "'";
        DataTable dt = new DataTable();
        dt = DAL.ConnHELPer.GetDatatable(sql);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    private void bindDataTable(string TrueWeek)
    {
        string sql = "select distinct TeacherID,TeacherName,TrueWeek,Weeks,Times,Course from TabTeacherAttendance where TrueWeek = '"+TrueWeek+"'";
        DataTable dt = new DataTable();
        dt = DAL.ConnHELPer.GetDatatable(sql);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    private void bindAll()
    {
        string sql = "select distinct TeacherID,TeacherName,TrueWeek,Weeks,Times,Course from TabTeacherAttendance ";
        DataTable dt = new DataTable();
        dt = DAL.ConnHELPer.GetDatatable(sql);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string limit = DropDownList1.SelectedItem.Text;
        if (limit== "所有记录")
        {
            bindAll();
        }
        if (limit== "按周次查询")
        {
            bindDataTable(TextBox1.Text);
        }
        if (limit == "按工号查询")
        {
            bindDataTable("TeacherID", TextBox1.Text);
        }
        if (limit == "按教工姓名查找")
        {
            bindDataTable("TeacherName", TextBox1.Text);
        }
    }
}