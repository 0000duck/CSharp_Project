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

namespace WpfApplication6
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text == "admin" && pwdBoxPassword.Password == "123")
            {
                MessageBox.Show("密码正确");
            }
            else {
                MessageBox.Show("登录失败");
            }

            //可空(null)数据类型：引用数据类型。自定义类、string，大部分类都是。
            //不可空：值类型。int、boolean、decimal（数字）、DateTime（日期）等。

            string s = ""; //空字符串，但不是null。null：没有。//有字符串对象，代表s指向了长度为0的字符串
            //string s1 = null;//null表示没有指向对象 //没有字符串对象  //代表s1没有指向字符串
            MessageBox.Show(s.Length.ToString());
           //MessageBox.Show(s1.Length.ToString());

            //Dog d1 = null; //自定义类也是可以为null
            //int i = null; //int变量的值不能为null
            //数据库里面的int是可以为null的，C#里面的int是不可以为null的。所以微软才推出了可空的int类型
            //int? i1 = null;//在不可null类型后加?就可以null
            //DateTime? d1=null; 

            //int i1 = 5;
            //int? i2 = i1;//可以把int赋值给int？

            //int? i3 = null;
            //int i4 = i3;    //  不可以把int？赋值给int

            //int? i5 = 3;
            //int i6 = i5; 

            //int? i7 = 5;
            //int i8 = (int)i7;//保证没问题，编译通过把！

            //int? i9 = null;
            //int  i10=(int)i9;//编译没错，运行错误。

            //if (checkBox.IsChecked) //if要求boolean类型{
            //    MessageBox.Show();
            //}

            //bool? b = checkBox.IsChecked;
            //if ((bool)b) {
            //}

            //if ((bool)checkBox.IsChecked) //if要求bool类型{
            //    MessageBox.Show("选中了");

            if (checkBox.IsChecked==true) {
                MessageBox.Show("xuanzhong");
            }
        }

    }

    }
    //class Dog { }

