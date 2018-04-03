using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = string.Empty;
            //StringBuilder sb = new StringBuilder();
            ////00:00:00.0361319
            //Stopwatch sp = new Stopwatch();
            //sp.Start();
            //for (int i = 0; i <100000; i++)
            //{
            //    sb.Append(i);
            //}
            //sp.Stop();

            //Console.WriteLine(sp.Elapsed);
            //Console.WriteLine(sb.ToString());
            //Console.ReadKey();

            StringBuilder sb = new StringBuilder();
            sb.Append("张三");
            sb.Append("李四");
            sb.Append("王狗蛋");
            sb.Insert(1,"新来的");
            sb.Replace("王狗蛋","***");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
