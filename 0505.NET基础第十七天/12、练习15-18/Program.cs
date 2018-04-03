using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12_练习15_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //15.用方法来实现：有一个字符串数组：
            //{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },
            //请输出最长的字符串。
            //string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string max = GetLongString(names);
            //Console.WriteLine(max);
            //Console.ReadKey();

            //16.用方法来实现：请计算出一个整型数组的平均值。{ 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 }。
            //   要求：计算结果如果有小数，则显示小数点后两位（四舍五入）。
            //int[] nums = { 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 };
            //double avg = GetAvg(nums);
            ////方法1 改变原值
            //avg = Convert.ToDouble(avg.ToString("0.00"));
            //Console.WriteLine(avg);
            ////方法2 没有改变原值
            //Console.WriteLine("{0:0.00}",avg);
            //Console.ReadKey();



        }
        /// <summary>
        /// 输出最长的字符串。
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        //public static string GetLongString(string[] names)
        //{

        //    string max = names[0];
        //    for (int i = 0; i <names.Length; i++)
        //    {
        //        if (names[i].Length>max.Length)
        //        {
        //            max = names[i];
        //        }
        //    }
        //    return max;
        //} 

        
        //public static double GetAvg(int[] nums)
        //{
        //    double sum = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        sum += nums[i];
        //    }
        //    return sum/nums.Length;
        //}
    }
}
