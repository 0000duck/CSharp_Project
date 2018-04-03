using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //可以将string类型 看做是char类型的一个只读数组
            string s = "abcdefg";
            //s[0]='b';不能这样做 因为是只读的
            //首先将字符串转换成char类型的数组
            char[] chs= s.ToCharArray();
            chs[0] = 'b';
            //将字符数组转换为我们的字符串
            s = new string(chs);

            //既然可以将string看做char类型的数组，所以我们可以通过下标去访问字符串中的某一个元素
            Console.WriteLine(s[0]);
            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
