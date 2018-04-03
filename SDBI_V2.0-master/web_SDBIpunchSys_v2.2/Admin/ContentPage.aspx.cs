using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
public partial class Admin_ContentPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Clear();
        BLL.ExcelFileToDB Efd = new BLL.ExcelFileToDB();
        string filename = FileUpload1.PostedFile.FileName;
        int result = Efd.checkFileUploadBefore(filename);
        if (result != 1)
        {
            if (result == 0)
                Label1.Text = "文件大小为0";
            if(result==-1)
                Label1.Text = "格式错误";
        }
        else
        {
            string filepath = Server.MapPath("~/Files/") + System.DateTime.Now.ToString("yyyyMMddHHmmss") + FileUpload1.FileName;
            FileUpload1.SaveAs(filepath);
            if (RadioButton1.Checked)
            {
                if (Efd.checkFileUploadAfter(filepath, "Teacher"))
                    Label1.Text = "表结构错误";
                else
                {
                    Efd.memoryTableToDB(Efd.getExcelTable(filepath), "TabTeachers");
                    Label1.Text = "导入成功";
                }
            }
            else
            {
                if (Efd.checkFileUploadAfter(filepath, "OtherTeacher"))
                    Label1.Text = "表结构错误";
                else
                {
                    Efd.memoryTableToDB(Efd.getExcelTable(filepath), "TabOtherTeachers");
                    Label1.Text = "导入成功";
                }
            }
        }
        
        //string identity = "";
        ////是否选择了类别
        //if (RadioButton1.Checked | RadioButton2.Checked)
        //{
        //    object[] result = new object[2];
        //    result = BLL.Excel2DB.CheckFile(FileUpload1.PostedFile.FileName);
        //    //文件名是否规范
        //    if ((bool)result[0])
        //    {
        //        string filepath = Server.MapPath("~/Files/") + System.DateTime.Now.ToString("yyyyMMddHHmmss")+FileUpload1.FileName;
        //        FileUpload1.SaveAs(filepath);
        //        //如果选中本校
        //        if (RadioButton1.Checked)
        //        {

        //            identity = "TabTeachers";
        //            Label1.Text = "文件导入中...";
        //            Label1.Text = BLL.Excel2DB.ToSQLSever(filepath, identity);
        //        }
        //        else
        //        //如果选择其他
        //        {
        //            identity = "TabOtherTeachers";
        //            Label1.Text = "文件导入中...";
        //            Label1.Text = BLL.Excel2DB.ToSQLSever(filepath, identity);
        //        }

        //    }
        //    else
        //    {
        //        Label1.Text = result[1].ToString();
        //    }
            
        //}
        //else
        //{
        //    Label1.Text = "请先选择导入数据类型：本校教师或外聘教师";
        //}

    }
    private void Clear()
    {
        Label1.Text = "";
        Label2.Text = "";
        Label3.Text = ""; 
    }
    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        string department = "";
        BLL.ExcelFileToDB Efd = new BLL.ExcelFileToDB();
        string filename = FileUpload2.PostedFile.FileName;
        int result = Efd.checkFileUploadBefore(filename);
        if (result != 1)
        {
            if (result == 0)
                Label2.Text = "文件大小为0";
            if (result == -1)
                Label2.Text = "格式错误";
        }
        else
        {
            string filepath = Server.MapPath("~/Files/") + System.DateTime.Now.ToString("yyyyMMddHHmmss") + FileUpload2.FileName;
            FileUpload2.SaveAs(filepath);
            department = DropDownList1.SelectedItem.Value.ToString();
            result = Efd.checkFileUploadAfter(filepath, "Course", department);
            if (result != 0)
            {
                if (result == -1)
                    Label2.Text = "sheet名错误";
                if (result == 1)
                    Label2.Text = "结构错误";

            }
            else
            {
                Efd.memoryTableToDB(Efd.getExcelTable(filepath), "TabAllCourses");
                Label2.Text = "导入成功";
            }
        }
        //Clear();
        //string department = "";
        ////检查文件名是否规范
        //object[] result = new object[2];
        //result = BLL.Excel2DB.CheckFile(FileUpload2.PostedFile.FileName);
        //if ((bool)result[0])
        //{
        //    department = DropDownList1.SelectedItem.ToString();
        //    string filepath = Server.MapPath("~/Files/") + System.DateTime.Now.ToString("yyyyMMddHHmmss") + FileUpload2.FileName;
        //    FileUpload2.SaveAs(filepath);
        //    //内容验证 ？入库：返回错误信息
        //    Label2.Text = "文件导入中...";
         //  Label2.Text = BLL.Excel2DB.ToSQLSever(filepath, department);
        //}
        //else
        //{
        //    Label2.Text = result[1].ToString();
        //}
        
       
    }

    protected void Unnamed3_Click(object sender, EventArgs e)
    {
        Clear();
        BLL.ExcelFileToDB Efd = new BLL.ExcelFileToDB();
        string filename = FileUpload3.PostedFile.FileName;
        int result = Efd.checkFileUploadBefore(filename);
        if (result != 1)
        {
            if (result == 0)
                Label3.Text = "";
            if (result == -1)
                Label3.Text = "";
        }
        else
        {
            string filepath = Server.MapPath("~/Files/") + System.DateTime.Now.ToString("yyyyMMddHHmmss") + FileUpload3.FileName;
            FileUpload3.SaveAs(filepath);

            if (Efd.checkFileUploadAfter(filepath, "Calendar"))
                Label3.Text = "表结构错误";
            else
            {
                Efd.memoryTableToDB(Efd.getExcelTable(filepath), "TabCalendar");
                Label3.Text = "导入成功";
            }


        }

        //string date = DateName.Value;
        //Application["Start"] = date;
        //Clear();
        //object[] result = new object[2];
        //result=BLL.Excel2DB.CheckFile(FileUpload3.PostedFile.FileName);
        //if ((bool)result[0])
        //{
        //    string filepath = Server.MapPath("~/Files/") + System.DateTime.Now.ToString("yyyyMMddHHmmss") + FileUpload3.FileName;
        //    FileUpload3.SaveAs(filepath);
        //    //内容验证 ？入库：返回错误信息
        //    Label3.Text = "文件导入中...";
        //    Label3.Text = BLL.Excel2DB.ToSQLSever(filepath, "TabCalendar");
        //}
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        BLL.DataBaseInit dbInit = new BLL.DataBaseInit();
        bool CourseInitResult= dbInit.TabCourseInit(Application["Start"].ToString());
        bool ClassInitResult= dbInit.TabClassInit();  
        if(CourseInitResult & ClassInitResult)
        {
            Label4.Text = "成功";
        }
        else
        {
            Label4.Text = "失败";
        }      
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
}