using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_PersonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //24.创建一个Person类，属性：姓名、性别、年龄；方法：SayHi() 。
            //再创建一个Employee类继承Person类，扩展属性Salary,重写SayHi方法。
        }
    }
    public class Person
    {
        //private string _name;

        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }

        //    set
        //    {
        //        _name = value;
        //    }
        //}
        /// <summary>
        /// 自动属性 和上面写的属性是一样的 在编译的时候会自动生成一个私有的字段
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }
        public string Age
        {
            get;
            set;
        }

        public virtual void SayHi()
        {
            Console.WriteLine("父类打招呼");
        }
    }
    public class Employee:Person
    {
        public double Salary
        {
            get;
            set;
        }
        public override void SayHi()
        {
            Console.WriteLine("子类重写父类");
        }
    }
}
