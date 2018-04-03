using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09集合的两个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个集合，里面添加一些数字，求平均值与和,最大值、最小值
            //ArrayList list = new ArrayList();
            //list.AddRange(new int[] {1,2,3,4,5,6,7,8,9,10 });
            //int sum = 0;
            //int max = (int)list[0];          
            //for (int i = 0; i <list.Count; i++)
            //{              
            //    sum += (int)list[i];//将list[i]强转成int类型 。
            //                        //1、因为object类是int类型的父类  
            //                        //2、虽然表现出来的是object类型，但是你里面装的是int子类型，符合里氏转换。父类里面装的是子类对象，所以能把父类强转成子类
            //    if ((int)list[i] > max)
            //    {
            //        max = (int)list[i];
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(sum/list.Count);
            //Console.WriteLine(max);
            //Console.ReadKey();

            //写一个长度为10的集合，要求在里面随机地存放10个数字（0-9），
            //但是要求所有的数字不重复

            ArrayList list = new ArrayList();
            Random r = new Random();
            for (int i = 0; i < 10; i++)//  Count表示实际包含的元素个数  list.Count现在是0
            {
                int rNumber = r.Next(0,10);
                //集合中没有这个随机数
                if (!list.Contains(rNumber))
                {
                    list.Add(rNumber);
                }
                else//集合中有这个随机数
                {
                    //一旦产生了重复的随机数 这次循环就不算数
                    i--;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
            
        }
    }
}
