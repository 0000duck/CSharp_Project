using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
public partial class Admin_unPunchList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList array = new ArrayList();
        int TrueWeek = Convert.ToInt32(Session["TrueWeek"]);
        for(int i = 1; i <= TrueWeek; i++)
        {
            array.Add("第" + i + "周");
        }
        DropDownList1.DataSource = array;
        DropDownList1.DataBind();
        bindDataTable("1", "1");
    }
    private void bindDataTable(string limit,string limitValue)
    {
        DataTable dt = new DataTable();
        string sql = "SELECT distinct TeaID, TeaDepartment,TeaName FROM TeaHomeWorkStatu WHERE "+limit+"='"+limitValue+"'";
        dt = DAL.ConnHELPer.GetDatatable(sql);
        DataColumn dc = new DataColumn("Count", Type.GetType("System.String"));
        dt.Columns.Add(dc);

        //统计count
       for(int i = 0; i < dt.Rows.Count; i++)
        {
            dt.Rows[i]["Count"] = DAL.ConnHELPer.GetDatatable("select count(" + dt.Rows[i]["TeaID"].ToString() + ") from TeaHomeWorkStatu");
        }
        GridView1.DataSource = dt;
        GridView1.DataBind();    
        
    }

    protected void bt1_Click(object sender, EventArgs e)
    {
        string limtValue = DropDownList1.SelectedItem.Value[1].ToString();
        bindDataTable("TrueWeek", limtValue);
    }
}