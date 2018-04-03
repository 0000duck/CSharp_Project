using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {

            //int n1 = 10;
            //int n2 = 3;
            ////double d = n1 / n2;//整数类型加、减、乘、除、取余，整数结果依然是整数类型，哪怕赋值给小数类型。（相当于把一个小的赋值给一个大的（隐式类型转换））
            //double d = n1 * 1.0 / n2;//将一个整数类型的的数提升为double类型的数
            //Console.WriteLine(d);
            //Console.ReadKey();

            int n3 = 10;
            int n4 = 3;
            double db = n3*0.1 / n4;
            Console.WriteLine("{0:0.00}", db);//保留两位小数的写法
            Console.ReadKey();
            
        }
    }
}
