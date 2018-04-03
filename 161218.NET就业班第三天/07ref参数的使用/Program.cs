using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ref参数的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 5000;//salary是double类型 值类型 值类型传递的是5000 不是地址 要想变加ref
            JiangJin(ref salary);
            Console.WriteLine(salary);
            Console.ReadKey();
        }

        static void JiangJin(ref double s)
        {
            s += 500;
        }

        //static double JiangJin(double s)
        //{
        //    s += 500;
        //    return s;
        //}
    }
}
