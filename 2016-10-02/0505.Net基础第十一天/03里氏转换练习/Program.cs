using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03里氏转换练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建10个对象，通过一个循环，去调用他们各自打招呼的方法
            //Student s = new Student();
            //Person p = new Person();
            //ShuaiGuo sg = new ShuaiGuo();

            Person[] pers = new Person[10];//Person类型的数组。下面的子类都可以放到这个数组里去
            Random r = new Random();//产生一个随机数

            //写循环的目的就是通过产生的随机数给数组的每一个元素赋值，循环十次，数组里就有10个对象(这10个对象既有子类也有父类)
            for (int i = 0; i < pers.Length; i++)
            {
                int rNumber = r.Next(1,7);
                switch (rNumber)//1-6
                {
                    case 1:pers[i] = new Student();
                        break;
                    case 2:pers[i] = new Teacher();
                        break;
                    case 3:pers[i] = new MeiLv();
                        break;
                    case 4:pers[i] = new ShuaiGuo();
                        break;
                    case 5:pers[i] = new YeShou();
                        break;
                    case 6:pers[i] = new Person();
                        break;
                }
            }

            //这个循环是循环数组调用里面每一个元素进行打招呼的方法
            for (int i = 0; i < pers.Length; i++)
            {
                //pers[i].PersonSayHi();直接写这样一行代码调用的只是父类自己的，
                //因为我们知道你里面装的只是子类对象，但是你在父类类型的数组里面,表现出来的类型就是父类类型，所以只能调用父类里的方法
                //所以我们对每一个数组进行转换，如果能转换成子类对象的话，就调用与之对应的打招呼的方法
                //pers[i] 是当前这个数组里循环到的元素
                if (pers[i] is Student)//能够转换成Student
                {
                    ((Student)pers[i]).StudentSayHi();
                }
                else if (pers[i] is Teacher)
                {
                    ((Teacher)pers[i]).TeacherSayHi();
                }
                else if (pers[i] is MeiLv)
                {
                    ((MeiLv)pers[i]).MeiLvSayHi();
                }
                else if (pers[i] is ShuaiGuo)
                {
                    ((ShuaiGuo)pers[i]).ShuaiGuoSayHi();
                }
                else if (pers[i] is YeShou)
                {
                    ((YeShou)pers[i]).YeShouSayHi();
                }
                else
                {
                    pers[i].PersonSayHi();
                }
               
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        public void PersonSayHi()
        {
            Console.WriteLine("我是人类");
        }
    }
    public class Student : Person
    {
        public void StudentSayHi()
        {
            Console.WriteLine("我是学生");
        }
    }

    public class Teacher : Person
    {
        public void TeacherSayHi()
        {
            Console.WriteLine("我是老师");
        }
    }


    public class MeiLv : Person
    {
        public void MeiLvSayHi()
        {
            Console.WriteLine("我是镁铝");
        }
    }


    public class ShuaiGuo : Person
    {
        public void ShuaiGuoSayHi()
        {
            Console.WriteLine("我是帅锅");
        }
    }


    public class YeShou : Person
    {
        public void YeShouSayHi()
        {
            Console.WriteLine("我是野兽");
        }
    }
}
