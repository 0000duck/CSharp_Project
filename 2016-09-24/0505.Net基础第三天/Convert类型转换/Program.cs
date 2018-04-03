using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convert类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入一个数字，接受，并且向控制台打印用户输入的这个数字的2倍
            Console.WriteLine("请输入一个数字");
            //string strNumber = Console.ReadLine();
            //将用户输入的字符串转换成int或者double类型
            //简写代码 ,减少了一个变量
            double number =Convert.ToDouble(Console.ReadLine());//Console.ReadLine()负责接受用户的输入
            Console.WriteLine(number*2);
            Console.ReadKey();
           
        }
    }
}
