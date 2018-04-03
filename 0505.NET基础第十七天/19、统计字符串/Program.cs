using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_统计字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //19.有如下字符串：【"患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”   
            //   患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。” 
            //   大夫：“那现在不咳嗽，还要等到什么时咳嗽？”"】。需求：请统计出该字符中“咳嗽”二字的出现次数，以及每次“咳嗽”出现的索引位置。

            //string str =  "患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”" ;
            //int index= str.IndexOf("咳嗽");
            //int i = 1;
            //Console.WriteLine("第1次出现咳嗽的位置是{0}",index);
            //while (index!=-1)
            //{
            //    i++;
            //    index = str.IndexOf("咳嗽",index+1);
            //    if (index==-1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("第{0}次找到咳嗽的位置是{1}",i,index);
            //}
            //Console.ReadKey();

            //20.将字符串"  hello      world,你  好 世界   !    "
            //两端空格去掉，并且将其中的所有其他空格都替换成一个空格，输出结果为："hello world,你 好 世界 !"。
            string s = "  hello      world,你  好 世界   !    ";
            s= s.Trim();//两端空格去掉
            string[] sNew= s.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            string strNew = string.Join(" ",sNew);
            Console.WriteLine(strNew);
            Console.ReadKey();
        }
    }
}
