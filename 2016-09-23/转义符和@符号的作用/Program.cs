using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 转义符和_符号的作用
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "今天天气好晴\r\n朗处处好风光";
            System.IO.File.WriteAllText(@"C:\Users\洪佳朋\Desktop\1111.txt",str);
            Console.WriteLine("写入成功!");
            Console.ReadKey();

        }
    }
}
