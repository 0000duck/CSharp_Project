using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GetArrayAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            //18.	为教师编写一个程序，该程序使用一个数组存储30个学生的考试成绩，
            //并给各个数组元素指定一个1 -100的随机值，然后计算平均成绩。

            int[] nums = new int[30];
            Random r = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(1, 101);
            }

            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            double avg = sum / nums.Length;
            avg = Convert.ToDouble(avg.ToString("0.00"));
            Console.WriteLine(avg);
            Console.ReadKey();



        }
    }
}
