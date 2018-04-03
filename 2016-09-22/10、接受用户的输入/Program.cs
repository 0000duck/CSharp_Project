using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12_接受用户的输入
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入您的姓名");
            ////我们还想要接受您输入的姓名
            ////接受用户在控制台的输入 11 3.14 男 张三
            //string name= Console.ReadLine();
            //Console.WriteLine("您的姓名是{0}",name);
            //Console.ReadKey();

            //1、练习:问用户喜欢吃什么样的水果(fruits)，假如用户输入“苹果”，则显示“哈哈，这么巧，我也喜欢吃苹果”
            Console.WriteLine("美女，你喜欢吃啥子水果呦~~~~");
            string fruit = Console.ReadLine(); //不存会怎么样？使用Console.ReadLine()的时候，需要声明一个string类型的变量来接受
            Console.WriteLine("哈哈，这么巧呀，我也喜欢吃{0}", fruit);
            Console.ReadKey();

            //2、练习
            //Console.WriteLine("请输入您的姓名");
            //string name=Console.ReadLine();
            //Console.WriteLine("请输入您的性别");
            //string gender = Console.ReadLine();
            //Console.WriteLine("请输入您的年龄");
            //string age = Console.ReadLine();
            //Console.WriteLine("您好:{0},您的年龄是{1},是个{2}生",name,age,gender);
            //Console.ReadKey();



        }
    }
}
