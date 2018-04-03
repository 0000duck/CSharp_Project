using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_多播委托
{
    //委托不仅仅可以指向一个函数 还可以指向多个函数
    public delegate void DelTest();
    class Program
    {
        static void Main(string[] args)
        {
            DelTest del = T1;
            del += T2;
            del += T3;
            del += T4;
            del -= T3;
            del -= T1;
            del();
            Console.ReadKey();
        }

        public static void T1()
        {
            Console.WriteLine("我是T1");
        }
        public static void T2()
        {
            Console.WriteLine("我是T2");
        }

        public static void T3()
        {
            Console.WriteLine("我是T3");
        }
        public static void T4()
        {
            Console.WriteLine("我是T4");
        }

    }
}
