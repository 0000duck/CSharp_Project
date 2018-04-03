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

namespace 计算器
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        ///（1） 定义窗体的公共变量
        /// </summary>
        private string number,opp,opp1;
        private double num1,num2,result;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// （2）编写数字键事件，数字键“0~9”的单机事件都是一样的，代码如下：
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)(sender);
        }
    }
   
}
