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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 委托Dmeo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>,
    /// 
    public delegate int Caculate(int x, int y); //声明委托
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public Caculate handler;//定义委托类型的字段
        private void btnCaculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txt1.Text);
                int b = Convert.ToInt32(txt2.Text);
                MyMath math = new MyMath();
                handler = new Caculate(math.Add);//创建委托对象，同时封装方法
                lblAdd.Content = "两数的和为:" + handler(a, b);//通过委托对象调用方法
                handler = new Caculate(math.Multiply);
                lblMultiply.Content = "两数的积为:" + handler(a, b);
            }
            catch { }
           
        }

        class MyMath
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
            public int Multiply(int x, int y)
            {
                return x * y;
            }
        }
    }
}
