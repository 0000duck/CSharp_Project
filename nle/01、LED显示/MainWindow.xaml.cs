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
using ICS.Acquisition;
using ICS.Common;
using ICS.Models;
using LEDLibrary;
using ComLibrary;
using System.IO.Ports;
namespace _01_LED显示
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private LEDPlayer player;
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //加载接入到电脑的所有串口号，并添加到下拉菜单
            string[] arrPort = SerialPort.GetPortNames();
            foreach (var item in arrPort)
            {
                cboPortList.Items.Add(item);
            }
        }
        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPut_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //判断是否选择了串口
                if (cboPortList.SelectedIndex<0)//未选择返回值为0
                {
                    MessageBox.Show("串口未选择!");
                    return;
                }

                //开始根据串口实例LED对象
                player = new LEDPlayer(cboPortList.SelectedValue.ToString());

                string mes = this.txtLedText.Text.Trim();
                if (mes == "")
                {
                    MessageBox.Show("请填写您需要发送的信息!");
                    return;
                }

                string result = player.DisplayText(mes);
                if (result != "")
                {
                    MessageBox.Show(result);
                }
            }
            catch { }
           
        }
       
    }
}
