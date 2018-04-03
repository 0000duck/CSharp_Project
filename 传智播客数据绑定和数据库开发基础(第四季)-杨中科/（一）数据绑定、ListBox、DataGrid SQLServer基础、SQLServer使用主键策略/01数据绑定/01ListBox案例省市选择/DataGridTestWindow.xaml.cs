using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace _01ListBox案例省市选择
{
    /// <summary>
    /// DataGridTestWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DataGridTestWindow : Window
    {
        public DataGridTestWindow()
        {
            InitializeComponent();
        }

        private void dg1_Loaded(object sender, RoutedEventArgs e)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student { Name = "小红", Age = 20, Score = 100,Gender=true,ClassName="一班"});//初始化器
            list.Add(new Student { Name = "元芳", Age = 300, Score = 59 ,Gender=false,ClassName="一班"});
            list.Add(new Student { Name = "小哥哥", Age = 18, Score = 50,Gender=true,ClassName="二班" });
            dg1.ItemsSource = list;

            List<string> classNames = new List<string>();
            classNames.Add("一班");
            classNames.Add("二班");
            classNames.Add("三班");
            colClassName.ItemsSource = classNames;
            
        }
    }
}
