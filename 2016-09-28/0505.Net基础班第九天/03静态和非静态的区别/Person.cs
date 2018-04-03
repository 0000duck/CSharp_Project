using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03静态和非静态的区别
{
    public class Person
    {
        private static string _name;

        public static string Name
        {
            get { return Person._name; }
            set { Person._name = value; }
        }

        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public void M1()
        {
            //_name、Name 
            //_gender、Gender
            //实例方法中既可以使用静态成员 又可以使用非静态成员
            Console.WriteLine("我是非静态的方法");
        }
        public static void M2()
        {
            Console.WriteLine("我是静态的方法");
            
        }
        
    }
}
