using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08out参数的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //out参数侧重于在函数中返回多个值
            //out 参数要求必须在方法的内部为其赋值
            //int n;
            //string s;
            //bool b = Test(out n, out s);
            //Console.WriteLine(b);
            //Console.WriteLine(n);
            //Console.WriteLine(s);
            //Console.ReadKey();


            //while (true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    string pwd = Console.ReadLine();
            //    string msg;
            //    bool b = IsLogin(name,pwd,out msg);
            //    Console.WriteLine("登录结果{0}",b);
            //    Console.WriteLine("登录信息{0}",msg);
            //    Console.ReadKey();
            //}



            //写一个函数 交换两个整数的变量
            int n1 = 10;
            int n2 = 20;
            Change(ref n1, ref n2);
            Console.WriteLine("{0}----{1}", n1, n2);
            Console.ReadKey();

            Test2("张三",1,2,3);//第二个参数可以是 int类型的数组 ,也可以是数组里面的内容
            Test2("李四",new int[]{1,2,3 });//注意 函数形参数有params的时候 参数必须是最后一个
        }

        static void Change(ref int n1, ref int n2)
        {

            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
        static void Test2(string name, params int[] score)
        {

        }

        static bool IsLogin(string name,string pwd,out string msg)
        {
            if (name=="admin"&&pwd=="123123")
            {
                msg = "登录成功";
                return true;
            }
            else if (name=="admin")
            {
                msg = "密码错误";
                return false;
            }
            else if (pwd=="123123")
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "未知错误";
                return false;
            }
        }

        static bool Test(out int number, out string res)
        {
            //返回一个bool  int  string
            number = 10;
            res = "张三";
            return true;

        }
    }
}
