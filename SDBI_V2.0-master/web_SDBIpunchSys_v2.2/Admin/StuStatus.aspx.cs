using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
public partial class Admin_StuStatus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ArrayList array = new ArrayList();
            array.Add("所有记录");
            array.Add("按系部查询");
            array.Add("按班级查找");
            array.Add("按学号查找");
            array.Add("按姓名查找");
            DropDownList1.DataSource = array;
            DropDownList1.DataBind();
            bindDataTable("1", "1");
        }
    }
    private void bindDataTable(string limit,string limitValue)
    {
        int TrueWeek = Convert.ToInt32(Session["TrueWeek"]);
        string sql = "select TimePuch,TeacherName,StuDepartment,StuID,Class, StuName,Course,Type from TabStuUnpunchList where TrueWeek='" + TrueWeek + "' and "+limit+"='"+limitValue+"'";
        DataTable dt = DAL.ConnHELPer.GetDatatable(sql);
        string count = dt.Rows.Count.ToString();
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string limit = DropDownList1.SelectedItem.Value;
        if (limit == "所有记录")
        {
            bindDataTable("1", "1");
        }
        if (limit == "按系部查询")
        {
            bindDataTable("StuDepartment", TextBox1.Text);
        }
        if (limit == "按班级查找")
        {
            bindDataTable("Class", TextBox1.Text);
        }
        if (limit == "按学号查找")
        {
            bindDataTable("StuID", TextBox1.Text);
        }
        if (limit == "按姓名查找")
        {
            bindDataTable("StuName", TextBox1.Text);
        }
        
    }
}