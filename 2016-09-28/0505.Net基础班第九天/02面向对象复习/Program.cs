using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //类的实例化
            Person p = new Person();
            //下面是对象的初始化。
            p.Name = "张三";
            p.Age = -18;
            p.Gender = '中';
            p.SayHello();
            //给属性赋值其实就相当于给字段赋值，属性不存值，其过度的作用
            //当我们创建好一个类的对象后，需要给这个对象的每个属性去赋值。
            //我们管这个过程称之为对象的初始化。

            Person p2 = new Person();
            p2.Name = "李四";
            p2.Age = 20;
            p2.Gender = '女';
            p2.SayHello();
            Console.ReadKey(); 
        }
    }
}
