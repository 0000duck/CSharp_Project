using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace DAL
{
    public class ConnHELPer
    {
        public static List<String> GetDistinceColoum(String strSQL,string str1)
        {
            DataTable dt = GetDatatable(strSQL);
            List<String> strList = new List<string>();
            foreach(DataRow dr in dt.Rows)
            {
                string str = dr[str1].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public static DataTable GetDistinceColoum(String strSQL)
        {
            DataTable dt = GetDatatable(strSQL);
            return dt;
        }
        public static int GetRecordCount(String strSQL)
        {
            string ConnectionStrng = ConfigurationManager.ConnectionStrings["ConnForClass"].ConnectionString;
            SqlConnection conn = new SqlConnection(ConnectionStrng);
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            string count = cmd.ExecuteScalar().ToString().Trim();
            if (count == "")
                count = "0";
            conn.Close();
            return Convert.ToInt32(count);
            
        }
        public static bool ExecuteNoneQueryOperation(String strSQL)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnForClass"].ConnectionString;
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                int i = 0;
                i++;
            }
            conn.Close();
            return true;
        }
        public  static DataTable GetDatatable(String strSQL)
        {
            DataSet ds = GetDataSet(strSQL);
            ds.CaseSensitive = false;
            return ds.Tables[0];
        } 
        public static DataSet GetDataSet(String strSQL)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnForClass"].ConnectionString;
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
                
        }
        public static DataTable GetDataTables(String strSQL)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["ConnForClass"].ConnectionString;
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }
    }
}
