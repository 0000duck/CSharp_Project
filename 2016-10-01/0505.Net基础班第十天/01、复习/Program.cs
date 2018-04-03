using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson = new Person("张三",-19,'中');
            //new干了什么事：
            //1、在内存中开辟了空间
            //2、在开辟的空间里创建对象
            //3、调用对象的构造函数
            zsPerson.SayHello();
            Console.ReadKey();
        }
    }
}
