using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01面向对象
{
    public struct PersonTwo//这是结构 不具备面向对象的特性，而是面向过程那一套
    {

    } 
        public class Person
        {
           private string _name;//字段是用来存数据的  private权限修饰符 加不加都一样 不加默认就是private
            //下面是一个属性，是用来保护_name字段的(对字段进行限定)
            public string Name
            {
                //当你输出属性值的之后，最终会调get方法
                get { return _name; } //表面上输出的是属性的值，最终返回的是字段的值
                //当给属性赋值的时候，首先会执行set方法
                set { _name = value; }
                //value就是你赋的那个值，最终弄给字段了
            }
            //通过属性对字段的取值和设置进行限定
           private int _age;
            public int Age
            {
                get { return _age; }
                set {
                if (value<0||value>110)
                {
                    value = 0;
                }
                _age = value; }
            }
                       
           private char _gender;
            public char Gender
            {
                //取值的时候用到get这个方法
                //
                get {
                if (_gender!='男'&&_gender!='女')
                {
                  return  _gender ='男';
                }
                return _gender; }
                set { _gender = value; }
            }

            public void CHLSS()
            {
                Console.WriteLine("我叫{0},我今年{1}岁,我是{2}生,我可以吃喝拉撒睡呦~~~", this.Name, this.Age, this.Gender);
                //this代表当前这个类的对象
            }
            // public 
        }
    }

