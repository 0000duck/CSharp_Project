using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s;
            //Person sunQuan;//自定义类
            //创建一个Person类对象
            Person sunQuan = new Person();
            sunQuan.Name = "孙权";
            sunQuan.Age = -23;
            sunQuan.Gender = '春';
            sunQuan.CHLSS();
            Console.ReadKey();
        }
    }
}
