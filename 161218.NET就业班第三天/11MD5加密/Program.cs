using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _11MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //在数据库 张三abc  abc123

            //string str = "123";
            //string s="202cb962ac59075b964b07152d234b70";
            //Console.WriteLine(s.Length);
            while (true)
            {
                Console.WriteLine("请输入您要加的字符串");
                string count = Console.ReadLine();
                string md5Str = GetMD5(count);
                Console.WriteLine("你要加密的内容的MD5值为:");
                Console.WriteLine(md5Str);
                Console.ReadKey();
            }            
           
        }

        static string GetMD5(string str)
        {
            //拿到MD5对象
            MD5 md5 = MD5.Create();
            //根据加密函数要求需将字符串转换为字节数组
            byte[] buffer= Encoding.Default.GetBytes(str);
            //开始加密 返回加密好的字节数
            byte[] bufferMd5=md5.ComputeHash(buffer);
            //字节数组转成字符串
            //string result = Encoding.Default.GetString(bufferMd5);
            //return result;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <bufferMd5.Length; i++)
            {
                sb.Append(bufferMd5[i].ToString("x2"));//x:十进制转十六进制
            }
            return sb.ToString();
        }
    }
}
