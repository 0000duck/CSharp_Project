using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DAL;
public partial class Admin_TeacherList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GVsource("1", "1");
        }

    }
    private void GVsource(string lim,string limText)
    {
        DataTable dt = BLL.AddSQLStringToDAL.RangeGetDatatableBySQL("Department,UserID,UserName,Role", "TabTeachers", lim, limText);
            //BLL.AddSQLStringToDAL.GetDatatableBySQL("TabTeachers", lim, limText);
        GridView1.DataSource = dt;
        GridView1.DataKeyNames = new string[] { "UserID" };
        GridView1.DataBind();
        //addEditAndDelet();
    }
    private void addEditAndDelet()
    {
        CommandField cf = new CommandField();
        cf.ButtonType = ButtonType.Button;
        cf.ShowEditButton = true;
        cf.CausesValidation = false;
        cf.ItemStyle.HorizontalAlign = HorizontalAlign.NotSet;
        cf.HeaderText = "编辑";
        GridView1.Columns.Add(cf);
        CommandField cf2 = new CommandField();
        cf2.ButtonType = ButtonType.Button;
        cf2.ShowDeleteButton = true;
        cf2.CausesValidation = false;
        cf2.ItemStyle.HorizontalAlign = HorizontalAlign.NotSet;
        cf2.HeaderText = "删除";
        GridView1.Columns.Add(cf2);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        switch(DropDownList1.SelectedItem.Text)
        {
            case "所有记录":
                GVsource("1", "1");
                break;
            case "按部门查询":
                GVsource("Department", TextBox1.Text);
                break;
            case "按教师工号查询":
                GVsource("UserID", TextBox1.Text);
                break;
            case "按教师姓名查询":
                GVsource("UserName", TextBox1.Text);
                break;
            case "按权限查询":
                GVsource("Role", TextBox1.Text);
                break;
            
        }
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        //隐藏原来的内容
        //GridView1.SelectedRow.Cells[3].Visible = false;
        //添加新的内容
        //DropDownList ddl = new DropDownList();
        //ddl.DataSource = new string[] { "1", "2", "3", "4" };
        //ddl.DataBind();
        //GridView1.SelectedRow.Cells[3].Controls.Add(ddl);

        GVsource("1","1");
    }

    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string dataKeys = GridView1.DataKeys[e.RowIndex].Value.ToString().Trim();
        DAL.ConnHELPer.ExecuteNoneQueryOperation("delete  from TabTeachers where UserID='" + dataKeys+ "'");
        GVsource("1", "1");
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        GVsource("1", "1");
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string Department= ((TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0]).Text.ToString().Trim();
        string UserID= ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text.ToString().Trim();
        string UserName= ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.ToString().Trim();
        string Role= ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text.ToString().Trim();
        DAL.ConnHELPer.ExecuteNoneQueryOperation("  update TabTeachers set Department='" + Department + "' where UserID='"+ UserID +"'"+
                                                 "  update TabTeachers set UserID='"+ UserID + "' where UserID='" + UserID + "'" +
                                                 "  update TabTeachers set UserName='" + UserName + "' where UserID='" + UserID + "'" +
                                                 "  update TabTeachers set Role='" + Role + "' where UserID='" + UserID + "'" 
                                                    );
        GridView1.EditIndex = -1;
        GVsource("1", "1");

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}