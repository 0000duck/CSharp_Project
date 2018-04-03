using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Admin_changePassWord : System.Web.UI.Page
{

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
        if (Session["Role"].ToString() != "1")
        {
            tx1.Text = Session["ID"].ToString();
            tx1.ReadOnly = true;
            seach.Visible = false;
        }        
    }

    protected void seach_Click(object sender, EventArgs e)
    {
        DataTable dt = DAL.ConnHELPer.GetDatatable("select UserName from TabTeachers where UserID='" + tx1.Text + "'");
        lbl1.Text = "即将对" + dt.Rows[0][0].ToString()+"修改信息！";

    }

    protected void bt_Click(object sender, EventArgs e)
    {
        if (newPassword.Text == repeatPassword.Text)
        {
            DAL.ConnHELPer.ExecuteNoneQueryOperation("update TabTeachers set UserPWD='" + newPassword.Text + "' where UserID='" + tx1.Text + "'");
            Label5.Text = "修改成功";
        }
        else
        {
            Label4.Text = "两次输入的密码不一致";
        }
    }
}