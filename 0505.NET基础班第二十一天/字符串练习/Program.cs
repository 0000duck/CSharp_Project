using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串就是char类型的只读 数组
            //string s1 = "张三";//GC
            //s1 = null;
            //if (string.IsNullOrEmpty(s1))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}

            //string s = "abcdefg";
            //char[] chs = s.ToCharArray();
            //chs[0] = 'b';
            //s = new string(chs);
            //Console.WriteLine(s);
            ////s[0]='b';
            //Console.WriteLine(s[0]);
            //Console.ReadKey();

            //string s1 = "c#";
            //string s2="C#";
            //if (s1.Equals(s2,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("相同");
            //}
            //else
            //{
            //    Console.WriteLine("不相同");
            //}
            //Console.ReadKey();

            //string s = "abcdefg";
            //string sNew = s.Substring(3,1);
            //Console.WriteLine(sNew);
            //Console.ReadKey();

            string str = "abcd , , fd, fdafd   [[  ---";
            string[] strNew = str.Split(new char[] { ',', ' ', '[', '-' }, StringSplitOptions.RemoveEmptyEntries);
            //Split();()内第一个参数 把你要截取的这个字符放到这个字符数组中。第二个参数 字符串截取选项 空项全部移除
            //如果将一个字符串变成一个字符类型的数组的话 用toCharArray
            //如果将一个字符转换成一个字符串数组的话 首先考虑Split()
            Console.WriteLine(strNew);
            Console.ReadKey();

            //string[] names = { "张三", "李四", "王五", "赵六" };
            //string s = string.Join("|",'c',true,3.13,100,1000m,"张三");
            //Console.WriteLine(s);
            //Console.ReadKey();

            //string str = "老赵伟大";
            //str = str.Replace("老赵", "**");


        }
    }
}
