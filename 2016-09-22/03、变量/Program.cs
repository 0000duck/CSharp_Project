using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //变量类型 变量名;
            //变量名=值;
            //100

            //官方语言：声明或者定义了一个int类型的变量
            int number;//在内存中开辟了一块能够存储整数的空间
            number = 100;//表示把100存储到了这块空间内
            //声明并且给变量赋值的简写形式
            //变量类型 变量名=值
            int n = 100;
            double d=3.14;

            //字符串
            //张三、李四、王五...abcdefg
            string zsName = "张三";
            string nl = "";

            //字符串、字符 好比 羊肉串和羊肉
            //也就是 字符串可以存好多字符。字符就能存一个字符
            char gender = '男';
            //char c = '';//字符类型最多、最少只能存一个，
            //所以说在计算机中存单个的字符的时候可以用char类型
            //存很多很多文本的时候可以用string类型

            //存钱 用decimal 
            //double范围大 但精度不如decimal
            decimal money = 5000m;
        }
    }
}
