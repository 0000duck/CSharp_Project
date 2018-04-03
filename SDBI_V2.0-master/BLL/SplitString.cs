using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SplitString
    {
        public static List<string> GetSplitCountAndDetails(string str)
        {
            List<string> str1 = new List<string>();
            List<string> strResult = new List<string>();
            str1 = SplitTimeAndAreaString(str);
            for (int i = 0; i < str1.Count; i++)
            {
                List<string> str0 = new List<string>();
                str0 = GetTimeAndAreaDetails(str1[i]);
                for (int j = 0; j < str0.Count; j++)
                {
                    strResult.Add(str0[j].ToString());
                }
            }
            return strResult;
        }
        public static List<string> SplitTimeAndAreaString(string str)
        {
            List<string> strList = new List<string>();
            string[] strTemp = str.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strTemp.Length; i++)
            {
                if (strTemp[i].IndexOf("周") != -1)
                {
                    strList.Add(strTemp[i]);
                }
            }
            return strList;
        }
        public static List<string> GetTimeAndAreaDetails(string str)
        {
            List<string> strList = new List<string>();
            if (str.IndexOf("CAD/CAM一体化室") != -1)
            {
                str = str.Replace("CAD/CAM一体化室", "CAD与CAM一体化室");
            }
            string[] strTemp = str.Split(new char[] { '[', ']', '/' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strTemp.Length; i++)
            {
                strList.Add(strTemp[i]);
            }

            return strList;
        }
        //1-12,14-17,19-20单周
        ////1  3  5  7  9  11   15  17 19 
        public static List<string> GetWithoutWeek(string str)
        {

            int v = 0;
            if (str.IndexOf("单周") != -1)
            {
                v = 1;
            }
            if (str.IndexOf("双周") != -1)
            {
                v = 2;
            }
            StringBuilder sb = new StringBuilder();
            if (sb.Length > 0)
            {
                sb.Remove(0, sb.Length);
            }
            //1-12,14-17,19-20单周            
            string[] strTemp = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            //1-12 14-17 19-20单周
            //1-12 14-17 19-20单周
            for (int i = 0; i < strTemp.Length; i++)
            {
                //19 - 20单周
                string[] s1 = strTemp[i].Split(new char[] { '-', '单', '双', '周' }, StringSplitOptions.RemoveEmptyEntries);
                //19 20
                //1 12
                if (s1.Length == 1)
                {
                    sb.Append(" " + s1[0].ToString() + " ");
                }
                else
                {
                    for (int j = Convert.ToInt32(s1[0]); j < Convert.ToInt32(s1[1]); j++)
                    {
                        sb.Append(" " + j.ToString() + " ");
                    }
                    sb.Append(Convert.ToInt32(s1[1]).ToString());
                }
                //1 2 3 4 5 6 7 8 9 10 11 12
            }
            //1 2 3 4 5 6 7 8 9 10 11 12 14 15 16 17 19 20
            if (v == 1)
            {
                //1 2 3 4 5 6 7 8 9 10 11 12 14 15 16 17 19 20
                string[] ss1 = sb.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //1 2 3 4 5 6 7 8 9 10 11 12 14 15 16 17 19 20
                sb.Remove(0, sb.Length);
                for (int i = 0; i < ss1.Length; i++)
                {
                    int t = Convert.ToInt32(ss1[i]);
                    if (t % 2 != 0)
                        sb.Append(ss1[i] + " ");


                }
            }
            //1  3  5  7  9  11   15  17 19 
            //1 2 3 4 5 6 7 8 9 10 11 12 14 15 16 17 19 20
            if (v == 2)
            {
                string[] ss1 = sb.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                sb.Remove(0, sb.Length);
                for (int i = 0; i < ss1.Length; i++)
                {
                    int t = Convert.ToInt32(ss1[i]);
                    if (t % 2 == 0)
                        sb.Append(ss1[i] + " ");


                }
            }
            // 2  4  6  8  10  12 14  16   20
            string[] ss2 = sb.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> list5 = new List<string>(ss2);
            return list5;

        }


    }
}
