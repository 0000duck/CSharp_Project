using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _07字符串的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //课上练习4：文本文件中存储了多个文章标题、作者，
            //标题和作者之间用若干空格（数量不定）隔开，每行一个，
            //标题有的长有的短，输出到控制台的时候最多标题长度10，如果超过10，
            //则截取长度8的子串并且最后添加“...”，加一个竖线后输出作者的名字。
            string path = @"C:\Users\洪佳朋\Desktop\ZigBee实验.txt";
            string[] contents=File.ReadAllLines(path,Encoding.Default);
            Console.ReadKey();
        }
    }
}
