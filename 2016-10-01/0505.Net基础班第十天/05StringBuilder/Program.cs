using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _05StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string str = null;
            //创建了一个计时器，用来记录程序运行的时间
            //00:00:00.0255206
            //StringBuilder在内存中没开空间,所以快
            Stopwatch sw = new Stopwatch();
            sw.Start();//开始计时
            for (int i=0; i<100000;i++)
            {
                //str += i;
                sb.Append(i);//Append追加 += 的意思
            }
            sw.Stop();//结束计时
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sw.Elapsed);//
            Console.ReadKey();
        }
    }
}
