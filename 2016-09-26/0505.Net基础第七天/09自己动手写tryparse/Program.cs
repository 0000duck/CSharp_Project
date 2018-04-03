﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09自己动手写tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;//这个num的值是从方法里多余返回来的
            bool b = int.TryParse("123abc",out num);
            Console.WriteLine(num);
            Console.WriteLine(b);
            Console.ReadKey();
        }

        public static bool MyTryParse(string s, out int result)
        {
            result = 0;
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
