using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //窗体1有方法但没值，窗体2有值但是没方法
        //所以得像个方法把值传给form2 传过去后Form2就既有值又有方法了
        //但他俩在两个类中。这时可以通过构造函数把值传递给Form2
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        void ShowMsg(string str)//这个string str字符串是在Form2中输入的文本
        {
            label1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建窗体2对象的时候调用构造函数了，通过构造函数把方法传进去
            //这样Form2既有值又有方法了
            Form2 f2 = new Form2(ShowMsg);
            f2.Show();
        }
    }
}
