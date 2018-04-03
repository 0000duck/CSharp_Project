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

namespace Toolbar
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

        private void iToolbarSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("您已保存！");
        }

        private void iabout_Click(object sender, RoutedEventArgs e)
        {
           string name = txtName.Text; 
            AboutWindow aboutWin = new AboutWindow();
           aboutWin.UserName = name;//无论是子窗口向主窗口传值
            //还是子窗口给主窗口传值，都可以通过属性
            aboutWin.ShowDialog();
            MessageBox.Show(aboutWin.Passward);
        }

        private void miOpen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("您已打开!");
        }
    }
}
