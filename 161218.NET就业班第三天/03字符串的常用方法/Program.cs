using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03字符串的常用方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、判断字符串是否为空
            //string s = null;
            //if (string.IsNullOrEmpty(s))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //2、字符串的不可变性
            //要想修改字符串中的内容，可以将字符串转换成char类型的数组进行修改 然后再转回去
            //string str = "abcdefgh";
            ////str[5] = "d//无法这样改变字符串 因为它是只读的 只能读取、不能修改 但可以先转换为char类型的数组
            //Console.WriteLine(str[5]);
            //char[] chs= str.ToCharArray();//char数组是可读可写的
            //chs[2] = 'z';
            //foreach (char item in chs)
            //{
            //    Console.WriteLine(item);
            //}

            ////char数组-->字符串
            //str= new string(chs);
            ////3、将字符串转换成char[]类型的数组



            //4、转大小写
            //string str = "abcdEFGh";
            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.ToLower());

            //5、
            //==号是比的值 .Equals是比的引用
            //string s1 = "aBc";
            //string s2 = "Abc";
            //if (s1==s2)
            //{
            //    Console.WriteLine("相等");
            //}
            //else
            //{ 
            //    Console.WriteLine("不相等");
            //}
            //Console.ReadKey();

            //6、SubString
            //string str = "老毕吃了一顿饭,结果老毕火了";
            ////string strNew = str.Substring(1,2);
            //int index=str.IndexOf(",");
            //string strNew = str.Substring(index+1);//截取逗号后面到末尾
            //Console.WriteLine(strNew);


            //string str = "张  ,,--三   ,李,,--四  a  ";
            //string[] strNew= str.Split(new char[] { '-', ' ', ',' },StringSplitOptions.RemoveEmptyEntries);
            ////字符串-->char类型的数组 ToCharArray();
            ////字符串-->string类型的数组 Splite

            ////字符串数组转换为字符串

            //Console.ReadKey();



            //Trim() TrimEnd() TrimStart()

            //string s = "   张   ,,,--    三 ,,,--   ";

            //Console.Write(s.Trim(' ',',','-'));


            //string[] names = { "金秀贤", "金贤秀", "金正日", "金正恩" };
            ////金秀贤|金贤秀|金正日|金正恩

            //string res = string.Join("|", 'c', "张三", 100, 3.14, true, 5000m);
            //Console.WriteLine(res);
            //Console.ReadKey();
            //string res = string.Empty;
            //for (int i = 0; i < names.Length - 1; i++)
            //{
            //    res += names[i] + "|";
            //}
            //Console.WriteLine(res + names[names.Length - 1]);

            Console.WriteLine("请输入你要回复的内容");
            string contents = Console.ReadLine();
            //判断contents中是否包含敏感词
            if (contents.Contains("老赵"))
            {
                contents = contents.Replace("老赵", "****");
            }
            Console.WriteLine(contents);
            Console.ReadKey();
        }
    }
}
