using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _02ADO.NET基础
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //SqlConnection为建立和数据库连接的对象
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=class_db;Integrated Security=True"))
            {
                conn.Open();//打开连接
                //通过连接创建一个向数据库发命令(Command)的对象SqlCommand
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    //CommandText为要执行的SQL语句
                    //cmd.CommandText = "insert into TabTeachers (Department,UserID,UserPWD,UserName,Sex,Role) values('信息与艺术设计系','123456','123456','洪佳朋','1','xx')";
                    cmd.CommandText = "select * from Tab_Student where Age<100";
                    //int i = (int)cmd.ExecuteScalar();
                    //cmd.ExecuteNonQuery();//执行

                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            string name = read.GetString(1);
                            int age = read.GetInt32(2);
                            MessageBox.Show(name+","+age);

                        }
                    }
                }
            }
            MessageBox.Show("执行完成");
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn=new SqlConnection("Data Source=.;Initial Catalog=class_db;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd=conn.CreateCommand())
                {
                    //输入 1' or '1'='1 会造成SQL注入漏洞
                    cmd.CommandText = "select age from Tab_Student where name='" + txtName.Text + "'";

                    //cmd.CommandText = "select age from Tab_Student where Name=@Name";

                    cmd.Parameters.Add(new SqlParameter("@Name",txtName.Text));//
                    using (SqlDataReader reader=cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //GetInt32获得的是int类型
                            //GetInt64获得的是long类型(数据库中是bigint)
                            int age = reader.GetInt32(0);
                            MessageBox.Show(age.ToString());
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = class_db; Integrated Security = True"))
            {
                conn.Open();
                using (SqlCommand cmd=conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Tab_Student where Age<@aaa";
                    cmd.Parameters.Add(new SqlParameter("@aaa",60));
                    //cmd.ExcuteReader()

                    //SqlDataAdapter 是帮我们把SqlCommand查询结果填充到DataSet中的类
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    //DataSet相当于本地的一个复杂集合 (List<int>)  查询结果有多少就占多少内存
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);//把SqlCommand查询结果填充到DataSet中

                    DataTable table = dataset.Tables[0];
                    DataRowCollection rows = table.Rows;
                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i];
                        int age = (int) row["Age"];
                        string name = (string)row["Name"];
                        MessageBox.Show(name+","+age);
                    }
                }
            }
        }
    }
}
