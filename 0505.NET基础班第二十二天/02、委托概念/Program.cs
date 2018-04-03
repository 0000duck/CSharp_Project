using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    //声明一个委托指向一个函数
    public delegate void DelSayHi(string name);

    public delegate int Caculator(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            //将方法封装于委托对象当中
            //DelSayHi del = SayHiChinese;// new DelSayHi(SayHiChinese);//创建一个委托对象,指向一个函数
            //del("张三");
            //Console.ReadKey();
                        
            Test("张三", SayHiChinese);
            Test("李四", SayHiEnglish);

            Caculator a = new Caculator(Multiply);
            Caculator b = new Caculator(Add);
            int res= a(3,4);
            Console.WriteLine(res);
            Console.ReadKey();
            //Test("张三",);
        }
        /// <summary>
        /// 想通过只调用Test函数,
        /// 想用中文打招呼就用中文打招呼。想用英文打招呼就用英文打招呼。
        /// </summary>
        public static void Test(string name, DelSayHi del)
        {
            //调用
            del(name);
        }
        public static void SayHiChinese(string name)
        {
            Console.WriteLine("吃了吗?" + name);
        }
        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("Nice to meet you" + name);
        }

        public static int Test(int x,int y,Caculator c)
        {
           return c(x,y);
        }

        public static int Multiply(int x,int y)
        {
            return x * y;
        }
        public static int Add(int x,int y)
        {
            return x + y;
        }
    }
}
