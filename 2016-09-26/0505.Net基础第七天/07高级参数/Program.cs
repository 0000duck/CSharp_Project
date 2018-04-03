using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法 求一个数组的最大值、最小值、总和、平均值
            int[] numbers = {1,2,3,4,5,6,7,8,9 };
            //将要返回的4个值、放到一个数组中返回

            //int[] res = GetMaxMinSumAvg(numbers);
            //Console.WriteLine("最大值是{0},最小值是{1},总和是{2},平均值是{3}",res[0],res[1],res[2],res[3]);
            //Console.ReadKey();
            int max;
            int min;
            int sum;
            int avg;
            bool b;
            double d;
            string s;//out多余返回的值 把多余返回的值赋给左边
            Test(numbers,out max,out min,out sum,out avg,out b,out d,out s);

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.WriteLine(b);
            Console.WriteLine(d);
            Console.WriteLine(s);
            Console.ReadKey();

        }
        /// <summary>
        /// 计算一个数组的最大值、最小值、总和、平均值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        //public static int[] GetMaxMinSumAvg(int[] nums)
        //{
        //    int[] res = new int[4];
        //    //假设res[0] 最大值 res[1]最小值 res[2]总和 res[3]平均值
        //    res[0] = nums[0];//max
        //    res[1] = nums[0];//min
        //    res[2] = 0;//sum
        //    string name = "孙权";
        //    bool b = true;
        //    for (int i=0; i<nums.Length;i++)
        //    {
        //        //如果当前循环到的元素比我假定的最大值还要大
        //        if (nums[i]>res[0])
        //        {
        //            //将当前循环到的元素赋值给我们的最大值
        //            res[0] = nums[i];
        //        }
        //        //如果当前循环到的元素比我们假定的最小值还要小
        //        if (nums[i]<nums[1])
        //        {
        //            //将当前循环到的元素赋值给我们的最小值
        //            res[1] =nums[i];
        //        }
        //        res[2] += nums[i];
        //    }
        //    //平均值
        //    res[3] = res[2] / nums.Length;
        //    return res;
        //}
        /// <summary>
        /// 计算一个整数数组的最大值、最小值、总和、平均值
        /// </summary>
        /// <param name="nums">要求值得数组</param>
        /// <param name="max">多余返回的最大值</param>
        /// <param name="min">多余返回的最小值</param>
        /// <param name="sum">多余返回的总和</param>
        /// <param name="avg">多余返回的平均值</param>
        public static void Test(int[] nums, out int max,out int min,out int sum,out int avg,out bool b,out double d,out string s)
        {
            //out 参数要求在方法的内部必须为其赋值
            max = nums[0];
            min = nums[0];
            sum = 0;
            b = true;
            s = "123";
            d = 3.14;
            for (int i=0;i<nums.Length;i++)
            {
                if (nums[i]>max)
                {
                    max =nums[i];
                }
                if (nums[i]<min)
                {
                    min =nums[i];
                }
                sum += nums[i];                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
            }
            avg = sum / nums.Length;
        }
    }
}
