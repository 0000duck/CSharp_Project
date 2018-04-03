using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01语法复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1使用进程打开指定文件 Process进程类
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\洪佳朋\Desktop\青春.txt");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            Console.ReadKey();
        }
    }
}
