using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05方法的递归
{
    class Program
    {
        static void Main(string[] args)
        {
            //TellStory();
            Daughter d = new Daughter();
            d.ShowMsg();
            Console.ReadKey();
        }
        #region
        //static int count = 0;
        //static void TellStory()
        //{
        //    Console.WriteLine("从前有座山,山里有座庙");
        //    Console.WriteLine("庙里有个老和尚和小和尚");
        //    Console.WriteLine("有一天,小和尚哭了,老和尚给小和尚讲了一个故事");
        //    count++;
        //    if (count >= 5)
        //    {
        //        return;
        //    }
        //    TellStory();
        //}
        #endregion
    }

    public class Father
    {
        private string name = "赵四";
        private int age = 42;

        void ShowMsg()
        {
            Console.WriteLine("我叫{0},今年{1}岁", name, age);
        }
    }
    class Daughter : Father
    {
        private string name = "赵冬青";
        private int age = 20;
       public void ShowMsg()
        {
            Console.WriteLine("我叫{0},今年{1}岁", name, age);
        }
    }
}
