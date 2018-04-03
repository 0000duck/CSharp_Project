using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Teacher_pastMessage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = DAL.ConnHELPer.GetDatatable("select * from pastMessag where Role='" + Session["Role"] + "'");
        repeater1.DataSource = dt;
        repeater1.DataBind();
    }
}