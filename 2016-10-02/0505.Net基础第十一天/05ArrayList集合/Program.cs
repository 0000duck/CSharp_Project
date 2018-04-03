using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建了一个集合对象
            ArrayList list = new ArrayList();
            //集合：很多数据的一个集合
            //数组：长度不可变、类型单一
            //集合的好处：长度可以任意改变、类型随便
            list.Add(1);
            list.Add(3.14);
            list.Add(true);
            list.Add("张三"); 
            list.Add('男');
            list.Add(500m);

            list.Add(new int[] {1,2,3,4,5,6,7,8,9 });
            Person p = new Person();
            list.Add(p);
            list.Add(list);
            for (int i = 0; i < list.Count; i++)
            {
                //如果能够把list[i]转换成Person
                if (list[i] is Person)
                {
                    ((Person)list[i]).SayHello();
                }
                else if (list[i] is int[])
                {
                    for (int j = 0; j < ((int[])list[i]).Length; j++)
                    {
                        Console.WriteLine();
                    }
                }
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
}
