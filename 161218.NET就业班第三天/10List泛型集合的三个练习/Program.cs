﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10List泛型集合的三个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、两个(List)集合{"a","b","c","d","e"}和{"d","e","f","g","h"},把这两个集合去除重复项合并成一个

            //集合初始化器    ？？对象初始化器
            //List<string> list1 = new List<string>() { "a", "b", "c", "d", "e" };
            //List<string> list2 = new List<string>() { "d", "e", "f", "g", "h" };

            ////让list1添加list2中的每个元素
            //for (int i = 0; i <list2.Count; i++)
            //{
            //    if (!list1.Contains(list2[i]))
            //    {
            //        list1.Add(list2[i]);
            //    }
            //}
            //foreach (string item in list1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //2、随机产生10个1-100之间的数放到list中,要求这10个数不能重复,并且都是偶数(添加10次,可能循环很多次)
            //List<int> list = new List<int>();
            //Random r = new Random();
            //for (int i = 0; i <10; i++)
            //{
            //    int rNumber = r.Next(1, 101);//[ ) 左闭右开区间
            //    if (!list.Contains(rNumber)&&rNumber%2==0)
            //    {
            //        list.Add(rNumber);
            //    }
            //    else//出现了奇数,或者集合里面之前出现了数字
            //    {
            //        i--;
            //    }                                
            //}
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();



            //把分拣奇偶数的程序用泛型实现。List<int>
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> listJi = new List<int>();
            List<int> listOu = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    listOu.Add(nums[i]);
                }
                else
                {
                    listJi.Add(nums[i]);
                }
            }

            //listJi.AddRange(listOu);//想要奇数在前就用奇数集合去加偶数集合反之亦然。

            //foreach (int item in listJi)
            //{
            //    Console.WriteLine(item);
            //}
            listOu.AddRange(listJi);
            foreach (int item in listOu)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
