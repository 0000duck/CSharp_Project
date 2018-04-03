using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using DAL;
using BLL;

public partial class test_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = DAL.ConnHELPer.GetDatatable("SELECT *  FROM TabAllCourses");
        DataRow[] dr= dt.Select("TimeAndArea='[1-18单周]星期三[5-6节]/E311(10装潢2)'");
        DataTable endTab = dt.Clone();
        foreach (DataRow d in dr)
        {
            endTab.ImportRow(d);
        }
        GridView1.DataSource = endTab;
        GridView1.DataBind();
    }

    


    protected void Button1_Click1(object sender, EventArgs e)
    {
    }
}