using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProOperation;
namespace _07简单工厂之计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入操作符");
            string oper = Console.ReadLine();
            //简单工厂的核心
            //根据用户的输入返回算法的父类
            Operation operation = GetOperation(oper, n1, n2);
            if (operation != null)
            {
                int result = operation.GetResult();
                Console.WriteLine("{0}{1}{2}={3}", n1, oper, n2, result);
            }
            else
            {
                Console.WriteLine("您输入的操作符有误,请重新输入");
            }
            Console.ReadKey();
        }
        static Operation GetOperation(string oper, int n1, int n2)
        {
            Operation operation = null;
            switch (oper)
            {
                case "+":
                    operation = new Add(n1, n2);
                    break;
                case "-":
                    operation = new Sub(n1, n2); 
                    break;
                case "*":
                    operation = new Cheng(n1, n2);
                    break;
                case "/":
                    operation = new Chu(n1, n2);
                    break;
            }
            return operation;
        }
    }
}
