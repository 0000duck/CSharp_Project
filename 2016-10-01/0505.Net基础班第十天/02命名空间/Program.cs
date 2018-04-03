using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _01_复习;
namespace _02命名空间
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alt+Shift+F10 快速添加命名空间
            List<int> list = new List<int>();
            //类是属于命名空间的
            //A---->ProjectA---顾客类
            //B---->ProjectB---顾客类
            //C---->ProjectC---顾客类

            Person zsPerson = new Person();
            zsPerson.Name = "张三";
            Console.WriteLine(zsPerson.Name);
            Console.ReadKey();
        }
    }
}
