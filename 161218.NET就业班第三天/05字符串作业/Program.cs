using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05字符串作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、字符串反转
            //课上练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba“.
            //string str = "abc";
            ////将str转换成char类型的数组
            //char[] chs = str.ToCharArray();
            ////反转char数组
            //for (int i = 0; i<chs.Length/2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length-1-i];
            //    chs[chs.Length - 1 - i] = temp;
            //}
            ////将改变后的char数组重新变回字符串
            //str = new string(chs);
            //Console.WriteLine(str);
            //Console.ReadKey


            //for (int i = (str.Length) - 1; i >= 0; i--)
            //{
            //    Console.Write(str.Substring(i, 1));
            //}
            //char[] testNew = str.ToCharArray();//将输入的字符串转换为字符串数组
            //Array.Reverse(testNew);//将数组反转
            //string s = new string(testNew);//将反转后的数组重新转换为字符串
            //Console.WriteLine(s);
            //Console.ReadKey();

            ////课上练习3：”2012年12月21日”从日期字符串中把年月日分别取出来，打印到控制台          
            //string data = "2012年12月21日";
            //string[] newData= data.Split(new char[] { '年','月','日'}, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日",newData[0],newData[1],newData[2]);
            //Console.ReadKey();


            //课上练习2：接收用户输入的一句英文，将其中的单词以反序输出。      “I love you"→“I evol uoy"            
            //课上练习4：把csv文件中的联系人姓名和电话显示出来。简单模拟csv文件，csv文件就是使用,分割数据的文本,输出：
            //姓名：张三 电话：15001111113

            //读取文件中的所有行，到数组中。
            //string[] lines = File.ReadAllLines(@"C:\Users\洪佳朋\Desktop\电话.txt", Encoding.Default);
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    //将双引号替换成 ""
            //    lines[i] = lines[i].Replace("\"","");
            //    //将逗号和分号去掉
            //    string[] linesNew = lines[i].Split(new char[] { ';', ','},StringSplitOptions.RemoveEmptyEntries);
            //    Console.WriteLine("姓名: "+linesNew[0]+linesNew[1]+" 电话: "+linesNew[2]);
            //}


            //练习5：123 - 456-- - 7-- - 89---- - 123----2把类似的字符串中重复符号”-”去掉，既得到123 - 456 - 7 - 89 - 123 - 2.split()、StringSplitOptions.RemoveEmptyEntries Join()
            //string str = "123 - 456-- - 7-- - 89---- - 123----2";
            //string[] strNew= str.Split(new char[]{'-',' '}, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(string.Join("-", strNew));
            //Console.ReadKey();

            //练习6：从文件路径中提取出文件名(包含后缀) 。
            //比如从c:\aewqq\beqewq.txt中提取出b.txt这个文件名出来。
            //以后还会学更简单的方式：“正则表达式”，项目中我们用微软提供的：Path.GetFileName();（更简单。）

            //string str = @"c:\aewqq\beqewq.txt";//@符号 取消\的转移作用
            //int index = str.LastIndexOf("\\");
            //string fileName = str.Substring(index + 1);
            //Console.WriteLine(fileName);
            //Console.ReadKey();


            //练习7：“192.168.10.5[port = 21, type = ftp]”，
            //这个字符串表示IP地址为192.168.10.5的服务器的21端口提供的是ftp服务，
            //其中如果“,type = ftp”部分被省略，则默认为http服务。请用程序解析此字符串，
            //然后打印出“IP地址为*** 的服务器的***端口提供的服务为 * **” line.Contains(“type =”)。192.168.10.5[port = 21]

            string str="192.168.10.5[port=21334, type =http]";
            //string s = "192.168.10.5[port = 21]";
            string ip = string.Empty;
            string port = string.Empty;
            string type = string.Empty;
            if (str.Contains("type"))
            {
                //获得第一次出现[的位置 截取ip地址
                int index1 = str.IndexOf("[");
                //获得=号第一次出现的位置
                int index2 = str.IndexOf("=");
                //获得,号第一次出现的位置
                int index3 = str.IndexOf(",");
                //获得最后一次=号出现的位置
                int index4 = str.LastIndexOf("=");
                //获得最后一次]出现的位置
                int index5 = str.LastIndexOf("]");
                ip = str.Substring(0, index1);
                port = str.Substring(index2+1,index3-index2-1);
                type = str.Substring(index4+1,index5-index4-1);
                Console.WriteLine("IP地址为{0}的服务器的{1}端口提供的服务为{2}",ip,port,type);
            }
            else
            {

            }
            Console.ReadKey();
            //练习8：求员工工资文件中，员工的最高工资、最低工资、平均工资
        }
    }
}
