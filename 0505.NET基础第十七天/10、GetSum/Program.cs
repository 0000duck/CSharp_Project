using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_GetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //10.用方法来实现：计算1 - 100之间的所有整数的和。
            //11.用方法来实现：计算1 - 100之间的所有奇数的和。            
            Console.WriteLine(GetSum());
            Console.WriteLine(GetOddNumSum());
            Console.ReadKey();
        }
        /// <summary>
        /// 计算1 - 100之间的所有整数的和
        /// </summary>
        public static int GetSum()
        {
            int sum = 0;
            for (int i = 0; i <=100; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static int GetOddNumSum()
        {
            int sum = 0;
            for (int i = 1; i <=100; i+=2)
            {
                sum += i;
                //if (i%2!=0)
                //{
                //    sum += i;
                //}
            }
            return sum;
        }
    }
}
