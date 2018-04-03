using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

using System.Data;
public partial class Admin_notify : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        submit();
        Label1.Text = "发送成功";

    }
    private void submit()
    {
        string title = TextBox2.Text;
        string content = TextBox1.Text;
        string range = DropDownList1.SelectedItem.Text;
        
        //DataTable teacher = 
        //DataTable dt = BLL.AddSQLStringToDAL.RangeGetDatatableBySQL("TeacherID", "TabTeachers", "1", "1");
        switch (range)
        {
            case "全校教师":
                MasagetoDB(title,content, "4");
                break;
            case "管理员":
                MasagetoDB(title, content, "1");                
                break;
            case "院校领导":
                MasagetoDB(title, content, "2");
                break;
            case "系辅导员":
                MasagetoDB(title, content, "3");
                break;
        }
    }
    private void MasagetoDB(string title,string masage,string range)
    {
        List<string> teacherList = getTeacherList(range);
        string time = System.DateTime.Now.ToString("yyyyMMddHHmmss");
        string sql = string.Empty;

        foreach (string s in teacherList)
        {
            sql += "  insert into TabMessage values('" + time + "','"+title+"','" + masage + "','" + s + "')";
        }
        DAL.ConnHELPer.ExecuteNoneQueryOperation(sql);
       
    }
    private List<string> getTeacherList(string range)
    {
        DataTable teachers = new DataTable();
        DataTable otherTeachers = new DataTable();

        teachers = BLL.AddSQLStringToDAL.RangeGetDatatableBySQL(" UserID", "TabTeachers","Role",range);
        otherTeachers = BLL.AddSQLStringToDAL.RangeGetDatatableBySQL("UserID", "TabOtherTeachers", "Role", range);

        List<string> teacherList = new List<string>();

        foreach (DataTable dt in new DataTable[]{teachers,otherTeachers })
        {
            foreach(DataRow dr in dt.Rows)
            {
                teacherList.Add(dr[0].ToString());
            }
        }

        return teacherList;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        clear();
        Label1.Text = "内容已清空";
    }
    private void clear()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        DropDownList1.SelectedIndex = 0;
    }
}