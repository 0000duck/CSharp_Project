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

namespace WpfApplication7
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
            //因为可能不选择任何的日期，所以SelectedDate属性是可null（空 ）的。
            //DateTime? value=DatePicker1.SelectedDate;
            //if (value == null)
            //{
            //    MessageBox.Show("请选择日期");
            //}
            //else
            //{
            //    MessageBox.Show(value.ToString());
            //}

            //DatePicker1.SelectedDate = DateTime.Today;
            MessageBox.Show(DateTime.Today.ToString());//只包含年月日
            MessageBox.Show(DateTime.Now.ToString());//还包含小时分秒

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            progressBlood.Value += 10;
            //progressBlood.Value = progressBlood.Value + 10;
            //先取一下progressBlood当前的值,+10。然后再赋值给progressBlood
        }
    }
}
