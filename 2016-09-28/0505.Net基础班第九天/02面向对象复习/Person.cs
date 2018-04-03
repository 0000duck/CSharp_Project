using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02面向对象复习
{
    public class Person
    {
        //字段(存储数据)、属性、方法
        private string _name;

        //在外面访问不到字段了 只能通过属性访问字段
        //标准写法给每一个字段都配备一个属性
        //属性的本质就是两个方法get、set
        //当给属性赋值的时候执行set方法
        //表面上是把值赋给属性，但最终还是把值给了字段
        public string Name
        {
            get {
                if (_name != "孙权")
                {
                    return _name = "孙权";
                }
                return _name; }//取值的时候会执行get，就像下面打印的时候就需要取值
            set { _name = value; }//在set里面判断value的值,在get里面判断字段的值。set方法就是把你赋值给属性的值再赋值给字段，get方法把字段的值给返回
        }
        int _age;
        public int Age
        {
            get { return _age; }
            set {
                if (value < 0 || value > 110)
                {
                    value = 0;
                }
                _age = value; } 
        }
        char _gender;
        public char Gender
        {
            get {
                if (_gender != '男' && _gender!= '女')
                {
                    return _gender='男';
                }
                return _gender; }
            set {
                //if (value != '男' && value != '女')
                //{
                //    value = '男';
                //}
                _gender = value; }          
        }


        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了,我是{2}生",this.Name,this.Age,this.Gender);
        }
    }
    
}
