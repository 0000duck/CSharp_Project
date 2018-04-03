using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //17.请通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }
            //实现升序排序。
            int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //Console.WriteLine(Array.Sort(nums));
            Array.Sort(nums);//升序
            Array.Reverse(nums);//翻转
            Console.ReadKey();
            //for (int i = 0; i < nums.Length-1; i++)
            //{
            //    for (int j = 0; j < nums.Length-1-i; j++)
            //    {
            //        if (nums[j]<nums[i])
            //        {
            //            int temp = nums[i];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();
        }
    }
}
