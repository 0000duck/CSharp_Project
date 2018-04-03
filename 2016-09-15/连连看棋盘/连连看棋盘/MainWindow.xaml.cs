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

namespace 连连看棋盘
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i=0;i<10;i++) {
                ColumnDefinition colDef = new ColumnDefinition();
                gridGame.ColumnDefinitions.Add(colDef);

                RowDefinition rowDef = new RowDefinition();
                gridGame.RowDefinitions.Add(rowDef);
            }

            Random random = new Random();
            //int i1=random.Next(0, 99);//生成一个>=0，<99的随机争数
            //int i2 = random.Next(3, 9);//生成一个>=3，<9的随机争数


            for (int i=0;i<10;i++) {
                for (int j=0;j<10;j++) {
                    //Button btn = new Button();
                    //btn.Content = i+","+j;

                    ////通过代码修改控件的Grid.row属性
                    //Grid.SetRow(btn,i);//i为btn设置什么样的值
                    //Grid.SetColumn(btn,j);

                    //gridGame.Children.Add(btn);

                    int imgName = random.Next(1,10);//生成一个>=1,<10的随机数
                    Image img = new Image();
                    //代码给Source属性赋值
                    img.Source = new BitmapImage(new Uri("Images/"+imgName+".png",UriKind.Relative));
                    Grid.SetRow(img,i);
                    Grid.SetColumn(img,j);
                    gridGame.Children.Add(img);
                }
            }
            //Button btn = new Button();
            //btn.Content = "hahaha!";
            //sp1.Children.Add(btn);
        }

        private void sp1_MouseEnter(object sender, MouseEventArgs e)
        {
            //Button btn = new Button();//动态创建控件对象
            //btn.Content = "我是新控件";
            //sp1.Children.Add(btn);//把控件加入容器父控件的Children
        }
    }
}
