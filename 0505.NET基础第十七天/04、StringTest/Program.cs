using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.编写一个函数,接收一个字符串,把用户输入的字符串中的第一个字母转换成小写然后返回(命名规范  骆驼命名)
            //name s.SubString(0, 1)      s.SubString(1);
            Console.WriteLine("请输入一个字符串");
            string num = Convert(Console.ReadLine());
            Console.WriteLine(num);
            Console.ReadKey();

            //string num = "AAds";
            //string numNew = Convert(num);
            //Console.WriteLine(numNew);
            //Console.ReadKey();
        }
        /// <summary>
        /// 把用户输入的字符串中的第一个字母转换成小写然后返回
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string Convert(string num)
        {
            //方法.ToLower()转小写
            string input = num.Substring(0, 1).ToLower();//截出来的第一个字符   转大写 ToUpper();
            return input+num.Substring(1);
           
        }
    }
}
