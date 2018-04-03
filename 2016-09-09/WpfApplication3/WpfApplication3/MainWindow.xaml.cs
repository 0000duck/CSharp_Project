using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication3
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
            MessageBox.Show("已删除");
        }

        private void txtB1_MouseEnter(object sender, MouseEventArgs e)
        {
            txtB1.Text = "你大爷来了!!!";
            txtboxName.Text = "有人进入了!!";
        }

        private void txtB1_MouseLeave(object sender, MouseEventArgs e)
        {
            txtB1.Text = "大爷您走好！！！";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("鹏哥你真帅！！");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("范浩真傻逼！！");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("你点我啦！");
            //txtboxName.Focus();//让txtboxName执行Focus这个方法、这个动作，让他获得焦点
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("你点我啦");
        }
    }
}
