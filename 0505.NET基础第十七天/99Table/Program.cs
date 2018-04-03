using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _99Table
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 打印矩形           
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <8; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion

            #region 打印正△
            //for (int i = 0; i<5; i++)
            //{
            //    for (int j = 0; j <=i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion

            #region 打印99乘法表1
            //for (int i = 1; i <=9; i++)
            //{
            //    for (int j = 1; j <=9; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t",i,j,i*j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion

            #region 打印99乘法表2△
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            #endregion
        }

    }
}
