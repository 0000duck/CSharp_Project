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

namespace Do_You_Love_Me
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

        /// <summary>
        /// 当鼠标进入按钮的可见部分的时候，给按钮一个新的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            //给按钮一个新的坐标
            //这个按钮活动的最大宽度就是 窗体的宽度减去按钮的宽度

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("我也爱你呦思密达");
            this.Close();//关闭主窗体
        }
    }
}
