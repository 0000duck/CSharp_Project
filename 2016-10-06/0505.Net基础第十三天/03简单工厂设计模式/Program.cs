using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Computer cpu = new Acer();
            //cpu.SayHello();
            Console.WriteLine("请输入您想要的笔记本品牌");
            string brand = Console.ReadLine();
            Computer cp = GetComputer(brand);
            cp.SayHello();
            Console.ReadKey();
        }            
            /// <summary>
            ///简单工厂的核心 根据用户的输入创建对象 赋值给父类
            /// </summary>
            /// <param name="brand"></param>
            /// <returns></returns>
           public static Computer GetComputer(string brand)//根据用户输入的品牌来创建对象（返回一个父类.(父类里面装的是一个子类)）
            {
            Computer cp = null;
            switch (brand)
            {
                case "Lenovo":cp = new Lenovo();//创建了子类对象，赋值给父类
                    break;
                case "Acer":cp = new Acer();
                    break;
                case "Dell":cp = new Dell();
                    break;
                case "IBM":cp = new IBM();
                    break;                  
                default:
                    break;
            }
            return cp;
            }
        }
    }
    public abstract class Computer
    {
        public abstract void SayHello();
    }
    public class Acer : Computer
    {
        public override void SayHello()
        {
            Console.WriteLine("大家好，我是宏碁");
        }
    }
    public class IBM : Computer
    {
        public override void SayHello()
        {
            Console.WriteLine("大家好，我是IBM");
        }
    }
    public class Dell : Computer
    {
        public override void SayHello()
        {
            Console.WriteLine("大家好，我是Dell");
        }
    }
    public class Lenovo : Computer
    {
        public override void SayHello()
        {
            Console.WriteLine("大家好，我是联想，你连想也别想");
        }
    }

