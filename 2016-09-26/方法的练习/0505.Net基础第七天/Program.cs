using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05方法的练习
{
    /*
     1 读取输入的整数，定义成方法，多次调用(如果用户输入的是数字,则返回,否则提示用户重新输入)
     2 还记得学循环时做的那道题吗?只允许用户输入y或n,请改成方法
     3查找两个整数中的最大值：int Max(int i1,int i2)
     4计算输入数组的和：int Sum(int[] values) 
     */
    class Program
    {
        static void Main(string[] args)
        {
            //比较两个数的大小 返回最大的
            //int a1 = 10;
            //int a2 = 25;
            //int result=GetMax(12,21);//实参
            //Console.WriteLine(result);
            //Console.ReadKey();

            //1 读取输入的整数，定义成方法，多次调用(如果用户输入的是数字,则返回,否则提示用户重新输入)
            /*
             * 分析：一旦涉及到重新输入，肯定得用到循环
             */
            while (true)
            {
                Console.WriteLine("请输入一个数");
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(number);
                    break;
                }
                catch
                {
                    Console.WriteLine("输入有误!!!");
                }
                
                
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 方法练习:1、计算两个整数之间的最大值 并且返回最大值
        /// </summary>
        /// <param name="a">第一个数</param>
        /// <param name="b">第二个数</param>
        /// <returns>返回的最大值</returns>
        public static int GetMax(int a, int b)//形参
        {
            int max = a > b ? a : b;
            return max;
        }
    }
}
