using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //构造函数重载以后，传参的时候就有了多种选择！！！理解啊要
            //Student s = new Student("张三",18,'男',100,100,100);//使用构造函数更简单
            //当我们创建对象的时候首先会执行我们的构造函数
            //如果你想初始化对象时就在构造函数里给对象的每个属性赋值
            //s.Name = "张三";//赋值的过程为对象的初始化
            //s.Age = 18;     //6个属性，初始化6次
            //s.Gender = '男';
            //s.Chinese = 100; 
            //s.Math = 100;
            //s.English = 100;
            Student s = new Student("张三",100,100,100);
            s.SayHello();
            s.ShowScore();
            Console.ReadKey();

            //构造函数重载以后，传参的时候就有了多种选择！！！理解啊要

            //Student xlStudent = new Student("小兰",16,'女');
            
            //xlStudent.SayHello();
            //xlStudent.ShowScore();   
            //Console.ReadKey();
        }
    }
}
