using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14_算术运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             练习1、
             某学生三门课成绩为,语文:90  数学:100  英语:100,编程求总分和平均分
             */
            //int chinese=90;
            //int math=100;
            //int english=100;
            //Console.WriteLine("你的总分是{0},平均分是{1}",chinese+math+english,(chinese+math+english)/3);
            //Console.ReadKey();

            /*
             练习2、
             计算半径为5的圆的面积和周长并打印出来.（pi为3.14）面积:pi*r*r; Perimeter(周长)
             */
            //int r = 5;
            //double pi = 3.14;
            //Console.WriteLine("该圆的面积是{0},周长是{1}",pi*r*r,2*pi*r);
            //Console.ReadKey();

            /*
             练习3、
             某商店T恤(T-shirt)的价格为35元/件,裤子(trousers)的价格为120元/条.小明在该店买了3件T恤和2条裤子,请计算并显示小明应该付多少钱?
             打8.8折后呢？
             */

            //int T_shirt = 35;
            //int trousers = 120;
            //int totalMoney = 3 * T_shirt + 2 * trousers;
            //Console.WriteLine(totalMoney);

            ////Console.WriteLine("小明应付{0}元，打完折后应付{1}", totalMoney, totalMoney * 0.88);
            //double realMoney = totalMoney * 0.88;
            //Console.WriteLine(realMoney);
            //Console.ReadKey();

            //练习4、下面代码的输出结果是什么?
            //int a = 10, b = 3;
            //int m = a % b;
            //double n = a / b;
            //Console.WriteLine(m);
            //Console.WriteLine(n);
            //Console.ReadKey();
            //m=1、n=3;

            //int number = 10;
            //double d = number;//自动类型转换 隐式类型转换（小的转大的）

            double d = 306.5;
            int n = (int)d;
            Console.WriteLine(n);
            Console.ReadKey();

            //double d = 303.6;    
        }
    }
}
