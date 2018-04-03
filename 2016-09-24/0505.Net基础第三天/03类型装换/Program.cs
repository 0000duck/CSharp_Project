using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03类型装换
{
    class Program
    {
        static void Main(string[] args)
        {
            //显示类型转换、 自动类型转换
            //int--double     double--int

            //string s = "123";
            ////将字符串转换成int或者double类型
            //double d=Convert.ToDouble(s);
            //int n=Convert.ToInt32(s);//注意:一般用Int32
            //Console.WriteLine(n);
            //Console.WriteLine(d);
            //Console.ReadKey();

            //练习：让用户输入姓名 语文 数学 英语 三门课的成绩，然后给用户显示：XX，你的总成绩为XX分，平均成绩为XX分。

            Console.WriteLine("请输入姓名:");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的语文成绩:");
            string strChinese = Console.ReadLine();
            Console.WriteLine("请输入你的数学成绩:");
            string strMath = Console.ReadLine();
            Console.WriteLine("请输入你的英语成绩:");
            string strEnglish = Console.ReadLine();          
            //55 77 88  557788
            //由于字符串去相加的话，最终会变成相连接，如果要拿字符串类型的变量参与运算
            //需要将字符串转换成int或者double类型
            //int chinese=Convert.ToInt32(strChinese);
            //int math = Convert.ToInt32(strMath);
            //int english = Convert.ToInt32(strEnglish);

            //转成double类型同理
            double chinese = Convert.ToDouble(strChinese);
            double math = Convert.ToDouble(strMath);
            double english = Convert.ToDouble(strEnglish);
            double sumScore = chinese + math + english;
            double avg = (int)sumScore*1.0 / 3;
            Console.WriteLine("{0},你的总成绩为{1},平均成绩为{2:0.00}",name,sumScore,avg);//平均成绩为{2:0.00} 这样写是保留两位小数
            Console.ReadKey();

            //Console.WriteLine("{0}，你的总成绩为{1},平均成绩为{2}", name,chinese+math+english,(chinese+math+english)/3);
            //Console.ReadKey();
        }
    }
}
