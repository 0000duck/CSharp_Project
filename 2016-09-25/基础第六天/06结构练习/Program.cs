using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06结构练习
{
    public struct MyColor
    {
        public int _red;//字段
        public int _green;
        public int _blue;
    }
    public struct Person
    {
        public string _name;
        public Gender _gender;
        public int _age;
    }
    //声明一个枚举
    public enum Gender
    {
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1 定义一个结构叫MyColor,有三个成员,分别定义为int类型的red,green,blue
               声明一个 MyColor类型的变量,并对其成员赋值.使MyColor可以表示成一个红色.
             */

            //MyColor mc;
            //mc._red = 255;
            //mc._green = 0;
            //mc._blue = 0;

            /*
             2 定义一个结构类型Person,有三个成员,分别为姓名,性别,年龄 性别用枚举类型
               声明两个Person类型的变量,分别表示 张三 男  18岁/ 小兰 女 16岁
             */
            Person zs;            
            zs._name = "张三";
            zs._gender = Gender.男;
            zs._age = 18;

            Person xl;
            xl._name = "小兰";
            xl._gender = Gender.女;
            xl._age = 16;

            Console.WriteLine("我叫{0}，性别{1},年龄{2}",zs._name,zs._gender,zs._age);
            Console.WriteLine("我叫{0}，性别{1},年龄{2}",xl._name,xl._gender,xl._age);
            Console.ReadKey();

        }
    }
}
