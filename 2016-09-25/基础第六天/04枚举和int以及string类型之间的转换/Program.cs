using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04枚举和int以及string类型之间的转换
{
    public enum QQState
    {
        Online=1,
        OffLine,
        Leave,
        Busy,
        QMe
    }
    public enum Genser
    {
        男, 
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 将枚举类型强转成int类型
            //QQState state = QQState.Online;
            ////枚举类型默认可以跟int类型相互转换 枚举类型跟int类型是兼容的
            //int n=(int)state;
            //Console.WriteLine(n);
            //Console.WriteLine((int)QQState.OffLine);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.QMe);
            //Console.ReadKey();
            #endregion

            #region 将int类型强转成枚举类型
            //int n1=8; //如果n1=8、遇到转换不了的直接输出原来的数字
            //int n1 = 3;
            //QQState state =(QQState)n1;
            //Console.WriteLine(state);
            //Console.ReadKey();
            #endregion

            #region 将枚举类型转换成字符串类型
            //所有的类型都能够通过调用ToString()方法，将其转换成string类型
            //int n1 = 10;
            //double n2 = 3.14;
            //decimal n1 = 5000m;
            //string s = n1.ToString();
            //Console.WriteLine(s);
            //Console.ReadKey();

            //QQState state = QQState.Online;
            //string s = state.ToString();
            //Console.WriteLine();
            //Console.ReadKey();
            #endregion

            #region 将字符串类型转换成枚举类型
           // string s = "0";
            //将s转换成枚举类型
            //①Convert.ToInt32() 这个内部上调的就是int.Parse()
            //②int.Parse()  ①、②两种用法一样
            //③int.TryParse();
            //④double.Parse()
            //⑤char.Parse
            //⑥bool.Parse
            //⑦Enum.Parse
            //Enum类调用Parse()方法的目的就是为了让他帮助我们将一个字符串转换成对应的枚举类型

            //调用Parse的方法就是将一个字符串转换成一个枚举类型
            //QQState state= (QQState)Enum.Parse(typeof(QQState), s);
            //Console.WriteLine(state);
            //Console.ReadKey();
            #endregion

            //枚举练习
            //提示用户选择一个在线状态，我们接受 ，并将用户的输入转换成枚举类型。
            //再次打印到控制台中

            Console.WriteLine("请选择您的QQ的在线状态 1--OnLine 2--OffLine 3--Leave 4--Busy 5--QMe");
            string input = Console.ReadLine();
            //下面对input做一个多条件的定值判断。用switch case
            switch (input)
            {
                case "1":
                    QQState s1= (QQState)Enum.Parse(typeof(QQState),input);
                    Console.WriteLine("您选择的在线状态是{0}",s1);
                    break;
                case "2":
                    QQState s2 = (QQState)Enum.Parse(typeof(QQState),input);
                    Console.WriteLine("您选择的在线状态是{0}", s2);
                    break;
                case "3":
                    QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s3);
                    break;
                case "4":
                    QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s4);
                    break;
                case "5":
                    QQState s5 = (QQState)Enum.Parse(typeof(QQState),input);
                    Console.WriteLine("您选择的在线状态是{0}",s5);
                    break;
            }
            Console.ReadKey();

        }
    }
}
