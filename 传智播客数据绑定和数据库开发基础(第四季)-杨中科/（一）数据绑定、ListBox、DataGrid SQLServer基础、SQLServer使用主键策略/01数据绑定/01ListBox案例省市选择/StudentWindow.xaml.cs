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
    /// StudentWindow.xaml 的交互逻辑
    /// </summary>
    public partial class StudentWindow : Window
    {
        public StudentWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student {Name="小红",Age=20,Score=100 });//初始化器
            list.Add(new Student { Name = "元芳", Age = 300, Score = 59 });
            list.Add(new Student { Name = "小哥哥", Age = 18, Score = 50 });
            lbStudent.ItemsSource = list;
        }

        private void lbStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student student = (Student)lbStudent.SelectedItem;
            MessageBox.Show(student.Score.ToString());
        }
    }
}
