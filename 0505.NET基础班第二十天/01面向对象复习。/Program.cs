using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01面向对象复习_
{
    class Program
    {
        static void Main(string[] args)
        {
            //this 1、当前类的对象 2、调用自己的构造函数
            //new  1、创建对象 2、隐藏父类那里继承过来的成员
        }
    }
    public class Person
    {
        public void T() { }
    }
    public class Teacher : Person
    {
        public new void T()
        { }
    }
}
