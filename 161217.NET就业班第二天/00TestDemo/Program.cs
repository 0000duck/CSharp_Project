using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 3;
            //while (count > 1)
            //{
            //    Console.Write(--count);
            //}

            //string[] strings = {"a","b","c" };
            //foreach (string item in strings)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 1; i <=3; i++)
            //{
            //    switch (i)
            //    {
            //        //case 1:
            //        //    Console.Write(i.ToString());

            //        //case 2:
            //        //    Console.Write((i*2).ToString());
            //        //case 3:
            //        //    Console.WriteLine((i*3).ToString());

            //    }
            //}

            //string test = "ABCD";
            //foreach (char item in test)
            //{
            //    Console.Write(item);
            //}
            //int[] ages = new int[] {16,18,20,14,22 };
            //foreach (var item in ages)
            //{
            //    if (item>18)
            //    {
            //        continue;
            //    }
            //    Console.Write(item.ToString()+" ");               
            //}
            //Console.WriteLine(ages.Length);

            //string name = "ADO.NET";
            //foreach (char item in name)
            //{
            //    Console.Write(item);
            //}

            //int count = 5;
            //do
            //{
            //    Console.Write(++count);
            //}
            //while (count < 5);           
            //Console.ReadKey();

            //int count = 8;
            //Run(count);
            //Console.Write(count);

            Test t = new Test();
            t.Run();

            Console.ReadKey();
        }
       
    }
    #region
    class Test
    {
        public void Run()
        {
            //count = count + 88;
            //Console.Write(count);
            //int i = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}*{1}={2}", 10, 10,100);
        }
    }
    #endregion
}
