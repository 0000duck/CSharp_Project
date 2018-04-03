using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07简单工厂设计模式复习
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("请输入你要购买的电脑");
                    string brand = Console.ReadLine();
                    NotepadFather np = GetNotePad(brand);
                    np.SayHello();
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("输入有误,请重新输入");
                }
                
            }
           
        }
        //简单工厂最核心的工厂
        //用一个方法模拟生产笔记本的过程
        //根据用户的输入返回一个父类,但是这个父类里面装的是子类对象
        /// <summary>
        /// 简单工厂的核心 根据用户的输入创建对象赋值给父类
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static NotepadFather GetNotePad(string brand)
        {
            NotepadFather nb = null;
            switch (brand)
            {
                case "Lenovo":nb = new Lenovo();
                    break;
                case "Dell":
                    nb = new Dell();
                    break;
                case "Hp":
                    nb = new Hp();
                    break;
                case "Acer":
                    nb = new Acer();
                    break;
            }
            return nb;
        }
    }
    public abstract class NotepadFather
    {
        public abstract void SayHello();
         
    }
    public class Lenovo : NotepadFather
    {
        public override void SayHello()
        {
            Console.WriteLine("我叫联想，你连想都别想");
        }
    }
    public class Acer : NotepadFather
    {
        public override void SayHello()
        {
            Console.WriteLine("我是宏碁笔记本");
        }
    }
    public class Dell : NotepadFather
    {
        public override void SayHello()
        {
            Console.WriteLine("我是戴尔笔记本");
        }
    }
    public class Hp : NotepadFather
    {
        public override void SayHello()
        {
            Console.WriteLine("我是惠普笔记本");
        }
    }
}
