using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_复习
{
   public class Person
    {
        //字段、属性、方法、构造函数
        //字段:存储数据
        //属性:保护字段，对字段的取值和设值进行限定
        //方法：描述对象的行为
        //构造函数;初始化对象（给对象的每一个属性依次的赋值）
        //类中的成员，如果不加访问修饰符，默认都是private
        //要求：①传的姓名值姓名不是孙权，改为孙权。②年龄>0且<110。③性别，男。
        string _name;
        /// <summary>
        /// 属性的本质就是两个方法
        /// </summary>
        public string Name
        {
            get { return _name; }//打印属性时执行的是这个方法
            //①
            set {
                if (value!="孙权")
                {
                    value = "孙权";
                }
                _name = value; }//给属性赋值执行这个方法
        }
        int _age;
        public int Age
        {
            //②
            get {
                if (_age<0||_age>100)
                {
                    return _age = 0;
                }
                return _age; }
            set {
                //if (value<0||_age>value)
                //{
                //    value = 0;
                //}
                _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        //实例方法（非静态方法）
        //this：代表当前类的对象
        //this：调用当前类的构造函数
        public void SayHello()
        {
            string Name = "张三";
            Console.WriteLine("{0},{1},{2}",this.Name,this.Age,this.Gender);//this区分属性和局部变量，加上this就是属性了
            //_id在非静态方法中可以访问非静态的成员
        }

        private static int _id;
        //在静态方法中只能使用（访问）静态成员
        public static void SayHelloTwo()
        {
            Console.WriteLine("Hello 我是静态的");
        }

        //构造函数：1、没有返回值 连void都没有
        //          2、构造函数的名称和类名一样
        public Person(string name,int age,char gender)
        {
            this.Name = name;//将传进来的值赋给属性
            this.Age = age;
            //③
            if (gender!='男'&&gender!='女')
            {
                gender = '男';
            }
            this.Gender = gender;
        }
        //this的第二个作用
        public Person(string name,char gender):this(name,0,gender)
        {

        }
        public Person()
        {

        }

    }
}
