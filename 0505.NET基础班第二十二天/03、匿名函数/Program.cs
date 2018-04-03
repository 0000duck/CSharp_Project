﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_匿名函数
{
    public delegate void DelSayHi(string name); 
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("张三",SayHiChinese);
            Console.ReadKey(); 
        }

        public static void SayHi(string name,DelSayHi del)
        {
            del(name);
        }
        public static void SayHiChinese(string name)
        {
            Console.WriteLine("您好"+name);
        }
        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("nice to meet you"+name);
        }
    }
}
