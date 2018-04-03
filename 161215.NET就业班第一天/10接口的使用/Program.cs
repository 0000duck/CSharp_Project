using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10接口的使用
{
    class Program
    {
        static void Main(string[] args)

        {
            //Student s = new Student();
            //s.CHLSS();
            //现实多态
            IkouLan i = new Teacher();//new Student();
            i.KouLan();
            Console.ReadKey();
        }
    }
    interface IkouLan
    {
        void KouLan();
    }
    class Person
    {
        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
        }
    }
    class NoTuiPerson : Person
    {

    }
    class Student : Person, IkouLan
    {
        public void KouLan()
        {
            Console.WriteLine("学生可以扣篮");
        }
    }
    class Teacher : Person, IkouLan
    {
        public void KouLan()
        {
            Console.WriteLine("老师也可以扣篮");
        }
    }
    class Driver : Person, IkouLan
    {
        public void KouLan()
        {
            Console.WriteLine("司机也可以扣篮");
        }
    }
    class NBAPlayer : Person
    {
        public void KouLan()
        {
            Console.WriteLine("NBA球员可以扣篮");
        }
    }
}
