using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12接口特点
{
    //接口、抽象类、静态类都不可以被实例化
    class Program
    {
        static void Main(string[] args)
        {
            //接口就是一个规范、能力

            IFlyable fly = new Bird();//new Person();// new IFlyable();
            fly.Fly();
            Console.ReadKey();
        }
    }
    public class Person : IFlyable
    {
        public void Fly() //实现了接口中的成员
        {
            Console.WriteLine("人类在飞");
        }
    }


    public class Student : Person, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("人类在飞");
        }
    }

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟在飞");
        }
    }

    public interface IFlyable  //接口的名字 一般以 I开头 以 able结尾 表示一种能力
    {
        //不允许有访问修饰符 默认为public
        //方法、自动属性（没有方法体）
        void Fly();
    }



    public interface M1
    {
        void Test1();
    }

    public interface M2
    {
        void Test2();
    }

    public interface M3
    {
        void Test3();
    }


    public interface SupperInterface : M1, M2, M3
    {

    }

    public class Car : SupperInterface
    {

        public void Test1()
        {
            throw new NotImplementedException();
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }

        public void Test3()
        {
            throw new NotImplementedException();
        }
    }

}
