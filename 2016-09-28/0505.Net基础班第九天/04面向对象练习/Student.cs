using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04面向对象练习
{
   public class Student
    {
        //字段、属性、方法、构造函数

        //析构函数  构造函数

        //当程序结束的时候 析构函数才执行
        //作用:帮助我们释放资源
        //GC Garbage Collection 有可能程序结束的时候，GC没有马上自动的为我们释放资源
        //如果这个时候你想让资源马上被释放。可以使用析构函数
        //如果说你不是用析构函数 就由我们的垃圾回收器自动回收资源
        ~Student()
        {
            Console.WriteLine("我是析构函数");
        }

        public Student(string name,int age,char gender,int chinese,int math,int english)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english; 
        }

        //这个构造函数调用的是本类的全参的构造函数
        public Student(string name,int chinese,int math,int english):this(name,0,'c',chinese,math,english)
        {
            //this.Name = name;
            //this.Chinese = chinese;
            //this.Math = math;
            //this.English = english;
        }

        public Student(string name,int age,char gender)
        {
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
        }
        
        private string _name;
        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age;}
            set {
                if (value < 0 || value > 110)
                {
                    value = 0; 
                }
                _age = value; }//注意：在set里面判断value，在get里面判断字段
        }
        private char _gender;
        public char Gender
        {
            get {
                if (_gender != '男'&&_gender!='女')
                {
                   return _gender = '男';
                }
                return _gender; }
            set { _gender = value; }
        }
        private int _chinese;
        public int Chinese
        {
            get { return _chinese; }
            set { _chinese = value; }
        }
        private int _math;
        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }
        private int _english;
        public int English 
        {
            get { return _english; }
            set { _english = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁,我是{2}生",this.Name,this.Age,this.Gender);
        }

        public void ShowScore()
        {
            Console.WriteLine("我叫{0}，我的总成绩是{1}，平均成绩是{2}",this.Name,this.Chinese+this.Math+this.English,(this.Chinese + this.Math + this.English)/3);
        }
        }
    }
  
