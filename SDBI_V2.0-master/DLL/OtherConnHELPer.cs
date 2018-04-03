using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public static class OtherConnHELPer
    {
        public static DataTable getDataTableBySQL(string sql,string connStr)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter(sql, connStr);
            da.Fill(dt);
            return dt;
        }
    }
}
