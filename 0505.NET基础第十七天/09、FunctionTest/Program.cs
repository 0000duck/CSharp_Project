using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_FunctionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.用方法来实现：计算两个数的最大值。思考：方法的参数？返回值？
            //扩展（*）：计算任意多个数间的最大值（提示：params）。

            //Console.WriteLine("请输入第一个整数");
            //int a= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个整数");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int max = GetMax(a,b);
            //Console.WriteLine(max);
            //Console.ReadKey();

            //计算数组的最大值
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int max = GetMax(1,2,3);
            Console.WriteLine(max);
            Console.ReadKey();
        }
        /// <summary>
        /// 计算数组的最大值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int GetMax(params int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                }                
            }
            return max;
        }

        /// <summary>
        /// 获取两个数的最大值
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
