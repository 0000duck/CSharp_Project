using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10变量的交换
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1、面试题：
             交换两个int类型的变量,要求不使用第三方变量
             */

            //int a = 10;
            //int b = 20;

            //int temp = a;
            //a = b;
            //b = temp;

            //Console.WriteLine("交换后，a的值是{0},b的值是{1}",a,b);
            //Console.ReadKey();

            int a = 10;
            int b = 20;
            //分析：最终结果： a=20,b=10;

            a = a - b;//a=-10.b=20
            b = a + b;//a=-10,b=10;
            a = b - a;//a=20,b=10;
            Console.WriteLine("交换后，a的值是{0},b的值是{1}", a, b);
            Console.ReadKey();


        }
    }
}
