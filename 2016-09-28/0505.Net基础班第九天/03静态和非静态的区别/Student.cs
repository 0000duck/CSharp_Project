using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03静态和非静态的区别
{
    //静态类当中只允许出现静态成员
    public static class Student
    {
        private static string _name;
        public static string Name
        {
            get { return Student._name; }
            set { Student._name = value; }
        }
        public static void M1()
        {
            Console.WriteLine("hello world");
        }
       
        //private int _age;  “Student._age”: 不能在静态类中声明实例成员	
        //静态类中只允许有静态成员，不允许有非静态成员
    }
}
