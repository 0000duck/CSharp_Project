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

namespace WpfApplication5
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

        private void btnShan_Click(object sender, RoutedEventArgs e)
        {
            //Visibility 的值是枚举类型：Visible:可见，Collapsed不可见
            //所有控件都有Visibility这个属性
            //txtName.Visibility = S ystem.Windows.Visibility.Collapsed; 

            if (txtName.Visibility == System.Windows.Visibility.Visible) {
                txtName.Visibility = System.Windows.Visibility.Collapsed;
            }
            else if (txtName.Visibility==System.Windows.Visibility.Collapsed) {
                txtName.Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
