using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MySchoolDemo.Halp
{
    public  class Help
    {

        public static SqlConnection GetConnection()
        {
            string connString = @"Data Source=.;Initial Catalog=exam;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }

        //增删改
        public static void ExecuteSQLNonQuery(string strSQL)
        {
            using (SqlConnection conn=new SqlConnection())
            {
               // conn = GetConnection();
                conn.Open();
                //生成SqlCommand对象，并调用相应的方法执行SQL语句。  
                SqlCommand comm = new SqlCommand(strSQL, conn);
                comm.ExecuteNonQuery();
            }           
        }

        //实现查询
        public static DataTable GetDataTable(string strSQL)
        {

            //conn = GetConnection();
            //conn.Open();
            //利用SqlDataAdapter的Fill()方法，将值传给DataSet，最终将DataTable返回回去
            SqlDataAdapter da = new SqlDataAdapter();//定义数据适配器
            DataSet ds = new DataSet("exam");//定义数据集
            //SqlCommand comm = new SqlCommand(strSQL, conn);
           // da.SelectCommand = comm;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Fill(ds, "student");
            DataTable dt = ds.Tables["student"];
            //conn.Close();
            return dt;
        }
    }
}
