using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10键值对集合对象 
{
    class Program
    {
        static void Main(string[] args)
        {
            //需要掌握添加顺序的方式。以及循环输出
            //创建一个键值对对象
            Hashtable ht = new Hashtable();
            ht.Add(1,"张三");//键和值得类型任意
            ht.Add(2,true);
            ht.Add(3,'男');
            ht.Add(false,"错误的");
            ht.Add(5,"张三");
            ht[6] = "新来的";//这也是一种添加数据的方式（根据键表示值赋值的方式
            ht[1] = "把张三干掉";//没有加进去 有的话干掉

            //abc--------cba
            if (!ht.ContainsKey("abc"))
            {
                ht.Add("abc", "cba");
            }
            else
            {
                Console.WriteLine("已经包含了abc这个键了！！！！");
            }


           // ht.Clear();//移除集合中的所有元素
            ht.Remove(3);

            //var  item集合里面的每一个元素 collection集合
            //应该遍历集合当中的键 这时item就是 ,前面的。。。
            //var item in ht.Values 这时的item就是张三、true、男。。。

            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键是---------{0}------------值是{1}",item,ht[item]);
            }

            //在键值对集合中 是根据键去找值的
            //Console.WriteLine(ht[1]);
            //Console.WriteLine(ht[2]);
            //Console.WriteLine(ht[3]);
            //Console.WriteLine(ht[false]);
            //Console.WriteLine("==================================");
            //for (int i = 0; i < ht.Count; i++)
            //{
            //    Console.WriteLine(ht[i]);
            //}
            Console.ReadKey();
        }
    }
}
