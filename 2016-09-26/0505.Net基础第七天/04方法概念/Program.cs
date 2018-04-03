using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04方法概念
{
    class Program
    {
        //不管是实参还是形参，都是在内存中开辟了空间的。
        static void Main(string[] args)
        {
            //比较两个数字的大小 返回最大的
            int a = 10;
            int b = 12;
            int max = GetMax(a,b);//实参
            Console.WriteLine(max);
            Console.ReadKey();
        }
        /// <summary>
        /// 计算两个整数之间的最大值 并且返回最大值
        /// </summary>
        /// <param name="a">第一个数</param>
        /// <param name="b">第二个数</param>
        /// <returns>返回的最大值</returns>
        public static int GetMax(int a,int b)//形参
        {
           int max= a > b ? a : b;
            return max;
        }
    }
}
