using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _15进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //获得当前程序中所有的正在运行的进程
            //Process[] pros= Process.GetProcesses();
            //foreach (var item in pros)
            //{
            //    //不试的不是爷们
            //    //item.Kill();
            //    Console.WriteLine(item);
            //}

            //通过进程打开一些应用程序
            //Process.Start("calc");
            //Process.Start("mspaint");
            //Process.Start("notepad");
            //Process.Start("iexplore","https://www.baidu.com");    

            //通过进程打开一个指定的文件

            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\洪佳朋\Desktop\11PictureBox和Timer的练习.exe");
            //创建进程对象
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            Console.ReadKey();
        }
    }
}
