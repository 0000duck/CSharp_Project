using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BLL
{
    public static class Week_th
    {
        public static string Time()
        {
            string strWeekNumber=string.Empty;
            DataTable dt = AddSQLStringToDAL.GetDatatableBySQL("TabCalendar");
            foreach(DataRow dr in dt.Rows)
            {
                if (Convert.ToDateTime(dr["StartWeek"]) < DateTime.Now && Convert.ToDateTime(dr["EndWeek"]) > DateTime.Now)
                {
                    strWeekNumber = dr["WeekNumber"].ToString();
                    if (strWeekNumber.Length == 1)
                    {
                        strWeekNumber = "0" + strWeekNumber;
                    }
                    
                }
                else
                {
                    strWeekNumber = "0";
                }
            }
            return strWeekNumber;
        }
    }
}
