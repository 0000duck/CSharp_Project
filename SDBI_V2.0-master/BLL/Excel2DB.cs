using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
     public class Excel2DB
    {
        public static object[] CheckFile(string filename)
        {
            object[] result = new object[2];
            int filesize = 0;
            string fileextend = "";
            try
            {
                if (filename != String.Empty)
                {
                    filesize = filename.Length;
                    if (filesize == 0)
                    {
                        result[0] = false;
                        result[1]= "导入的文教大小为0!!!";
                    }
                    fileextend = filename.Substring(filename.LastIndexOf(".") + 1);
                    if (fileextend != "xls")
                    {
                        result[0] = false;
                        result[1]= "文件格式不正确!!!";
                    }
                    result[0] = true;
                    return result;
                    //return ToSQLSever(filename, identity);
                }
                else
                {
                    result[0] = false;
                    result[1]="文件为空!!!";
                    return result;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public static string ToSQLSever(string filepath,string identity)
        {
            if (identity == "TabTeachers" | identity == "TabOtherTeachers")
            {
                return DAL.Excel2SqlServer.ReadTeachersExcle(filepath, identity);
            }else if (identity == "TabCalendar")
            {
                return DAL.Excel2SqlServer.ReadCalendarExcel(filepath, identity);
            }
            else
            {
                return DAL.Excel2SqlServer.ReadCoursesExcel(filepath, identity);
            }
        }
    }
}
