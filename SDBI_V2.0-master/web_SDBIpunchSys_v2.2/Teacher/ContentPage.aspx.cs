using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Teacher_ContentPage : System.Web.UI.Page
{
    DataTable dt;
    BLL.Ptime stamp = new BLL.Ptime();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        switch (Session["Role"].ToString())
        {
            case "1":
                this.MasterPageFile = "~/Admin/MasterPage.master";
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                this.MasterPageFile = "~/Teacher/MasterPage.master";
                break;
            default:
                Response.Redirect("~/Index/Login.aspx");
                break;

        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string start = Application["Start"].ToString();
            
            double startPunch = (double)Session["startTimePunch"];
            double endPunch = (double)Session["endTimePunch"];
            //查询授课信息           
            dt = DAL.ConnHELPer.GetDatatable("select * from TabCourse where TimePunch>"+startPunch+" and TimePunch<"+endPunch+ " and TeacherID='"+Session["ID"]+"'");
            dt.DefaultView.Sort = "TimePunch";
            //绑定
            repeater1.DataSource = dt;
            repeater1.DataBind();
            if (dt.Rows.Count == 0)
            {
                Message.Text = "您本周无课";
            }
            //刷新考勤需要的数据
            //Session["course"] = dt.Rows[0]["Course"].ToString();
            
        }
    }
    protected void repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        
        //如果激发了按钮控件
        if (e.CommandName == "button")
        {
            string teacherName = Session["Name"].ToString();
            string teacherID = Session["ID"].ToString();
            string NowWeek = Session["NowWeek"].ToString();
            string Week = (e.Item.FindControl("lblWeek") as Label).Text;
            string Time = (e.Item.FindControl("lblTime") as Label).Text; 
            string CourseName = (e.Item.FindControl("lblCourseName") as Label).Text; 
            double TimePunch = stamp.getRELLYTIMEPUNCH(Convert.ToDouble((e.Item.FindControl("TimePunch") as Label).Text));
            Label ClassID= e.Item.FindControl("ClassID") as Label;
            double NowTimePunch = stamp.GetTimeStamp(stamp.getNow());

            //是否可考勤:是否在考勤时间区间内，是否已经考勤过了
            string isPunch = DAL.ConnHELPer.GetDatatable("SELECT PunchType FROM TabCourse where ClassID='" + ClassID.Text + "'").Rows[0][0].ToString();

            if (isPunch == "未考勤")
            {
                if (TimePunch < NowTimePunch)
                {
                    if (!(e.Item.FindControl("ck1") as CheckBox).Checked)
                    {
                        DAL.ConnHELPer.ExecuteNoneQueryOperation("insert into TabStatusHomework values('" + teacherName + "','" + teacherID + "','" +
                            NowWeek + "','" + Week + "','" + Time + "','" + CourseName + "','未布置'," +
                            Convert.ToDouble((e.Item.FindControl("TimePunch") as Label).Text) + ")");
                    }
                    Session["ClassID"] = (e.Item.FindControl("ClassID") as Label).Text;
                    Session["NowCourse"] = CourseName.Split('(')[0];
                    Response.Redirect("~/Teacher/punch.aspx");
                }
                else
                {

                    Message.Text = "未至考勤时间(请您在该课程下课后考勤)";
                }
            }
            else
            {
                Message.Text = "该门课程您已经考勤过了";
            }
            
            
        }
    }
}
