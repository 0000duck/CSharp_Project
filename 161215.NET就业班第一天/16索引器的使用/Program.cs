using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16索引器的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = {1,2,3,4,5,6 };
            //Console.WriteLine(nums[3]);

            //Dictionary<string, int> dic = new Dictionary<string, int>();
            //dic.Add("张三",80);
            //dic.Add("李四",89);
            //dic["张三"];//80
            //Console.ReadKey();
            Person p = new Person();
            p.Numbers = new int[] {1,2,3,4,5,6 };
            for (int i = 0; i <p.Numbers.Length; i++)
            {
                Console.WriteLine(p.Numbers[i]);
            }
        }
    }
    class Person
    {
        private int[] numbers = new int[5];

        public int[] Numbers
        {
            get
            {
                return numbers;
            }

            set
            {
                numbers = value;
            }
        }

        //索引器 
    }
}
