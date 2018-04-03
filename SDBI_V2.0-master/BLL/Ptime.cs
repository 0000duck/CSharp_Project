using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace BLL
{
    public class Ptime
    {
        //
        /// <summary>
        /// 获取指定时间对象的时间戳
        /// </summary>
        /// <param name="dt">Datetime对象</param>
        /// <returns></returns>
        public double GetTimeStamp(DateTime dt)
        {
            TimeSpan ts = dt - new DateTime(1996, 11, 1, 0, 0, 0, 0);
            double result = ts.TotalSeconds;
            return result;
        }

        /// <summary>
        /// 获取指定时间字符串的时间戳
        /// </summary>
        /// <param name="timeString">例如2009-2-13 7:38:20.100</param>
        /// <returns></returns>
        public double GetTimeStamp(string timeString)
        {
            TimeSpan ts = stringParseToDateTime(timeString) - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return ts.TotalSeconds;
        }
        /// <summary>
        /// 将时间字符串转换成时间对象
        /// </summary>
        /// <param name="timeString"></param>
        /// <returns></returns>
        private DateTime stringParseToDateTime(string timeString)
        {
            DateTime time = Convert.ToDateTime(timeString);
            return time;
        }
        
        /// <summary>
        /// 获取当前的时间对象
        /// </summary>
        /// <returns></returns>
        public DateTime getNow()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// 获取未来时间的时间对象
        /// </summary>
        /// <param name="startTime">本学期开始日期</param>
        /// <param name="WeekTh">开学后的第几周</param>
        /// <param name="DayTh">目标周的第几天</param>
        /// <param name="time">目标天的第几个小时</param>
        /// <returns></returns>
        public DateTime getDataTime(string startTime,int WeekTh,int DayTh,int time)
        {
            //学期第一周开始时间
            DateTime datetime = Convert.ToDateTime(startTime);
            //获取学期第一天是周几
            int startWeek = (int)datetime.DayOfWeek;
            //学期第一周结束时间:下周一开始时间
            DateTime FirstEndTime = datetime.AddDays(7 - startWeek + 1);
            if (WeekTh == 1)
            {
                //第一周可能不是周一开始，本函数的计算方式是;本学期开始时间+星期,特殊情况是非周一开学
                  
                //学期开始所在周的周一
                DateTime startWeekOne = datetime.AddDays(-(startWeek - 1));
                startWeekOne = startWeekOne.AddDays(DayTh - 1);
                startWeekOne =startWeekOne.AddHours(Convert.ToDouble(time));
                return startWeekOne;
            }
            else
            {
                int days = (WeekTh - 2)*7 + (DayTh - 1);
                FirstEndTime = FirstEndTime.AddDays(days);
                FirstEndTime = FirstEndTime.AddHours(Convert.ToDouble(time));
                return FirstEndTime;
            }                    
        }
        /// <summary>
        /// 获取指定周次的开始时间戳和结束时间戳
        /// </summary>
        /// <param name="weekTh">周次</param>
        /// <returns></returns>
        public Dictionary<string, double> getStart2End(string start,int weekTh)
        {
            Dictionary<string, double> result = new Dictionary<string, double>();
            result.Add("start", 0);
            result.Add("end", 0);
            
            try
            {
                //此行验证传递的时间字符串是否合法
                DateTime testTime = Convert.ToDateTime(start);

                if (weekTh >= 1)
                {
                    DateTime starttime = getDataTime(start, weekTh, 1, 0);
                    DateTime endtime = getDataTime(start, weekTh, 7, 12);
                    result["start"] = GetTimeStamp(starttime);
                    result["end"] = GetTimeStamp(endtime);
                    return result;
                }
                else
                {
                    return result;
                }
            }
            catch
            {
                return result;
            }                       
        }
        /// <summary>
        /// 获取指定时间戳的详细信息(星期、日期、时间)
        /// </summary>
        /// <param name="timePunch"></param>
        /// <returns></returns>
        public Dictionary<string,string> getTimePunchMessage(string timePunch)
        {
            double times = Convert.ToDouble(timePunch);
            DateTime punchTime = new DateTime(1996, 11, 1, 0, 0, 0, 0).AddSeconds(times);
            punchTime.Date.ToString();
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("星期", punchTime.DayOfWeek.ToString());
            result.Add("日期", punchTime.Date.ToString());
            result.Add("时间", punchTime.Hour.ToString());
            return result;
        }
        /// <summary>
        /// 根据本学期开始时间以及当前时间获取当前是本学期的第几周
        /// </summary>
        /// <param name="start"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public int getNowWeekTh(string start, DateTime dt)
        {
            //本学期第一周开始日期
            DateTime time = stringParseToDateTime(start);
           //获取学期开始日期是周几
            int startWeek= (int)time.DayOfWeek;
            //划定第一周结束日期：下周一0点
            DateTime FirstEndTime= time.AddDays(7 - startWeek+1);//第一周结束日期
            //当前时间是否落在第一周
            if (dt < FirstEndTime & dt > time)
                return 1;
            //开始计算当前时间周次
            DateTime weekStart = FirstEndTime;
            DateTime WeekEnd = FirstEndTime.AddDays(7);
            int weekTH = 2;
            while (true)
            {
                if (dt > weekStart & dt < WeekEnd)
                    return weekTH;
                else
                {
                    weekStart= weekStart.AddDays(7);
                    WeekEnd= WeekEnd.AddDays(7);
                    weekTH += 1;
                }
            }
            //int weekTh = 2;
            //while (time < dt)
            //{
            //    time = time.AddDays(7);
            //    weekTh += 1;
            //}
            //return (weekTh - 1);
        }
        public double getRELLYTIMEPUNCH(double timePunch)
        {
            return timePunch + 7200;
        }
        //public string getTimeStringForTimeObject()
        //{

        //}

        /// <summary>
        /// 获取开学至今的周次
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public ArrayList getPastWeekList(string start)
        {
            DateTime now = getNow();
            int nowWeek = getNowWeekTh(start, now);
            ArrayList reslut = new ArrayList();
            for(int i = 1; i <= nowWeek; i++)
            {
                reslut.Add("第" + i + "周");
            }
            return reslut;
        }
    }
}
