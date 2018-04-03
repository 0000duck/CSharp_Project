using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 练习
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             练习一、编程实现计算几天(如46天)是几周零几 天. 口算46/7 = 6周零4天           
             */

            //int days = 46;
            //int weeks = 46 /7;
            //int day = 46 % 7;
            //Console.WriteLine("{0}天是第{1}周零{2}天",days,weeks,day);
            //Console.ReadKey();

            /*
             练习二、编程实现107653秒是几天几小时几分钟几秒?    
             */

            //一天是24*60*60s= 86400
            int seconds = 107653;
            int days = seconds / 86400;//求得天数
            int secs = seconds % 86400;//求得求完天数后剩余的秒数
            int hours = secs / 3600;//求得小时数
            secs = secs % 3600;//求得小时数后剩余的秒数
            int mins = secs / 60;//求得分钟数
            secs = secs % 60;

            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒",seconds,days,hours,mins,secs);
            Console.ReadKey();

             /*练习三、编程实现107653秒是几天几小时几分钟几秒?
             修改上面的题目,让用户输入.
             小时(Hour),分钟(Minute),秒(Seconds)
             */

        }
    }
}
