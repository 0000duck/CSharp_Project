using Microsoft.Win32;
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

namespace 多窗口案例
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
            InputWindow inputWin = new InputWindow();
            bool? b = inputWin.ShowDialog();
            if (b == null)
            {
                MessageBox.Show("未设置");
            }
            else if (b==true)
            {
                MessageBox.Show("确定"+inputWin.InputValue);
            }
            else
            {
                MessageBox.Show("取消");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {


            //MessageBoxResult r1= MessageBox.Show("确定还是取消?","提示",MessageBoxButton.OKCancel);
            //if (r1==MessageBoxResult.OK)
            //{
            //    MessageBox.Show("ok啦");
            //}
            //else if (r1==MessageBoxResult.Cancel)
            //{
            //    MessageBox.Show("取消了");
            //}

            MessageBoxResult r2= MessageBox.Show("真的要删除吗?","警告",MessageBoxButton.YesNo);
            if (r2==MessageBoxResult.Yes)
            {
                MessageBox.Show("删的干净");
            }
            else if (r2==MessageBoxResult.No)
            {
                MessageBox.Show("多亏没删");
            }
        }

        private void btnDialogTest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("确定还是取消?","提示",MessageBoxButton.YesNoCancel);
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件|*.txt|图片|*.jpg|视频|*.avi|所有文件|*.*";
            if (ofd.ShowDialog()==true)
            {
                MessageBox.Show("打开文件" + ofd.FileName);
            }
            else
            {
                MessageBox.Show("取消了");
            }
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "文本文件|*.txt|word文档|*.docx";
            if (sfd.ShowDialog()==true)
            {
                //会自动增加后缀名           
                MessageBox.Show(sfd.FileName);
                                            
            }                
        }

        private void btnSelectImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG图片|*.jpg|PNG图片|*.png|所有文件|*.*";
            if (ofd.ShowDialog()==true)
            {
                string imageFileName = ofd.FileName;
                image.Source = new BitmapImage(new Uri(imageFileName));
            }
        }
    }
}

                