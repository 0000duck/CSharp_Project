using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 类型转换
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float chinese = float.Parse(textBox1.Text);
            float math = float.Parse(textBox2.Text);
            float sum = chinese + math;

            short a = 1;
            byte b = (byte)a;

            textBox3.Text = sum.ToString();
            textBox4.Text = b.ToString();
        }
    }
}
