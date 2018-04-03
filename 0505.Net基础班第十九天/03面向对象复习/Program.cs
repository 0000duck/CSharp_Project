using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person('中');
            //给对象的每个属性赋值的时候,叫做对象的初始化
            p.Name = "张三";
            p.Age = 18;
            p.Gender = '男';
            p.SayHello();
            Console.ReadKey();
            //3、面向对象的复习
            //1、封装、继承、多态
            //*** 字段：存储数据，访问修饰符应该设置为private私有的
            //*** 属性：保护字段，对字段的取值和赋值进行限定。
            //***new关键字：1、在堆中开辟空间 2、在开辟的空间中创建对象  3、调用对象的构造函数
            //*** this关键字：1、代表当前类的对象  2、调用自己的构造函数
            // *** 构造函数：初始化对象，当创建对象的时候，会调用构造函数。
            //***对字段的保护方法：
            //1、get()
            //2、set()
            //3、构造函数
            //* **return：
            //1、立即结束本次方法
            //2、在方法中返回要返回的值

        }
    }
}
