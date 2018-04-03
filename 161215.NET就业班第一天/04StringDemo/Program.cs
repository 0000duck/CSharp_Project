using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcd";
            string str2 = "abc";
            string str3 = String.Copy(str2);
            //string str3 = str2;
            string str4 = "abc";
            Console.WriteLine(String.Equals(str1, str2)); //true;
            Console.WriteLine(str1.Equals(str3));        //true;
            Console.WriteLine(str1 == str3);             //true;
            Console.WriteLine(str1 == str4);             //false;
            Console.ReadKey();
        }
    }
}
