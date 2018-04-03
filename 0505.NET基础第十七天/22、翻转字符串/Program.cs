using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_翻转字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //23.请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }
            //中的内容反转。然后输出反转后的数组。不能用数组的Reverse()方法。
            string[] str = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            for (int i = 0; i < str.Length/2; i++)
            {
                string temp = str[i];
                str[i] = str[str.Length-1-i];
                str[str.Length - 1 - i] = temp;

                foreach (var item in str)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}
