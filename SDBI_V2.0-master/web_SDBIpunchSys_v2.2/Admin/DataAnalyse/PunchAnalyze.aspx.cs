using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
public partial class Admin_PunchAnalyze : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int TrueWeek = Convert.ToInt32(Session["TrueWeek"]);
        ArrayList list = new ArrayList();
        for (int i = 1; i <= TrueWeek; i++)
        {
            string item = "第" + i + "周";
            list.Add(item);
        }
        DropDownList1.DataSource = list;
        DropDownList1.DataBind();
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButton5.Checked)
        {
            createTable(" and TrueWeek='" + DropDownList1.SelectedItem.Value[1] + "'");
        }
        if (RadioButton1.Checked)
        {
            createTable(" and TrueWeek='" + Session["TrueWeek"] + "'");
        }
        if (RadioButton2.Checked)
        {
            int TrueWeek = Convert.ToInt32(Session["TrueWeek"]) - 1;
            if (TrueWeek <= 0)
            {
                Label1.Text = "无上周";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                createTable( " and TrueWeek='"+TrueWeek+"'");
            }
            
        }
        if (RadioButton3.Checked)
        {
            ArrayList list = new ArrayList();
            foreach(int i in new int[] { 0,1, 2, 3 })
            {
                if ((Convert.ToInt32(Session["TrueWeek"]) - i) > 0)
                {
                    list.Add(Convert.ToInt32(Session["TrueWeek"]) - i);
                }
                else
                    break;
            }
            string whereand = "";
            foreach (int each in list)
            {
                whereand += " and TrueWeek='" + each.ToString() + "' ";
            }
            createTable(whereand);
        }
        if (RadioButton4.Checked)
        {
            createTable("");
        }
    }
    private void createTable(string whereand)
    {
        Dictionary<string, int> chartSource = new Dictionary<string, int>();
        DataTable dt = new DataTable();
        foreach (string each in new string[] { "系部", "在校生人数", "旷课人次", "旷课率", "迟到人次", "迟到率", "早退人次", "早退率", "请假人次", "请假率", "总缺勤人次", "总缺勤率" })
        {
            DataColumn dc = new DataColumn(each, Type.GetType("System.String"));
            dt.Columns.Add(dc);
        }

        foreach (string eachDepartment in new string[] { "信息工程系", "会计系", "机械工程系", "经济管理系", "商务外语系", "食品工程系" })
        {
            DataRow dr = dt.NewRow();
            dr["系部"] = eachDepartment;
            dr["在校生人数"] = DAL.ConnHELPer.GetDistinceColoum("select count(distinct StudentID) from TabTeacherAttendance where StudentDepartment='" + eachDepartment + "' "+whereand).Rows[0][0].ToString();
            dr["旷课人次"] = DAL.ConnHELPer.GetDistinceColoum("select COUNT(distinct StudentID) from TabTeacherAttendance where IsaAttendance='旷课' and StudentDepartment='" + eachDepartment + "'    " + whereand).Rows[0][0].ToString();
            dr["迟到人次"] = DAL.ConnHELPer.GetDistinceColoum("select COUNT(distinct StudentID) from TabTeacherAttendance where IsaAttendance='迟到' and StudentDepartment='" + eachDepartment + "'    " + whereand).Rows[0][0].ToString();
            dr["早退人次"] = DAL.ConnHELPer.GetDistinceColoum("select COUNT(distinct StudentID) from TabTeacherAttendance where IsaAttendance='早退' and StudentDepartment='" + eachDepartment + "'    " + whereand).Rows[0][0].ToString();
            dr["请假人次"] = DAL.ConnHELPer.GetDistinceColoum("select COUNT(distinct StudentID) from TabTeacherAttendance where IsaAttendance='请假' and StudentDepartment='" + eachDepartment + "'    " + whereand).Rows[0][0].ToString();
            dr["总缺勤人次"] = (Convert.ToInt32(dr["旷课人次"]) + Convert.ToInt32(dr["迟到人次"]) + Convert.ToInt32(dr["早退人次"]) + Convert.ToInt32(dr["请假人次"])).ToString();
            dr["旷课率"] = (Convert.ToDouble(dr["旷课人次"]) / Convert.ToDouble(dr["在校生人数"])).ToString("P");
            dr["迟到率"] = (Convert.ToDouble(dr["迟到人次"]) / Convert.ToDouble(dr["在校生人数"])).ToString("P");
            dr["早退率"] = (Convert.ToDouble(dr["早退人次"]) / Convert.ToDouble(dr["在校生人数"])).ToString("P");
            dr["请假率"] = (Convert.ToDouble(dr["请假人次"]) / Convert.ToDouble(dr["在校生人数"])).ToString("P");
            dr["总缺勤率"] = (Convert.ToDouble(dr["总缺勤人次"]) / Convert.ToDouble(dr["在校生人数"])).ToString("P");
            dt.Rows.Add(dr);
            chartSource.Add(eachDepartment, Convert.ToInt32(dr["总缺勤人次"]));
        }
        GridView1.DataSource = dt;
        GridView1.DataBind();
        createChart(chartSource);
    }
    private void createChart(Dictionary<string,int> dataSource)
    {
        DataTable dt = new DataTable();
        DataColumn dc = new DataColumn("系别", Type.GetType("System.String"));
        DataColumn dc1 = new DataColumn("缺勤人数", Type.GetType("System.String"));
        dt.Columns.Add(dc);
        dt.Columns.Add(dc1);
        foreach(string each in new string[] { "信息工程系", "会计系", "机械工程系", "经济管理系", "商务外语系", "食品工程系" })
        {
            DataRow dr = dt.NewRow();
            dr[0] = each;
            dr[1] = dataSource[each].ToString();
            dt.Rows.Add(dr);
        }
        Chart1.DataSource = dt;
        Chart1.DataBind();

        Chart1.Series["Series1"].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Column;

        Chart1.Series[0].XValueMember = "系别";
        Chart1.Series[0].YValueMembers = "缺勤人数";

        Chart1.ChartAreas["ChartArea1"].AxisX.Title = "系别";
        Chart1.ChartAreas["ChartArea1"].AxisY.Title = "缺勤人数";

        Chart1.ChartAreas["ChartArea1"].AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
        Chart1.ChartAreas["ChartArea1"].AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;

        Chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
        Chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
        Chart1.Series[0].IsValueShownAsLabel = true;
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/PunchAnalyzeList.aspx");
    }
}