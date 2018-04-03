using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14方法的递归
{
    class Program
    {
        static void Main(string[] args)
        {
            TellStory();
            Console.ReadKey();
        }

        public static int i = 0;//静态字段 可以当做全局变量来处理，因为作用域是整个类

        public static void TellStory()
        {
            //int i = 0;
            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有座庙");
            Console.WriteLine("庙里有个老和尚和小和尚");
            Console.WriteLine("有一天，小和尚哭了，老和尚给小和尚讲了一个故事");
            i++;
            if (i>=10)
            {
                return;
            }
            TellStory();
        }
    }
}
