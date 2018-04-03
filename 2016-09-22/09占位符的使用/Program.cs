using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09占位符的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //[9]上午内容回顾·
            //1、赋值运算符
            //2、数据类型
            //int double decimal string char
            //3、命名规范
            //Camal: 骆驼命名规范。多用于给变量命名。要求变量名首单词的首字母要小写，其余每个单词的首字母要大写。
            //Pascal:要求每个单词的首字母都要大写，其余字母小写。多用于给类或者方法命名。
            //4、注释
            //5、+号

            //[10]占位符
            //使用方法:先挖个坑，再填个坑
            //使用占位符需要注意的地方：
            //1、你挖几个坑，就应该填几个坑，如果你多填了，没效果。
            //                               如果你少填了，抛异常。
            //2、输出顺序：按照挖坑的顺序输出。

            //练习1
            //int a1 = 10;
            //int a2 = 20;
            //int a3 = 30;
            //Console.WriteLine("第一个数字是{0},第二个数字是{1},第三个数字是{2}", a1, a2, a3);
            ////Console.WriteLine("第一个数字为:"+a1+"，第二个数字为:"+a2+",第三个数字为:"+a3);
            //Console.ReadKey();

            //练习2
            //有个叫卡卡西的人在旅店登记的时候前台让他填一张表,
            //这张表的里的内容要存到电脑上,有姓名、年龄、邮箱、家庭住址,工资.之后把这些信息显示出来
            //我叫卡卡西，我住在火影村，我今年30了我的邮箱是kakaxi @qq.com，我的工资2000.

            //string name = "卡卡西";
            //int age = 30;
            //string email = "kakaxi@qq.com";
            //string address = "火影村";
            //decimal salary = 2000m;
            //Console.WriteLine("我叫{0},我住在{1},我今年{2}了,我的邮箱是{3},我的工资{4}",name,address,age,email,salary);
            //Console.ReadKey();

            //[11]异常
            //异常是指：语法上并没有任何错误，只不过在程序运行的期间，
            //由于某些原因出现了问题，使程序不能再正常的运行。

            //作业3
            /*
             定义四个变量,分别存储一个人的姓名、性别(Gender)、年龄、电话(TelephoneNumber)。
             然后打印在屏幕上 (我叫X,我今年 X岁了,我是X生,我的电话是XX)(电话号用什么类型,如:010-12345)
             */
            string name2 = "洪佳朋";
            char gender = '男';
            int age2 = 20;
            string tel = "17853522857";
            Console.WriteLine("我叫{0},我今年{1}岁了,我是{2}生,我的电话是{3}",name2,age2,gender,tel);
            Console.ReadKey();

            
        }
    }
}
