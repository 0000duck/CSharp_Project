using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00this的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(1,98);
            p.SayHi();
            p.ShowScore();
            Console.ReadKey();


        }
    }
    class Person
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        private int _age;
        private char _gender;
        public char Gender { get; set; }
        private int _chinese;
        public int Chinese { get; set; }
        private int _math;
        public int Math { get; set; }
        private int _english;
        public int English { get; set; }
        public Person(string name,int age,char gender,int chinese,int math,int english)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }

        public Person(int age,int chinese ):this(null,15,'a',86,89,98)
        {

        }
        public void SayHi()
        {
            Console.WriteLine("我叫{0},今年{1}岁,我是{2}生",this.Name,this.Age,this.Gender);
        }
        public void ShowScore()
        {
            Console.WriteLine("我的语文成绩是{0},数学成绩是{1}，英语成绩是{2}",this.Chinese,this.Math,this.English);
        }
    }
}
