using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04静态和非静态
{
    class Program
    {
        static void Main(string[] args)
        {
            //为什么静态类不能创建对象呢？
            //Student s = new Student();
        }
    }
    class Person { }
    static class Student
    {
        //private string _name;不能在静态类中创建实例成员
    }

}
