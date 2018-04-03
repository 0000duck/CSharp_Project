using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SaveStuMes
{
    class Program
    {
        static void Main(string[] args)
        {
            //21.制作一个控制台小程序。要求：用户可以在控制台录入每个学生的姓名，
            //当用户输入quit（不区分大小写）时，程序停止接受用户的输入，并且显示出用户输入的学生的个数，以及每个学生的姓名。

            //22.题目内容同上题，再增加一个显示姓“王”的同学的个数，此处不考虑复姓问题

            //存储用户输入的姓名
            List<string> list = new List<string>();
            while (true)
            {
                Console.WriteLine("请输入姓名,输入quite退出");
                string name= Console.ReadLine();
                if (name!="quite")
                {
                    list.Add(name);
                }
                else
                {
                    break;
                }
            }
            int i = 0;
            Console.WriteLine("您刚才一共录入了{0}个人的成绩,分别是:",list.Count);
            foreach (string item in list)
            {
                if (item[0]=='王')
                {
                    i++;
                }
                Console.WriteLine(item);
            }
            Console.WriteLine("姓王的同学的个数一共有{0}个",i);
            Console.ReadKey();
        }
    }
}
