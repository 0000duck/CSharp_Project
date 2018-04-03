using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_枚举的练习
{
    public enum Sesons
    {
        春,
        夏,
        秋,
        冬
    }
    public enum QQstate
    {
        OnLine,
        OffLine,
        Leave,
        Busy,
        QMe
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sesons s = Sesons.春;
            QQstate state = QQstate.QMe;
        }
    }
}
