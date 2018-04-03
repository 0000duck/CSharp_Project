using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["Name"].ToString();
        string role = Session["Role"].ToString();
        switch (role)
        {
            case "1":
                Label2.Text = "管理员";
                break;
            case "2":
                Label2.Text = "院系领导";
                break;
            case "3":
                Label2.Text = "系辅导员";
                break;
            case "4":
                Label2.Text = "教师";
                break;
        }
        Label3.Text = "当前第" + Session["NowWeek"].ToString() + "周";
        HyperLink1.Text = "有"+DAL.ConnHELPer.GetDatatable("select count(TeacherID) from TabMessage where TeacherID='"+Session["ID"].ToString()+"'").Rows[0][0].ToString()+"条消息";
    }
}
