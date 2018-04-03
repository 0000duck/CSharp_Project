using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03面向对象复习
{
    //对字段进行保护的几种方法:
    //1、通过属性的set、get方法
    //2、通过构造方法对赋的值进行判断
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person('3');

            p.Name = "李四";
            p.Age = -19;
            Console.WriteLine(p.Gender);
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.ReadKey();
        }
    }

    class Person
    {
        //字段、属性、函数、构造函数....
        //字段：存储数据
        //属性：保护字段 get set
        //函数：描述对象的行为
        //构造函数：初始化对象，给对象的每个属性进行赋值
        private string _name;//不加private 默认就是private

        public string Name//张三
        {
            get { return _name; }//取属性的值 打印值
            set
            {
                if (value != "张三")
                {
                    value = "张三";
                }
                _name = value;
            }//给属性赋值
        }

        int _age;

        public int Age
        {
            get
            {
                if (_age < 0 || _age > 100)
                {
                    return _age = 18;
                }
                return _age;
            }
            set { _age = value; }
        }
        private char _gender;
        public char Gender { get; set; }


        public Person(char gender)
        {
            if (gender != '男' && gender != '女')
            {
                gender = '男';
            }
            this.Gender = gender;
        }
    }

}
