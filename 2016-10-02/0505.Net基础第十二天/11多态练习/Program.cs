using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //经理十一点打卡 员工九点打卡 程序猿不打卡
            
            Employee e = new Employee();
            Manager m = new Manager();
            Programmer p = new Programmer();
            Employee[] emp = {e,m,p};
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i].DaKa();
            }
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public virtual void DaKa()
        {
            Console.WriteLine("员工9点打卡了呦~~");
        }
    }
    public class Manager:Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("经理11点打卡了呦~~");
        }
    }
    public class Programmer:Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("程序猿不打卡了呦~~");
        }
    }
}
