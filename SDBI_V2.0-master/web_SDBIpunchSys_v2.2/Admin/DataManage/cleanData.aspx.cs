using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_cleanData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        teachers.Text= DAL.ConnHELPer.GetDatatable("select count(UserID) from TabTeachers").Rows[0][0].ToString();
        otherTeachers.Text= DAL.ConnHELPer.GetDatatable("select count(UserID) from TabOtherTeachers").Rows[0][0].ToString();
        tx1.Text= DAL.ConnHELPer.GetDatatable("select count(StuID) from TabStuUnpunchList where StuDepartment='教务处'").Rows[0][0].ToString();       
        TextBox1.Text= DAL.ConnHELPer.GetDatatable("select count(StuID) from TabStuUnpunchList where StuDepartment='会计系'").Rows[0][0].ToString();       
        TextBox2.Text= DAL.ConnHELPer.GetDatatable("select count(StuID) from TabStuUnpunchList where StuDepartment='信息工程系'").Rows[0][0].ToString();      
        TextBox3.Text= DAL.ConnHELPer.GetDatatable("select count(StuID) from TabStuUnpunchList where StuDepartment='商务外语系'").Rows[0][0].ToString();        
        TextBox4.Text = DAL.ConnHELPer.GetDatatable("select count(StuID) from TabStuUnpunchList where StuDepartment='机械工程系'").Rows[0][0].ToString();
        TextBox5.Text = DAL.ConnHELPer.GetDatatable("select count(StuID) from TabStuUnpunchList where StuDepartment='食品工程系'").Rows[0][0].ToString();        
        TextBox6.Text = DAL.ConnHELPer.GetDatatable("select count(StuID) from TabStuUnpunchList where StuDepartment='经济管理系'").Rows[0][0].ToString();
        TextBox7.Text = DAL.ConnHELPer.GetDatatable("select count(StuID) from TabStuUnpunchList where StuDepartment='建筑工程系'").Rows[0][0].ToString();
        TextBox8.Text = DAL.ConnHELPer.GetDatatable("select count(StuID) from TabStuUnpunchList where StuDepartment='基础教学部'").Rows[0][0].ToString();
    }
    private void cleanTeacher(string tableName)
    {
        DAL.ConnHELPer.ExecuteNoneQueryOperation("delete from "+tableName+"");
    }
    private void cleanData(string departmentName)
    {
        DAL.ConnHELPer.ExecuteNoneQueryOperation("delete from TabStuUnpunchList where StuDepartment='" + departmentName+"'");
    }

    protected void clearTeachers_Click(object sender, EventArgs e)
    {
        cleanTeacher("TabTeachers");
    }

    protected void clearOtherTeachers_Click(object sender, EventArgs e)
    {
        cleanTeacher("TabOtherTeachers");
    }

    protected void bt1_Click(object sender, EventArgs e)
    {
        //cleanData("");
        cleanData("教务处");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        cleanData("会计系");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        cleanData("信息工程系");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        cleanData("商务外语系");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        cleanData("机械工程系");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        cleanData("食品工程系");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        cleanData("经济管理系");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        cleanData("建筑工程系");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        cleanData("基础教学部");
    }
}