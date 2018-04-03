using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace OperateEngineering.DAL
{
    public class DatabaseHelper
    {
        private static SqlConnection conn;

        //配置连接字符串，生成SqlConnection对象，并返回。  （4分）
        public static SqlConnection GetConnection() { 
        
            return null;
        }

        //实现增删改操作  （8分）
        public static void ExecuteSQLNonQuery(string strSQL) {
            try
            {
                conn = GetConnection();
                conn.Open();
                //生成SqlCommand对象，并调用相应的方法执行SQL语句。  




            }
            catch(Exception e)
            {
                throw(e);
            }
            finally {
                conn.Close(); 
            }
        }

        //实现查询操作  （8分）
        public static DataTable GetDataTable(string strSQL) {
            SqlConnection conn = GetConnection();
            conn.Open();
            //利用SqlDataAdapter的Fill()方法，将值传给DataSet，最终将DataTable返回回去
           








            return null;
        }
    }
}
