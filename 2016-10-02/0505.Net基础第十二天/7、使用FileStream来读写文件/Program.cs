using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _7_使用FileStream来读写文件
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //学习.Net就是学习这些类怎么去使用
            //File是一次读完（小文件）、FileStream是一点点的读（大文件）
            //FileStream  操作字节的（可以操作任何类型的文件）
            //StreamReader和StreamWriter   操作字符的（字符串。文本文件）

            //使用FileStream来读取数据
            //1、创建FileStream对象
            FileStream fsRead = new FileStream(@"C:\Users\洪佳朋\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024 * 5];//每次只读5M  //把数据读完后放到一个字节数组里（就是通过这种方式去限定每次只能读多少，就不会一次性的全读回来）
            //3.8M  5M
            //r是返回本次实际读取到的有效字节数           
            int r = fsRead.Read(buffer, 0, buffer.Length);
            //但是现在数据都在字节数组里面，你需要将字节数组里面每一个元素按照你指定的编码格式解码成字符串
            string s = Encoding.Default.GetString(buffer, 0, r);
            //关闭流
            fsRead.Close();
            //释放柳所占的资源
            fsRead.Dispose();
            Console.WriteLine(s);
            Console.ReadKey();

            //使用FileStream来写入数据
            //using (FileStream fsWrite = new FileStream(@"C:\Users\洪佳朋\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    string str = "看我有没有把你覆盖";
            //    byte[] buffer = Encoding.Default.GetBytes(str);
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}
            //Console.WriteLine("写入ok");
            //Console.ReadKey();
        }
    }
}
