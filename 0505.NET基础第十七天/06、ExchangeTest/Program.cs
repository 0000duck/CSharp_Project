using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_ExchangeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.声明两个变量：int n1 = 10, n2 = 20;
            //要求将两个变量交换，最后输出n1为20,n2为10。扩展（*）：不使用第三个变量如何交换？
            int n1 = 10;
            int n2 = 20;
            //int temp=n1;
            //n1 = n2;
            //n2 = temp;

            //n1 = n1 - n2;//n1=-10  n2=20
            //n2 = n1 + n2;//n1=-10  n2=10
            //n1 = n2 - n1;
            Exchange(ref n1,ref n2);
            Console.WriteLine("n1={0},n2={1}",n1,n2);
            Console.ReadKey();
        }

        public static void Exchange(ref int n1,ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
