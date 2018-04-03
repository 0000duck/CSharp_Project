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

namespace WpfApplication2
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
            //因为可能不选择任何日期,所以SelectedDate属性是可null类型
            //DateTime? Value = dataPicker.SelectedDate;
            //if (Value==null)
            //{
            //    MessageBox.Show("请选择日期");
            //}
            //else
            //{
            //    MessageBox.Show("您选择的日期是"+ Value.ToString());
            //}
            dataPicker.SelectedDate = DateTime.Today;            
            MessageBox.Show(DateTime.Now.ToString());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            prossbarBlood.Value += 10;
        }
    }
}
