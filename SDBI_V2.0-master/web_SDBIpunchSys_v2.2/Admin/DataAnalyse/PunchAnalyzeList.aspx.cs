using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.DataVisualization.Charting;
public partial class PunchAnalyzeList : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        setGridView("信息工程系", GridView1);
        setGridView("会计系", GridView2);
        setGridView("机械工程系", GridView3);
        setGridView("经济管理系", GridView4);
        setGridView("商务外语系", GridView5);
        setGridView("食品工程系", GridView6);
    }
    private void createChart(GridView gv,PlaceHolder ph)
    {
        DataTable dt = new DataTable();
        foreach (string each in new string[] { "周次", "总人数" })
        {
            DataColumn dc = new DataColumn(each, Type.GetType("System.String"));
            dt.Columns.Add(dc);
        }
        for(int i = 0; i < gv.Rows.Count; i++)
        {
            DataRow dr = dt.NewRow();
            dr["周次"] = i + 1;
            GridViewRow gvr = gv.Rows[i];
            dr["总人数"] = gvr.Cells[6].Text;
            dt.Rows.Add(dr);
        }
        Chart chart1 = new Chart();
        chart1.DataSource = dt;
        chart1.DataBind();

        Series se = chart1.Series.Add("Series1");
        ChartArea ChartArea1 = chart1.ChartAreas.Add("ChartArea1");

        chart1.Series["Series1"].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Column;

        chart1.Series[0].XValueMember = "周次";

        chart1.Series[0].YValueMembers = "总人数";

        chart1.ChartAreas["ChartArea1"].AxisX.Title = "周次";
        chart1.ChartAreas["ChartArea1"].AxisY.Title = "总人数";

        chart1.ChartAreas["ChartArea1"].AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
        chart1.ChartAreas["ChartArea1"].AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;

        chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
        chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
        chart1.Series[0].IsValueShownAsLabel = true;

        ph.Controls.Add(chart1);

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    private void setGridView(string department,GridView gv)
    {
        DataTable dt = new DataTable();       
        foreach(string each in new string[] { "周次", "系别", "旷课", "请假", "迟到", "早退","总数" })
        {
            DataColumn dc = new DataColumn(each, Type.GetType("System.String"));
            dt.Columns.Add(dc);
        }

        //int TrueWeek = Convert.ToInt32(Session["TrueWeek"]);
        int TrueWeek = Convert.ToInt32("2");
        for (int i = 1; i <= TrueWeek; i++)
        {
            DataRow dr = dt.NewRow();
            dr[0] = i.ToString();
            dr[1] = department;
            int sum = 0;
            foreach (string each in new string[] { "旷课", "请假","迟到","早退" })
            {
                DataRow eachdr = dt.NewRow();
                string sqlResult = DAL.ConnHELPer.GetDistinceColoum( " select count(distinct StudentID) from TabTeacherAttendance where IsaAttendance = '"+each+"' and TrueWeek = '"+i+"' and TeacherDepartment = '" + department + "'").Rows[0][0].ToString();
                dr[each] = sqlResult;
                sum += Convert.ToInt32(sqlResult);
            }
            dr["总数"] = sum;
            dt.Rows.Add(dr);
            
        }
        gv.DataSource = dt;
        gv.DataBind();
        
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        createChart(GridView3, PlaceHolder3);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        createChart(GridView1, PlaceHolder1);
    }

    protected void Chart1_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        createChart(GridView2, PlaceHolder2);
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        createChart(GridView4, PlaceHolder4);
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        createChart(GridView5, PlaceHolder5);
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        createChart(GridView6, PlaceHolder6);
    }

    protected void GridView6_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        toshowStuUnpunchList("食品工程系");
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        toshowStuUnpunchList("信息工程系");
    }
    private void toshowStuUnpunchList(string department)
    {
        Session["nowDepartment"] = department;
        Response.Redirect("~/Admin/showStuUnpunchList.aspx");
    }

    protected void GridView5_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        toshowStuUnpunchList("商务外语系");
    }

    protected void GridView4_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        toshowStuUnpunchList("经济管理系");
    }

    protected void GridView3_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        toshowStuUnpunchList("机械工程系");
    }

    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        toshowStuUnpunchList("会计系");
    }
}