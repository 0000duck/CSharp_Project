using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
namespace BLL
{
    /// <summary>
    /// 将Excel原始数据导入到数据库
    /// </summary>
    public class ExcelFileToDB
    {
        /// <summary>
        /// 检查Excel文件是否合法(文件大小、格式),1:合法;0:文件大小为0;-1:格式错误;
        /// </summary>
        /// <param name="filePath">Excel文件路径</param>
        /// <returns></returns>
        public int checkFileUploadBefore(string filePath)
        {
            int result = 1;
            int filesize = 0;
            string fileextend = "";
            try
            {
                if (filePath != String.Empty)
                {
                    filesize = filePath.Length;
                    if (filesize == 0)
                    {
                        result = 0;                       
                    }
                    fileextend = filePath.Substring(filePath.LastIndexOf(".") + 1);
                    if (fileextend != "xls")
                    {
                        result = -1;
                    }
                    else
                    {
                        
                        
                    }
                    result = 1;
                    return result;
                    //return ToSQLSever(filename, identity);
                }
                else
                {
                    result = 0;
                    return result;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool checkFileUploadAfter(string filePath, string identity)
        {
            bool result = false;
            DataTable dt = new DataTable();
            dt = getExcelTable(filePath);
            if (identity == "Teacher" | identity == "OtherTeacher")
            {
                string[] str = { "部门", "工号", "密码", "姓名", "性别", "权限" };
                for (int i = 0; i <= 5; i++)
                {
                    if (dt.Columns[i].ColumnName.ToString() != str[i])
                        result= true;
                }
            }
            if (identity == "Calendar")
            {
                string[] str = { "周次", "起", "止" };
                for (int i = 0; i <= 2; i++)
                {
                    if (dt.Columns[i].ColumnName.ToString() != str[i])
                    {
                        result= true;
                    }

                }
            }
            if (identity == "Course")
            {
                string[] str = { "承担单位", "任课教师", "上课时间/地点", "课程", "所属部门" };
                for (int i = 0; i <= 4; i++)
                {
                    if (dt.Columns[i].ColumnName.ToString() != str[i])
                        result= true;
                }
            }
            return result;
        }
        /// <summary>
        /// 检查课程表的sheet名，结构;1:结构错误;-1:sheet名错误;0;正确
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="identity"></param>
        /// <param name="department"></param>
        /// <returns></returns>
        public int checkFileUploadAfter(string filePath, string identity,string department)
        {
            int result = 0;
            DataTable dt = new DataTable();
            dt = getExcelTable(filePath);
            
            if (identity == "Course")
            {
                string sheetName = getSheetName(filePath);
                if (sheetName != (department + "$"))
                {
                    result = -1;
                }
                else
                {
                    string[] str = { "承担单位", "任课教师", "上课时间/地点", "课程", "所属部门" };
                    for (int i = 0; i <= 4; i++)
                    {
                        if (dt.Columns[i].ColumnName.ToString() != str[i])
                            result = 1;
                    }
                }
                
            }
            return result;
        }
        public DataTable getExcelTable(string filePath)
        {
            string str1 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + filePath + "';Extended Properties=Excel 8.0";
            string sheetName = getSheetName(filePath);
            string sqlStr = "select * from [" + sheetName + "]";
            OleDbConnection conn = new OleDbConnection(str1);
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sqlStr, conn);
            da.SelectCommand.CommandTimeout = 600;

            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            return dt;
        }
        
        /// <summary>
        /// 获取指定Excel表的sheet名
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private string getSheetName(string filePath)
        {
            string str1 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + filePath + "';Extended Properties=Excel 8.0";
            OleDbConnection conn = new OleDbConnection(str1);
            conn.Open();

            string SheetName = "";
            DataTable dtExcleSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            SheetName = dtExcleSchema.Rows[0]["TABLE_NAME"].ToString();
            conn.Close();
            conn.Dispose();
            return SheetName;
        }
        private bool isIn(string[] list,string each)
        {
            return list.Contains(each);
        }
        public bool memoryTableToDB(DataTable dt, string tableName)
        {
            
            string connStr = ConfigurationManager.ConnectionStrings["newConnForClass"].ConnectionString;
            string[] list;
            ArrayList removeList;
            if (tableName == "TabOtherTeachers" | tableName == "TabTeachers")
            {
                list=new string[]{ "部门", "工号", "密码", "姓名", "性别", "权限" };
                removeList = new ArrayList();
                //foreach (DataColumn dc in dt.Columns)
                //{
                //    if (!list.Contains(dc.ColumnName))
                //    {
                //        dt.Columns.Remove(dc.ColumnName);
                //    }                   
                //}

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (!list.Contains(dt.Columns[i].ColumnName))
                    {
                        removeList.Add(dt.Columns[i].ColumnName);
                    }
                }
                foreach(string each in removeList)
                {
                    dt.Columns.Remove(each);
                }
                               
            }
            if (tableName == "TabAllCourses")
            {
                list = new string[] { "承担单位", "任课教师", "上课时间/地点", "课程","院(系)/部","学号","姓名", "上课班级名称" };
                removeList = new ArrayList();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (!list.Contains(dt.Columns[i].ColumnName))
                    {
                        removeList.Add(dt.Columns[i].ColumnName);
                    }
                }
                foreach (string each in removeList)
                {
                    dt.Columns.Remove(each);
                }

            }
            if (tableName == "TabCalendar")
            {
                list = new string[] { "周次", "起", "止" };
                removeList = new ArrayList();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (!list.Contains(dt.Columns[i].ColumnName))
                    {
                        removeList.Add(dt.Columns[i].ColumnName);
                    }
                }
                foreach (string each in removeList)
                {
                    dt.Columns.Remove(each);
                }
            }
            using (SqlBulkCopy tableCopy = new SqlBulkCopy(connStr))
            {
                //try
                //{
                    tableCopy.DestinationTableName = tableName;
                    tableCopy.BatchSize = dt.Rows.Count;
                    tableCopy.WriteToServer(dt);
                    return false;
                //}
                //catch
                //{
                    //return true;
                //}

            }

        }
    }
}
