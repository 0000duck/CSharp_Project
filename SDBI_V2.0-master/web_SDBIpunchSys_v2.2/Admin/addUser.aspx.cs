using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_addUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["Role"].ToString() != "1")
        {
            Response.Redirect("~/Index/Login.aspx");
        }else
        {            
                this.MasterPageFile = "~/Admin/MasterPage.master";                       
        }
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string type = DropDownList1.SelectedItem.Value;
        string department = DropDownList2.SelectedItem.Text;
        string UserID = TextBox1.Text;
        string UserName = TextBox2.Text;
        string UserPWD = TextBox3.Text;
        string Role = DropDownList3.SelectedItem.Text;
        string sex = DropDownList4.SelectedItem.Text;
        addTeacher(type, department, UserID, UserPWD, UserName, sex, Role);
    }
    private void addTeacher(string type, string department,string UserID,string UserPWD,string UserName,string Sex,string Role)
    {
        string sqlStr = "insert into " + type + " VALUES('" + department + "','" + UserID + "','" + UserPWD + "','" + UserName + "','" + Sex + "','" + Role + "')";
        DAL.ConnHELPer.ExecuteNoneQueryOperation(sqlStr);
        Label1.Text = "成功";
    }
}