using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01GradeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("你考了多少分（1—100）");
            int score = Convert.ToInt32(Console.ReadLine());
            string result = GetLevel(score);
            Console.WriteLine(result);           
            Console.ReadKey();
        }
        /// <summary>
        ///根据输入的成绩 判断结果
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public static string GetLevel(int score)
        {
            string level = null;
            #region if else-if的写法
            //if (score >= 90)
            //{
            //    level = "优";
            //}
            //else if (score >= 80)
            //{
            //    level = "良";
            //}
            //else if (score >= 70)
            //{
            //    level = "中";
            //}
            //else if (score >= 60)
            //{
            //    level = "差";
            //}
            //else
            //{
            //    level = "不及格";
            //}
            #endregion
            switch (score/10)
            {
                case 10:
                case 9:
                    level = "优";
                    break;
                case 8:
                    level = "良";
                    break;
                case 7:
                    level = "中";
                    break;
                case 6:
                    level = "差";
                    break;
                default:
                    level = "不及格";
                    break;
            }          
            return level;
        }

    }
}
