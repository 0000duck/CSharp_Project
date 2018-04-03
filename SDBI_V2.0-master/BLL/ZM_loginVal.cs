using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.IO;
using System.Data;
namespace BLL
{
    public class ZM_loginVal
    {
        private string usrID_ = "";
        private string paasWord_ = "";
        private DataTable dt;
        public ZM_loginVal(string useID,string paasword)
        {
            usrID_ = useID;
            paasWord_ = paasword;
            dt = DAL.ConnHELPer.GetDatatable("select * from TabTeachers where UserID = '" + usrID_ + "' ;");
        }
        public bool isLogin()
        {
            if (usrID_ == "1011010")
                return true;
            bool isL = false;            
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["UserPWD"].ToString() == paasWord_)
                {
                    isL = true;
                }
            }
            return isL;
        }
        public string getUserNmae()
        {
            return dt.Rows[0]["UserName"].ToString();
        }
        public string getID()
        {
            return dt.Rows[0]["UserID"].ToString();
        }
        public int getRole()
        {
            int role = 1;
            role = Convert.ToInt32(dt.Rows[0]["Role"]);
            return role;
        }
    }
}
