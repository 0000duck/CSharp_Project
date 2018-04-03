using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //里氏转换：
            //1、子类可以赋值给父类（如果有一个方法需要一个父类作为参数，我们可以传第一个子类对象）
            //2、如果父类中装的是子类对象，则可以将这个父类强转为子类对象

            //Person p = new Student();//把一个子类对象赋值给父类       
            //用is as这种方式转换

            //1、用is转
            //if (p is Student)
            //{
            //    ((Student)p).StudentSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}

            //2、用as转
            //Student ss = p as Student;//表示将p转换成student 用Student来接受
            //ss.StudentSayHello();
            //Console.ReadKey();

            //ArrayList list = new ArrayList();
            //list.Add();
            //Remove RemoveAt RemoveRange Clear Insert InsertRange
            //Reverse Sort

            //Hashtable ht = new Hashtable();
            //ht.Add(1,"张三");
            //ht.Add(true,'男');
            //ht.Add(3.14,5000m);
            //在键值对集合中 键必须是唯一的
            //ht.Add(1,"李四");
            //ht[1] = "李四";//增加一个已经有键的方法
            //ht.ContainsKey  判断集合中是否包含某个键

            //看一看集合中有哪些数据用foreach
            //var（推断类型）根据变量的值 推断出变量的类型
            //item代表循环的集合中的每一项
            //in 在...
            //collection表示要遍历的集合 
            //我们在这里遍历键，因为我们可以根据键表示出来值
            //foreach (var item in ht.Keys)
            //{
            //    Console.WriteLine("{0}----------{1}",item,ht[item]);
            //}
            //Console.ReadKey();

            //Path、File都是静态类、

            //Path操作路径
            //File文件

            //通过ReadAllBytes读数据
            //byte[] buffer=File.ReadAllBytes(@"C: \Users\洪佳朋\Desktop\新建文本文档.txt");
            ////将字节数组中的每一个元素都要按照我们指定的编码格式解码成字符串
            ////UTF_8 GB2312 GBK ASCII Unicode()
            //string s= Encoding.GetEncoding("GB2312").GetString(buffer);
            //Console.WriteLine(s);
            //Console.ReadKey();

            //通过WriteAllBytes读数据
            //没有这个文件的话 会给你创建一个 有的话 会给你覆盖掉
            //string str = "今天天气好晴朗";
            ////需要将字符串转换成字节数组
            //byte[] buffer = Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"C: \Users\洪佳朋\Desktop\lallala.txt",buffer);
            //Console.WriteLine("写入成功");
            //Console.ReadKey();

            //以行的形式进行读取
            //string[] contents=File.ReadAllLines(@"C:\Users\洪佳朋\Desktop\青春.txt",Encoding.Default);
            //foreach (string item in contents)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey(); 

            //string str = File.ReadAllText("青春.txt",Encoding.Default);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //File.WriteAllLines(@"C:\Users\洪佳朋\Desktop\new.txt",new string[] {"aoe","ewu"});
            //Console.WriteLine("OK");
            //Console.ReadKey();

            //File.WriteAllText(@"C:\Users\洪佳朋\Desktop\new.txt", "zjosjaodjapdpakd");
            //Console.WriteLine("OK");
            //Console.ReadKey();

            //下面的不会覆盖
            File.AppendAllText(@"C:\Users\洪佳朋\Desktop\new.txt", "看我有没有把你覆盖掉");
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }

    public class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("我是人类");
        }
    }

    public class Student : Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
       
    }
}
