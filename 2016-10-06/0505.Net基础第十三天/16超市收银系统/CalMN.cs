using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16超市收银系统
{
    /// <summary>
    /// 买M元送N元
    /// </summary>
    class CalMN : CalFather
    {
        public double M
        {
            get;
            set;
        }

        public double N
        {
            get;
            set;
        }

        public CalMN(double m,double n)
        {
            this.M = m;
            this.N = n;
        }
        /// <summary>
        ///                          不太懂
        /// </summary>
        /// <param name="realMoney"></param>
        /// <returns></returns>
        public override double GetTotalMoney(double realMoney)
        {
            //600   100
            //1000  200
            //1200  200
            if (realMoney > this.M)
            {
                return realMoney - (int)(realMoney/this.M)*this.N;
            }
            else
            {
                return realMoney;
            }
        }
    }
}
