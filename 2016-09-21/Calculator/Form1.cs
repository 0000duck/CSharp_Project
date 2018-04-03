using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1 = double.Parse(textBox1.Text);
            double a2 = double.Parse(textBox2.Text);
            double a3 = 0;
            if (comboBox1.Text.ToString()=="+") {
                a3 = a1 + a2;
            }
            if (comboBox1.Text.ToString()=="-") {
                a3 = a1 - a2;
            }
            if (comboBox1.Text.ToString() == "*") {
                a3 = a1 * a2;
            }
            if (comboBox1.Text.ToString() == "/")
            {
                a3 = a1 / a2;
            }
            textBox3.Text = a3.ToString();

        }
    }
}
