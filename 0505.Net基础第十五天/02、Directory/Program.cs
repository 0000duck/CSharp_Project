using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _02_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            //File Path  FileStream  StreamReader  StreamWriter
            //Directory 操作文件夹 目录

            //创建文件夹
            //Directory.CreateDirectory(@"F:\a");
            //Console.WriteLine("创建成功");
            //Console.ReadKey();

            //删除文件夹
            //Directory.Delete(@"F:\a", true);
            //Console.WriteLine("删除成功");
            //Console.ReadKey();

            ////剪切文件夹
            //Directory.Move(@"c:\a", @"C:\Users\SpringRain\Desktop\new");
            //Console.WriteLine("剪切成功");
            //Console.ReadKey();

            //获得指定
            //string[] path= Directory.GetFiles(@"C:\Users\洪佳朋\Desktop\好乱啊","*.txt");
            //for (int i  = 0;  i < path.Length; i ++)
            //{
            //    Console.WriteLine(path[i]);                
            //}
            //Console.ReadKey();

            //获得指定文件夹下所有文件夹的全路径
            //string[] path = Directory.GetDirectories(@"C:\Users\洪佳朋\Desktop\好乱啊");
            //for (int i = 0; i < path.Length; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}
            //Console.ReadKey();

            //判断指定的文件夹是否存在
            //if (Directory.Exists(@"F:\a\b"))
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Directory.CreateDirectory(@"F:\a\b\" + i);
            //    }
            //}
            //Console.WriteLine("OK");
            //Console.ReadKey();

            //Directory.Delete(@"F:\a\b", true);
            //Console.WriteLine("ok");
            //Console.ReadKey();
        }
    }
}
