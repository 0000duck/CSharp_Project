using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 *1、我们在Main()函数中，调用Test()函数，我们管Main()函数称之为调用者，
 管Test()函数称之为被调用者。
 如果被调用者想要得到调用者的值：
 1)、传递参数。
 2)、使用静态字段来模拟全局变量。
 如果调用者想要得到被调用者的值：
 1)、返回值
 */
namespace _02方法的调用问题
{
    
    class Program
    {
        //使用静态字段来模拟全局变量。
        //字段 属于类的字段
        public static int _number = 10;
        static void Main(string[] args)
        {
            int b = 10;
            int a = 3;//a 现在的作用域只是在Main()函数中
            int result=Test(a);
            Console.WriteLine(result);
            //Console.WriteLine(_number);
            Console.ReadKey();            
        }
        public static int Test(int a)
        {
            // Console.WriteLine(_number);
            // a = a + 5;//报错的原因是因为 变量的作用域 再Test()方法中 没有声明 a 
            a = a + 5;
            return a;
        }
        public static void TestTwo()
        {
           // Console.WriteLine(_number);
        }
    }
}
