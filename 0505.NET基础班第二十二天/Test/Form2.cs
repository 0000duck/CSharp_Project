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
    //声明一个委托
    public delegate void DelTest(string str);
    public partial class Form2 : Form
    {
        public DelTest _del;//属性
        public Form2(DelTest del)//del就是ShowMsg()
        {
            this._del = del;//方法传过来后赋值给字段
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _del(textBox1.Text);
        }
    }
}