using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //进程类  alt+shift+
            //存储着我们当前正在运行的进程
            //Process[] pro= Process.GetProcesses();
            //foreach (var item in pro)
            //{
            //    //item.Kill();
            //    Console.WriteLine(item.ProcessName);
            //}

            //使用进程来打开应程序

            //Process.Start("calc");
            //Process.Start("notepad");
            //Process.Start("mspaint");//打开画图工具
            //Console.ReadKey();

            //使用进程来打开文件

            //封装我们要打开的文件 但是并不去打开这个文件
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\洪佳朋\Desktop\1.jpg");
            //创建进程对象
            Process pro = new Process();
            //告诉进程要打开的文件信息
            pro.StartInfo =psi;
            //调用函数打开
            pro.Start();
            Console.ReadKey();
        }
    }
}
