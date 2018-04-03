using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06字符串的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //练习一:随机输入你心中想到的一个名字，然后输出它的字符串长度  Length:可以得字符串的长度
            //Console.WriteLine("请输入你心中想的那个人的名字");
            //string name = Console.ReadLine();
            //Console.WriteLine("你心中想的人的名字的长度是{0}",name.Length);//Length是字符串的一个属性：获得当前字符串字符的个数
            //Console.ReadKey();

            //练习二:两个学员输入各自最喜欢的课程名称，判断是否一致,如果相等,则输出你们俩喜欢相同的课程.
            //如果不相同,则输出你们俩喜欢不相同的课程.
            Console.WriteLine("请输入你最喜欢的课程");
            string lessonOne = Console.ReadLine();
            //将字符串转换成大写
            //lessonOne=lessonOne.ToUpper();
            //将字符串转换成小写
            //lessonOne = lessonOne.ToLower();
            Console.WriteLine("请输入你最喜欢的课程");
            string lessonTwo = Console.ReadLine();
            //将字符串转换成大写
            //lessonTwo = lessonTwo.ToUpper();
            //将字符串转换成小写
            //lessonTwo = lessonTwo.ToLower();
            //if (lessonOne == lessonTwo)
            if(lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("你们俩喜欢相同的课程");
            }
            else
            {
                Console.WriteLine("你们俩喜欢不相同的课程");
            }
            Console.ReadKey();

            */

            //字符串的分割
            //string s = "a b  dfd _  +  =,,, fdf";
            ////分割字符串Split
            //char[] chs = {' ','_','+','=',','};
            //string[] str= s.Split(chs,StringSplitOptions.RemoveEmptyEntries);
            //Console.ReadKey();


            //练习：从日期字符串（"2008-08-08"）中分析出年、月、日；2008年08月08日。
            //让用户输入一个日期格式如: 2008 - 01 - 02,你输出你输入的日期为2008年1月2日

            //string s = "2008-08-08";
            ////char[] chs = {'_'};
            //string[] date=s.Split(new char[] {'_'},StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日",date[0],date[1],date[2]);
            //Console.ReadKey();

            /*
            //小洪
            string str = "国家关键人物小洪";
            if (str.Contains("小洪"))
            {
               str= str.Replace("小洪","**");
            }
            Console.WriteLine(str);
            Console.ReadKey();
            */

            /*
            //Substring 截取字符串
            string str = "今天天气好晴朗，处处好风光";
            str=str.Substring(1,2);
            Console.WriteLine(str);
            Console.ReadKey();
            */

            /*
            string str = "今天天气好晴朗，处处好风光";
            if (str.StartsWith("今天天气好晴朗"))
            {
                Console.WriteLine("是的");
            }
            else
            {
                Console.WriteLine("不是的");
            }
            Console.ReadKey();
            */

            /*
            string str = "今天天气好晴朗，天天处处好风光";
            int index=str.IndexOf('天',2);
            Console.WriteLine(index);
            Console.ReadKey();
            */

            /*  
            //最后一次出现的位置
            string str = "今天天气好晴朗，处处好风光";
            int index=str.LastIndexOf('天');
            Console.WriteLine(index);
            Console.ReadKey();
            */


            //LastIndexof Substring
            //string path = @"c:\a\b\c苍\d\e苍\f\g\\fd\fd\fdf\d\vfd\苍老师苍.wav";
            //int index = path.LastIndexOf("\\");// \\代表\
            //path = path.Substring(index + 1);
            //Console.WriteLine(path);
            //Console.ReadKey();


            // string str = "            hahahah          ";
            //// str = str.Trim();
            // //str = str.TrimStart();
            // str = str.TrimEnd();
            // Console.Write(str);
            // Console.ReadKey();

            //string str = "fdsfdsfds";
            //if (string.IsNullOrEmpty(str))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}


            //string[] names = { "张三", "李四", "王五", "赵六", "田七" };
            ////张三|李四|王五|赵六|田七
            //string strNew = string.Join("|", "张三","李四","王五","赵六","田七");
            //Console.WriteLine(strNew);
            //Console.ReadKey();

        }
    }
}
