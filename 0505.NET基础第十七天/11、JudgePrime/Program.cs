using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_JudgePrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //12.用方法来实现：判断一个给定的整数是否为“质数”。
            //while (true)
            //{
            //    Console.WriteLine("请输入一个整数");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    bool b = IsPrime(n);
            //    Console.WriteLine(b);
            //    Console.ReadKey();
            //} 
            //13.用方法来实现：计算1 - 100之间的所有质数（素数）的和。

            int sum = GetPrimeSum();
            Console.WriteLine(sum);
            Console.ReadKey();                                  
        }
        /// <summary>
        /// 判断一个给定的整数是否为“质数”。
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //public static bool IsPrime()
        //{
        //    if (n<2)
        //    {
        //        return false;
        //    }
        //    else//n>=2
        //    {
        //        for (int i = 2; i <n; i++)
        //        {
        //            if (n%i==0)
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }
        //}

        /// <summary>
        /// 计算1 - 100之间的所有质数（素数）的和。
        /// </summary>
        /// <returns></returns>
        public static int GetPrimeSum()
        {
            int sum = 0;
            for (int i = 2; i <=100; i++)//外循环 判断从2到100之间
            {
                bool b = true;
                for (int j = 2; j <i; j++)
                {
                    if (i%j==0)//不是质数
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
