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

namespace WpfApplication1
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

        private void 删除_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("已删除");
        }

        private void txtB1_MouseEnter(object sender, MouseEventArgs e)
        {
            txtB1.Text = "大爷您来啦";
            txtBoxName.Text="有人进来了"
        }

        private void txtBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
