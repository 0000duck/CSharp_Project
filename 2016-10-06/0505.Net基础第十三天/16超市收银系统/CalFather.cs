﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16超市收银系统
{
    abstract class CalFather
    {
        /// <summary>
        /// 计算打折后应付多少钱
        /// </summary>
        /// <param name="realMoney">打折前应付的价钱</param>
        /// <returns>打折后付的钱数</returns>
        public abstract double GetTotalMoney(double realMoney);
    }
}
