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

namespace WpfApplication4
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
            //  Dog dog = new Dog();
            //  dog.buck();
            
            Dog dog = new Dog();
            Animal al = dog;//变量是一个标签，对象是一个实际存在的东西
            //=就是给实在的东西贴标签的过程 
            //把父类的变量指向一个子类的对象
            
            
            //一箱子苹果。 苹果。水果。食物，金属

            //Animal a = new Animal();
            //Dog d1 = a;

            Animal a1 = new Dog();//new是创建对象的过程，把Animal动物的标签贴到对象上
            //Dog d1 = a1;
            Dog d2 =(Dog)a1;//放心吧贴到的是狗
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //int[] nums = new int[3];
            //nums[0] = 333;
            //nums[1] = 555;
            //nums[2] = 233232;

            //foreach (int i in nums)
            //{
            //    MessageBox.Show(i.ToString());//因为show()方法的参数是string类型的，int也是string类型的，所以需要调用tostring方法把它转换一下
            //}


            //List<int> list = new List<int>();//list长度不固定
            //list.Add(333);
            //list.Add(3232);
            //list.Add(5444);
            //list.Add(4324343);
            //foreach (int i in list) {
            //    MessageBox.Show(i.ToString());
            //}

            //string[] str = new string[33];

            List<string> list2 = new List<string>();
            list2.Add("asadjada");
            list2.Add("abc");
            list2.Add("hjp");


            MessageBox.Show(list2.Count.ToString());
            list2.Remove("hjp");
            MessageBox.Show(list2.Count.ToString());
            list2.Clear();
            MessageBox.Show(list2.Count.ToString());

            //List<Dog> list = new List<Dog>();
            //list.Add(new Dog());
            //把list理解为动态的数组
        }
    }
}
