using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12键值对集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome ,to Chinaworld
            string str = "Welcome ,to Chinaworld";
            //字母-->次数
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==' '||str[i]==',')
                {
                    continue;//继续回到循环条件进行判断
                }
                //如果字母在集合的键中是第一次出现
                if (!dic.ContainsKey(str[i]))//当前这个字母在键里没有
                {
                    dic.Add(str[i],1);
                }
                else
                {
                    //之前出现过
                    dic[str[i]]++;
                }
            }
            foreach (KeyValuePair<char,int> kv in dic)
            {
                Console.WriteLine("字母{0}出现了{1}次",kv.Key,kv.Value);
            }
            Console.ReadKey();
        }
    }
}
