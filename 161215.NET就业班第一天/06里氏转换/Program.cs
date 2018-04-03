using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Student();

            //什么时候用is 什么时候用as
            //注意:用is并没有转  只是做了一个判断 返回一个布尔类型的数。 用as就直接转了 但也要进行判断
            //里氏转换第一条 可以把子类赋值给父类  把所有的子类对象 当做父类来看 
            //每一个子类 都有一个差异

            //Teacher t = (Teacher)person;  这样写抛异常
            //t.TeacherSayHello();

            //if (person is Teacher) //意思是如果person能够转换成一个Teacher
            //{
            //    ((Teacher)person).TeacherSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}

            Student s = person as Student;//将person转换为student对象 s的值有两种一种是对象 一种是null
            if (s != null)
            {
                s.StudentSayHello();
            }
            else
            {
                Console.WriteLine("转换失败");
            }
            Console.ReadKey();
            //is as
        }
    }
    class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("我是父类");
        }
    }

    class Student : Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }

    class Teacher : Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("我是老师");
        }
    }
}
