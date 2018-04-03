using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Teacher_showMasage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
        
    }
    private void Bind()
    {
        DataTable dt = DAL.ConnHELPer.GetDatatable("select * from TabMessage where TeacherID='" + Session["ID"] + "'");
        repeater1.DataSource = dt;
        repeater1.DataBind();
    }
    protected void repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "bt1")
        {
            Label lbl= e.Item.FindControl("lblTime") as Label;
            DAL.ConnHELPer.ExecuteNoneQueryOperation("delete from TabMessage where MessageTime='" + lbl.Text + "' and TeacherID='" + Session["ID"] + "'");
            Bind();
        }
    }
}