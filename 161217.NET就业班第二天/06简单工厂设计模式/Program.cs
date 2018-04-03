using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你想要的笔记本品牌");
            string brand = Console.ReadLine();
            //简单工厂的核心 工厂
            //根据用户的输入 返回相应的笔记本
            NoteBook nb = GetNoteBook(brand);
            if (nb!=null)
            {
                nb.SayHello();
            }
            else
            {
                Console.WriteLine("没有您想要的电脑");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 根据用户的输入返回相应的笔记本(父类)
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        static NoteBook GetNoteBook(string brand)//返回一个父类
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "IBM":
                    nb = new IBM();
                    break;
                case "Acer":
                    nb = new Acer();
                    break;
                case "Dell":
                    nb = new Dell();
                    break;
                case "Lenovo":
                    nb = new Lenovo();
                    break;               
            }
            return nb;
        }
    }
    abstract class NoteBook
    {
        public abstract void SayHello(); 
    }
    class IBM : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是IBM笔记本");
        }
    }
    class Lenovo : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本");
        }
    }

    class Dell : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是戴尔笔记本");
        }
    }
    class Acer : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是宏碁笔记本");
        }
    }

}
