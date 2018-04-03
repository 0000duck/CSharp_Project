using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
       
    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        ZM_loginVal loginval = new ZM_loginVal(TextBox1.Text,TextBox2.Text);
        if (loginval.isLogin())
        {
            if (TextBox3.Text == Session["ViladatoeCode"].ToString())
            {
                sessionAdd(loginval);
                switch (loginval.getRole())
                {
                    case 1:                                            
                        Response.Redirect("../Admin/ContentPage.aspx");                      
                        break;
                    case 2:
                        Response.Redirect("../Admin/ContentPage.aspx");
                        break;
                    case 3:
                        Response.Redirect("../Admin/ContentPage.aspx");
                        break;
                    case 4:
                        Response.Redirect("../Teacher/ContentPage.aspx");
                        break;
                }  
            }
        }
        
    }
    private void sessionAdd(ZM_loginVal loginval)
    {
        Session.Clear();
        Session["ID"] = loginval.getID();
        Session["Role"] = loginval.getRole();
        Session["Name"] = loginval.getUserNmae();

        //获取本周的开始时间和结束时间
        BLL.Ptime stamp = new BLL.Ptime();
        string start = Application["Start"].ToString();
        Dictionary<string, double> StartAndEndTimePunch = stamp.getStart2End(start, stamp.getNowWeekTh(start, stamp.getNow()));
        double startPunch = StartAndEndTimePunch["start"];
        double endPunch = StartAndEndTimePunch["end"];
        Session["startTimePunch"] = startPunch;
        Session["endTimePunch"] = endPunch;
        Session["NowWeek"] = stamp.getNowWeekTh(start, stamp.getNow());
    }
}