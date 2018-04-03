using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05结构
{
    public struct Person
    {
       public string _name;//字段 而不是变量 但都是用来存储数据的
       public int _age;    //给字段取名字的时候 在字段前面加_
       public Gender _gender;
    }

    public enum Gender
    {
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            //xx大学管理系统
            //姓名、性别、年龄、年级  //5000个人 20000个变量
            //string zsName = "张三";
            //int zsAge = 21;
            //char zsGender = '男';
            //int zsGread = 3;

            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age =21;
            zsPerson._gender =Gender.男;

            Person lsPerson;
            lsPerson._name = "李四";
            lsPerson._age = 20;
            lsPerson._gender = Gender.女;

            Console.WriteLine(zsPerson._name);
            Console.WriteLine(lsPerson._name);
            Console.ReadKey();
            
        }
    }
}
