using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Admin_showStuUnpunchList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int TrueWeek = Convert.ToInt32(Session["TrueWeek"]);
        string sql = "select TeacherName,StuDepartment,Class,StuID,StuName, Cource,Type,Weeks,ranges from StuUnpuchList where TrueWeek='" + TrueWeek + "'  and StuDepartment='会计系'";
        DataTable dt = DAL.ConnHELPer.GetDatatable(sql);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}