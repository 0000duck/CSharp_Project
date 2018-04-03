using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             泛型集合
             * List<T>
             * Dictionary<T,T>
             * 装箱和拆箱
             * 装箱：将值类型转换为引用类型
             * 拆箱：将引用类型转换为值类型
             * 我们应该尽量避免在代码中发生装箱或者拆箱
             * 文件流
             * FileStream StreamReader(它是操作字节的，就意味着可以操作任意的文件)和StreamWriter
             * 多态：虚方法、
             * //抽象类、接口
             * 写多态的好处？
             * 1、减少了代码
             * 2、屏蔽各个子类对象之间的差异，写出通用的代码
             * 虚方法：
             * 抽象类：
             
             */
            //List<int> list = new List<int>();

            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "张三");
            //dic[2] = "李四";
            //foreach (KeyValuePair<int,string> kv in dic)
            //{
            //    Console.WriteLine("{0}-----{1}",kv.Key,kv.Value);
            //}
            //Console.ReadKey();

            //File  FileStream(操作字节的，就是可以操作任何文件。必须掌握) StreamReader StreamWriter
            //using (FileStream fsRead = new FileStream("0505远程版机器码.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    byte[] buffer = new byte[1024 * 1024 * 5];
            //    //本次读取实际读取到的字节数
            //    int r = fsRead.Read(buffer, 0, buffer.Length);

            //    //将字节数组中的每个元素按照我们指定的编码格式解析成字符串
            //    string s = Encoding.Default.GetString(buffer, 0, r);
            //    Console.WriteLine(s);
            //}
            //Console.ReadKey();

            //using (FileStream fsWrite = new FileStream(@"C:\Users\SpringRain\Desktop\new.txt", FileMode.Append, FileAccess.Write))
            //{
            //    string s = "abc";
            //    byte[] buffer=Encoding.UTF8.GetBytes(s);
            //    fsWrite.Write(buffer,0,buffer.Length);
            //}
            //Console.WriteLine("OK");
            //Console.ReadKey();






            
            //虚方法和抽象类

            //虚方法:父类里有实现的时候才用
            //老师可以起立  学生也可以起立  校长也可以起立

            //实现多态的时候:
            //1、声明父类去指向子类对象
            //2、本质上调的StandUp();依然是父类自己的，因为p是父类类型，虽然里面装的是子类对象
            //3、虽然调的是自己的方法，但是这个方法被子类重写了，所以说最终执行的是子类的方法
            //4、最终执行那个方法取决于父类里装的是哪一个对象
            Person p = new HeadMaster();//new Teacher();//new Student();
            p.StandUp();
            Console.ReadKey();

        }
    }


    public abstract class Person
    {
        public abstract void StandUp();
    }

    public class Student : Person
    {
        public override void StandUp()
        {
            Console.WriteLine("学生起立，说老师好");
        }
    }


    public class Teacher : Person
    {
        public override void StandUp()
        {
            Console.WriteLine("老师起立，说校长好");
        }
    }

    public class HeadMaster : Person
    {
        public override void StandUp()
        {
            Console.WriteLine("校长起来说领导好");
        }
    }



}
