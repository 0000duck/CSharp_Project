﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using 成绩管理系统;

namespace   MySchool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            //Application.Run(new AboutForm());
            //Application.Run(new StudentMsgFrm());
            //Application.Run(new CourseMsgFrm());
            Application.Run(new MainFrm());
        }
    }
}
