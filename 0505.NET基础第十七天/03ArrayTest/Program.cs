using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.定义长度50的数组,随机给数组赋值,并可以让用户输入一个数字n,按一行n个数输出数组
            //int[] array = new int[50]; Random r = new Random(); r.Next();
            int[] nums = new int[50];
            Random r = new Random();
            for (int i = 0; i <nums.Length; i++)
            {
                int rNumber = r.Next(0,10);
                nums[i] = rNumber;
            }
            Console.WriteLine("请输入一个数字");
            int n= Convert.ToInt32(Console.ReadLine() );
            for (int i = 0; i <nums.Length; i++)
            {
                Console.Write(nums[i]+"\t");
                if ((i+1)%n==0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
