using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03面向对象复习
{
    class Person
    {
        //类中的成员：
        //字段、属性、构造函数、方法、接口
        //字段:对于类而言 是存储数据的 数据是非常重要的东西 一定将字段标记为private。类中的成员如果不加修饰符,默认为private
        string _name;//应该给每一个类配备一个属性,因为在外界已经访问不到这个私有的字段了,只能访问这个字段所对应的属性,属性的作用就是保护字段

        public string Name
        {
            get{ return _name;}//打印(取)属性的值得时候执行get方法
            set
            {
                if (value != "洪佳朋")
                {
                    value = "洪佳朋";
                }
                _name = value;
            }//在外边给属性赋值的时候会执行set方法
        }
        int _age;
        public int Age
        {
            get
            {
                if (_age<0||_age>100)
                {
                    return _age = 0;
                }
                return _age;
            }

            set
            {               
                _age = value;
            }
        }
        char _gender;
        public char Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        public int Chinese
        {
            get
            {
                return _chinese;
            }

            set
            {
                _chinese = value;
            }
        }

        public int Math
        {
            get
            {
                return _math;
            }

            set
            {
                _math = value;
            }
        }

        public int English
        {
            get
            {
                return _english;
            }

            set
            {
                _english = value;
            }
        }

        int _chinese;
        int _math;
        int _english;
     
        //构造函数 初始化对象
        public Person(char gender)
        {
            if (gender!='男'&&gender!='女')
            {
                gender = '男';
            }
            this.Gender = gender;
        }
        public Person(string name,int age,char gender,int chinese,int math,int english)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }
        public Person(string name,int age,char gender):this(name,age,gender,0,0,0)//在执行这个构造函数的时候调用的是全餐的构造函数
        {

        }
        public Person() { }
        public void SayHello()
        {
            Console.WriteLine("{0}--{1}--{2}",this.Name,this.Age,this.Gender);
        }
    }
}
