using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;


/// <summary>
/// 用于将SQL语句传入到DAL层，获得返回的数据集
/// </summary>
namespace BLL
{
    public class AddSQLStringToDAL
    {
        public static DataTable GetDatatableBySQL(string str1)
        {
            string strTemp = BuildSQLSelectString(str1);
            return ConnHELPer.GetDataTables(strTemp);
        }
        public static DataTable RangeGetDatatableBySQL(string range,string str,string lim,string limtext)
        {
            return ConnHELPer.GetDatatable("select " + range + " from " + str + " where "+lim+"='" + limtext + "'");
        }
        public static DataTable GetDatatableBySQL(string str1,string str2,string str3)
        {
            string strTemp = BuildSQLSelectString(str1, str2, str3);
            return ConnHELPer.GetDatatable(strTemp);
        }
        public static DataTable GetDatatableBySQL(string TableName,string str1,string str1Limit,string str2,string str2Limit)
        {
            string strSQL = BuildSQLSelectString(TableName, str1, str1Limit, str2, str2Limit);
            return ConnHELPer.GetDatatable(strSQL);

        }
        public static DataTable GetDatatableBySQL(string TableName,string str1,string str1Limit,string str2,string str2Limit,string str3,string str3Limit)
        {
            string strSQL = BuildSQLSelectString(TableName, str1, str1Limit, str2, str2Limit, str3, str3Limit);
            return ConnHELPer.GetDatatable(strSQL);
        }

        public static DataTable GetDatatableBySQL(string str1, string str2, string str3, string str4, string str5, string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13, string str14)
        {
            string strSQL = BuildSQLSelectString(str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14);
            return ConnHELPer.GetDataTables(strSQL);
        }

        private static string BuildSQLSelectString(string str1, string str2, string str3,string str4,string str5,string str6, string str7, string str8, string str9, string str10, string str11, string str12, string str13, string str14)
        {
            return "insert into [TabTeacherAttendance](TeacherDepartment,TeacherID,TeacherName,TrueWeek,Weeks,Times,Area,IsaAttendance,TimeAndArea,Course,Class,StudentDepartment,StudentID,StudentName) values('" + str1 + "','" + str2 + "','" + str3 + "','" + str4 + "','" + str5 + "','" + str6 + "','" + str7 + "','" + str8 + "','" + str9 + "','" + str10 + "','" + str11 + "','" + str12 + "','" + str13 + "','" + str14 + "');";
        }
        private static string BuildSQLSelectString(string strTableName)
        {
            return "select * from  " + strTableName;
        }
        private static string BuildSQLSelectString(string strTabeName,string strddl,string strtxt)
        {
            return "select * from " + strTabeName + " where " + strddl + "='" + strtxt + "'";
        }
        private static string BuildSQLSelectString(string TableName,string str1,string str1Limit,string str2,string str2Limit)
        {
            return "select * from " + TableName + " where " + str1 + "='" + str1Limit + "'and " + str2 + "='" + str2Limit + "'";
        }
        private static string BuildSQLSelectString(string TableName, string str1, string str1Limit, string str2, string str2Limit,string  str3,string str3LImit)
        {
            return "select * from " + TableName + " where " + str1 + "='" + str1Limit + "'and " + str2 + "='" + str2Limit + "' and "+str3+"='"+str3LImit+"'";
        }
        public static List<string> GetDistinctString(string strTable,string str1)
        {
            string strSQL = BuildSQLDistinctString(strTable, str1);
            return ConnHELPer.GetDistinceColoum(strSQL, str1);
        }
        public static List<string> GetDistinctString(string strTable, string str1,string lim,string limtext,string lim2,string limtext2)
        {
            string strSQL = BuildSQLDistinctString(strTable, str1,lim,limtext,lim2,limtext2);
            return ConnHELPer.GetDistinceColoum(strSQL, str1);
        }
        public static DataTable GetDistinctTable(string strSQL)
        {
            return ConnHELPer.GetDatatable(strSQL);
        }
        
        private static string BuildSQLDistinctString(string strTableName,string str1)
        {
            return "select distinct " + str1 + " from " + strTableName;
        }
        private static string BuildSQLDistinctString(string strTableName, string str1, string lim, string limtext, string lim2, string limtext2)
        {
            return "select distinct " + str1 + " from " + strTableName + "where " + lim + "='" + limtext + "' and " + lim2 + "='" + limtext2 + "' ";
        }
    }
}
