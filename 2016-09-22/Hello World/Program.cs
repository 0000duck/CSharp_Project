using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //这行代码的作用是将Hello World打印到控制台当中
            Console.WriteLine("Hello world");

            //暂停当前程序
            //等待用户按下任意键继续，按下的任意键将显示在我们的控制台当中
            Console.ReadKey();

            ///快速注释
            ///Ctrl+k+c注释
            ///Ctrl+k+u 
            #region 这些代码是我没用的，但是却不想删的代码
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            //Console.WriteLine("jfoafjoas");
            #endregion
        }
        ///文档注释可以用来解释我们的方法
        /// <summary> summary表示摘要，这个方法是干啥用的，应该写在方法里面
        /// 这个方法的作用就是求两个整数的最大值
        /// </summary>
        /// <param name="a">第一个整数</param>
        /// <param name="b">第二个整数</param>
        /// <returns>返回比较大的哪个数字</returns>
        public static int GetMax(int a,int b) {
            return a > b ? a : b;
        }
    }

    ///文档注释也可以解释我们的类
    /// <summary>
    /// 这个类用来描述一个人的信息 从 姓名 性别 年龄 描述
    /// </summary>
    
    public class Person
    {
        public string Name {
            get;
            set;
        }
        public int Age {
            get;
            set;
        }
        public char Gender {
            get;
            set;
        }
        

    }
}
