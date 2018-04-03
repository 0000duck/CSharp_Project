using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "张三";
            //Console.WriteLine("您好" + name);
            //Console.ReadKey();
            ///需求1、：
            /*
             有个叫卡卡西的人在旅店登记的时候前台让他填一张表,
             这张表的里的内容要存到电脑上,有姓名、年龄、邮箱、家庭住址,工资.之后把这些信息显示出来
             我叫卡卡西，我住在火影村，我今年30了我的邮箱是kakaxi@qq.com，我的工资2000.  
             */

            string name = "卡卡西";
            int age = 30;
            string email = "kakaxi@qq.com";
            string address = "火影村";
            decimal salary = 2000m;
            Console.WriteLine("我叫" + name + ",我住在" + address + ",我今年" + age + "岁了" + "，我的邮箱是" + email + ",我的工资是" + salary + "。");
            Console.ReadKey();

            //需求2、
            /*
              定义一个变量存储一个人的年龄(18),然后发现这个人的年龄不是18岁,
              要把这个人的年龄修改成81岁(本题体会变量可以被重复多次赋值),
              最后把这个人的年龄输出到屏幕上?
             */

            //int age2 = 18;
            //age2 = 81;
            //Console.WriteLine("原来你都"+age2+"岁了啊");
            //Console.ReadKey();

        }
    }
}
