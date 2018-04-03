using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace BLL
{
    public class DataBaseInit
    {
        
        
        public bool TabCourseInit(string StemStart = "2016-9-1")
        {
            BLL.Ptime Stamp = new Ptime();
            //所有数据拆分完成后保存在此表中
            DataTable endTable = getDBCourseTableStructure();



            //获取所有原始授课数据
            //sql语句：select distinct Teacher , TeacherDepartment,TimeAndArea,Course FROM TabAllCourses
            //Teacher                  TeacherDepartment    TimeAndArea                                 Course
            //[1982013305]王波涛       信息工程系           [1 - 20周]星期三[3 - 4节] / 二号楼B202      [360563]市场营销与谈判技巧(4)
            DataTable dt = getAllCourse();
            
            //依次处理每一条数据
            foreach (DataRow dr in dt.Rows)
            {

                //拆分教师：[2002013122]张雁
                string teacherDepartment = dr[1].ToString().Trim();
                string[] teacher = dr[0].ToString().Split(new char[] { '[', ']' });
                    string teacherID = teacher[1].ToString();
                    string teacherName = teacher[2].ToString();
                //拆分课程：[310010]毛、邓、江概论(上)(2)
                string[] course = dr[3].ToString().Split(new char[] { '[', ']' });
                    string courseID = course[1];
                    string courseName = course[2];
                string Class = dr["Class"].ToString();
                //最主要的拆分:[1-14,16-20周]星期一[3-4节]/一号楼A312@[1-14,16-20周]星期五[5-6节]/一号楼A312
                //返回
                //[1-14,16-20周]2[8:00-10:00]/一号楼A312
                //[1-14,16-20周]4[10:00-12:00]/一号楼A312
                //[1-14,16-20周]6[10:00-12:00]/一号楼A312
                string timeAndArea = dr[2].ToString();
                string[] c_Colume = split_C_ColumeByAt(dr[2].ToString());

                //返回：教师ID=时间戳=课程ID
                foreach (string eac in c_Colume)
                {
                    string[] weekList = replace(eac.Split(new char[] { '[', ']', '/' }));
                    //星期
                    string Week = weekList[2];
                    //地点
                    string where = weekList[weekList.Length - 1];
                    //时间
                    string time = weekList[3];
                    //周次                       
                    List<string> weekThList = GetWithoutWeek(weekList[1]);
                    foreach (string WeekTh in weekThList)
                    {
                        //第几周
                        int stampWeekTh = Convert.ToInt32(WeekTh);
                        //星期
                        int stampWeek = Convert.ToInt32(Week);
                        //时间
                        int stampTime = Convert.ToInt32(time);
                        DataRow endDr = endTable.NewRow();
                        //班级
                        endDr["Class"] = Class;
                        //课程名
                        endDr["CourseName"] = courseName;
                        //课程ID[课程号]
                        endDr["CourseID"] = courseID;
                        //上课时间
                        endDr["CourseTime"] = Rereplace(stampTime);
                        //上课地点
                        endDr["CourseWhere"] = where;
                        //班级ID[教师工号=课程号==时间戳]
                        endDr["ClassID"] = teacherID + "=" + courseID + "=" + Stamp.GetTimeStamp(Stamp.getDataTime(StemStart, stampWeekTh, stampWeek, stampTime));
                        //教师系别
                        endDr["TeacherDepartment"] = teacherDepartment;
                        //教师姓名
                        endDr["TeacherName"] = teacherName;
                        //教师ID
                        endDr["TeacherID"] = teacherID;
                        //课程时间戳                            
                        endDr["TimePunch"] = Stamp.GetTimeStamp(Stamp.getDataTime(StemStart, stampWeekTh, stampWeek, stampTime));
                        //考勤状态
                        endDr["PunchType"] = "未考勤";
                        endDr["TimeAndArea"] = timeAndArea;
                        //以下三列用于展示信息，没有实质用处
                        endDr["WeekTh"] = WeekTh;
                        endDr["Week"] = Week;                       
                        endTable.Rows.Add(endDr);
                    }
                }


            }
            //try
            //{
                memoryTableToDB(endTable, "TabCourse");
                return true;
            //}
            //catch
            //{
               // return false;
            //}
            
            
        }
        private string Rereplace(int timeNum)
        {
            string result = "";
            if (timeNum == 8)
                result= "1-2节";
            if (timeNum == 10)
                result= "3-4节";
            if (timeNum == 14)
                result= "5-6节";
            if (timeNum == 16)
                result= "7-8节";
            if (timeNum == 19)
                result= "9-10节";
            return result;
        }
        public bool TabClassInit()
        {
            
            DataTable ClassIDList = DAL.OtherConnHELPer.getDataTableBySQL("SELECT  distinct ClassID,TimeAndArea,TeacherName,CourseName,CourseTime,WeekTh,Week FROM TabCourse", ConfigurationManager.ConnectionStrings["newConnForClass"].ConnectionString);
            //目标数据表
            DataTable endTable = DAL.OtherConnHELPer.getDataTableBySQL("SELECT * FROM TabClass", ConfigurationManager.ConnectionStrings["newConnForClass"].ConnectionString);
            //源数据表
            DataTable TableCourseAllData = DAL.OtherConnHELPer.getDataTableBySQL("select * from TabAllCourses", ConfigurationManager.ConnectionStrings["newConnForClass"].ConnectionString);

            foreach (DataRow dr in ClassIDList.Rows)
            {
                string classid = dr[0].ToString();
                string timeAndArea = dr[1].ToString();
                string teacherName = dr[2].ToString();
                //克隆源表结构
                DataTable SourseTable = TableCourseAllData.Clone();

                //查询源数据表中符合条件的数据
                DataRow[] SelectTableCourseAllData = TableCourseAllData.Select("TimeAndArea='"+timeAndArea+"'");

                //添加至目标数据表
                foreach(DataRow SourseDr in SelectTableCourseAllData)
                {
                    DataRow endDr = endTable.NewRow();
                    endDr["CourseID"] = classid;
                    endDr["Class"] = SourseDr["Class"];
                    endDr["TeacherName"] = teacherName;
                    endDr["StuDepartment"] = SourseDr["StuDepartment"];
                    endDr["StuName"] = SourseDr["StuName"];
                    endDr["StuID"] = SourseDr["StuID"];
                    endDr["WeekTh"] = dr["WeekTh"];
                    endDr["Week"] = dr["Week"];
                    endDr["Time"] = dr["CourseTime"];
                    endDr["Course"] = dr["CourseName"];

                    endTable.Rows.Add(endDr);
                }
                //foreach(DataRow sourceDr in SourceTable.Rows)
                //{
                //    DataRow endDr = endTable.NewRow();

                //    endDr["CourseID"] = classid;
                //    endDr["Class"] = sourceDr["Class"];
                //    endDr["TeacherName"] = teacherName;
                //    endDr["StuDepartment"] = sourceDr["StuDepartment"];
                //    endDr["StuName"] = sourceDr["StuName"];            
                //    endDr["StuID"] = sourceDr["StuID"];
                //    endDr["WeekTh"] = dr["WeekTh"];
                //    endDr["Week"] = dr["Week"];
                //    endDr["Time"] = dr["CourseTime"];
                //    endDr["Course"] = dr["CourseName"];

                //    endTable.Rows.Add(endDr);
                //}
            }
            try
            {
                memoryTableToDB(endTable, "TabClass");
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        //提取excel内容
        private  DataTable getAllCourse()
        {
            string sql = "select distinct Teacher,TeacherDepartment,TimeAndArea,Course,Class FROM TabAllCourses";
            string connStr = ConfigurationManager.ConnectionStrings["newConnForClass"].ConnectionString;
            DataTable dt= DAL.OtherConnHELPer.getDataTableBySQL(sql,connStr);
            return dt;
        }
        
        //将c列拆分，并返回有效文件
        //返回
        //[1-14,16-20周]2[3-4节]/一号楼A312
        //[1-14,16-20周]4[3-4节]/一号楼A312
        //[1-14,16-20周]6[3-4节]/一号楼A312
        private string[] split_C_ColumeByAt(string c_Colume)
        {
            string[] list = c_Colume.Split(new char[] {'@' }, StringSplitOptions.RemoveEmptyEntries);
           
           
            return list;
        }
        //创建课程ID
        //1-14,16-20周]星期二[3-4节]/一号楼A312
        //先改变成
        //1/2/8:00-10:00
        //2/2/8:00-10:00
        //
        //在改变成
        //教师ID=时间戳=课程ID
        //时间戳：该课程的上课时间：第几周星期几第几节课的上课时间
        private string[] createClassID(string teacherID,string[] str,string courseID)
        {
            //拆分出周次
            foreach(string each in str)
            {
                string[] weekList= each.Split(new char[] { '[', ']', '/' });
                string Weeks = weekList[1];
                string where = weekList[weekList.Length - 1];
                string time = weekList[2];
                foreach(string ea in weekList)
                {
                    List<string> weekThList= GetWithoutWeek(ea);
                }
            }
            return new string[] { };
        }
        private  List<string> GetTimeAndAreaDetails(string str)
        {
            List<string> strList = new List<string>();
            if (str.IndexOf("CAD/CAM一体化室") != -1)
            {
                str = str.Replace("CAD/CAM一体化室", "CAD与CAM一体化室");
            }
            string[] strTemp = str.Split(new char[] { '[', ']', '/' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strTemp.Length; i++)
            {
                strList.Add(strTemp[i]);
            }

            return strList;
        }
        //1-12,14-17,19-20单周
        ////1  3  5  7  9  11   15  17 19 
        private  List<string> GetWithoutWeek(string str)
        {

            int v = 0;
            if (str.IndexOf("单周") != -1)
            {
                v = 1;
            }
            if (str.IndexOf("双周") != -1)
            {
                v = 2;
            }
            StringBuilder sb = new StringBuilder();
            if (sb.Length > 0)
            {
                sb.Remove(0, sb.Length);
            }
            //1-12,14-17,19-20单周            
            string[] strTemp = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //1-12 14-17 19-20单周
            //1-12 14-17 19-20单周
            for (int i = 0; i < strTemp.Length; i++)
            {
                //19 - 20单周
                string[] s1 = strTemp[i].Split(new char[] { '-', '单', '双', '周' }, StringSplitOptions.RemoveEmptyEntries);
                //19 20
                //1 12
                if (s1.Length == 1)
                {
                    sb.Append(" " + s1[0].ToString() + " ");
                }
                else
                {
                    for (int j = Convert.ToInt32(s1[0]); j < Convert.ToInt32(s1[1]); j++)
                    {
                        sb.Append(" " + j.ToString() + " ");
                    }
                    sb.Append(Convert.ToInt32(s1[1]).ToString());
                }
                //1 2 3 4 5 6 7 8 9 10 11 12
            }
            //1 2 3 4 5 6 7 8 9 10 11 12 14 15 16 17 19 20
            if (v == 1)
            {
                //1 2 3 4 5 6 7 8 9 10 11 12 14 15 16 17 19 20
                string[] ss1 = sb.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //1 2 3 4 5 6 7 8 9 10 11 12 14 15 16 17 19 20
                sb.Remove(0, sb.Length);
                for (int i = 0; i < ss1.Length; i++)
                {
                    int t = Convert.ToInt32(ss1[i]);
                    if (t % 2 != 0)
                        sb.Append(ss1[i] + " ");


                }
            }
            //1  3  5  7  9  11   15  17 19 
            //1 2 3 4 5 6 7 8 9 10 11 12 14 15 16 17 19 20
            if (v == 2)
            {
                string[] ss1 = sb.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                sb.Remove(0, sb.Length);
                for (int i = 0; i < ss1.Length; i++)
                {
                    int t = Convert.ToInt32(ss1[i]);
                    if (t % 2 == 0)
                        sb.Append(ss1[i] + " ");


                }
            }
            // 2  4  6  8  10  12 14  16   20
            string[] ss2 = sb.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> list5 = new List<string>(ss2);
            return list5;

        }
        private DataTable createTabCourse()
        {
            DataColumn CourseName = new DataColumn("CourseName", Type.GetType("System.String"));
            DataColumn CourseID = new DataColumn("CourseID",Type.GetType(""));
            DataColumn TeacherDepartment = new DataColumn("TeacherDepartment", Type.GetType(""));
            DataColumn TeacherName = new DataColumn("TeacherName", Type.GetType(""));
            DataColumn TeacherID = new DataColumn("TeacherID", Type.GetType(""));
            DataColumn TimePunch = new DataColumn("TeacherDepartment", Type.GetType("System.Decimal"));
            DataColumn PunchType = new DataColumn("TeacherDepartment", Type.GetType(""));
            DataTable dt = new DataTable();
            dt.Columns.Add(CourseName);
            dt.Columns.Add(CourseID);
            dt.Columns.Add(TeacherDepartment);
            dt.Columns.Add(TeacherName);
            dt.Columns.Add(TeacherID);
            dt.Columns.Add(TimePunch);
            dt.Columns.Add(PunchType);
            return dt;
        }
        /// <summary>
        /// 获取结构
        /// </summary>
        /// <returns></returns>
        private DataTable getDBCourseTableStructure()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["newConnForClass"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("select top 1 * from TabCourse", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //[1-14,16-20周]星期二[1-2节]/一号楼A312
        private string[] replace(string[] weekList)
        {
            for (int i = 0; i < weekList.Length; i++)
            {
                
                if (weekList[i] == "星期一") { weekList[i]=weekList[i].Replace("星期一", "1"); }
                if (weekList[i] == "星期二") { weekList[i]=weekList[i].Replace("星期二", "2"); }
                if (weekList[i] == "星期三") { weekList[i] = weekList[i].Replace("星期三", "3"); }
                if (weekList[i] == "星期四") { weekList[i] = weekList[i].Replace("星期四", "4"); }
                if (weekList[i] == "星期五") { weekList[i] = weekList[i].Replace("星期五", "5"); }
                if (weekList[i] == "星期六") { weekList[i] = weekList[i].Replace("星期六", "6"); }
                if (weekList[i] == "星期天") { weekList[i] = weekList[i].Replace("星期天", "7"); }
                if (weekList[i] == "星期日") { weekList[i] = weekList[i].Replace("星期日", "7"); }
                if (weekList[i] == "1-2节") { weekList[i] = weekList[i].Replace("1-2节", "8"); }
                if (weekList[i] == "3-4节") { weekList[i] = weekList[i].Replace("3-4节", "10"); }
                if (weekList[i] == "1-4节") { weekList[i] = weekList[i].Replace("1-4节", "8"); }
                if (weekList[i] == "5-6节") { weekList[i] = weekList[i].Replace("5-6节", "14"); }
                if (weekList[i] == "7-8节") { weekList[i] = weekList[i].Replace("7-8节", "16"); }
                if (weekList[i] == "5-8节") { weekList[i] = weekList[i].Replace("5-8节", "14"); }
                if (weekList[i] == "9-10节") { weekList[i] = weekList[i].Replace("9-10节", "19"); }
            }
            return weekList;
        }

        /// <summary>
        /// 将DataTable插入数据库
        /// </summary>
        /// <param name="dt">要插入的表</param>
        /// <param name="tableName">表名</param>
        /// <returns></returns>
        private bool memoryTableToDB(DataTable dt,string tableName)
        {
            string connStr = ConfigurationManager.ConnectionStrings["newConnForClass"].ConnectionString;
            using(SqlBulkCopy tableCopy =new SqlBulkCopy(connStr))
            {
                try
                {
                    tableCopy.DestinationTableName = tableName;
                    tableCopy.BatchSize = dt.Rows.Count;
                    tableCopy.WriteToServer(dt);
                    return true;
                }
                catch(Exception e)
                {
                    throw e;
                }         
                               
            }
            
        }


    }
}
