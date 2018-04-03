using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //[1]创建随机数对象
            Random r = new Random();
            string str = null;
            //[2]产生随机数
            for (int i = 0; i < 5; i++)
            {
                int rNum = r.Next(0, 10);
                str += rNum;//str=str+rNum
            }
            label1.Text = str;
        }
    }
}
