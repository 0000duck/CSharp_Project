using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16Demo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComputer_Click(object sender, EventArgs e)
        {
            GetResult();

        }
        /// <summary>
        /// 结果
        /// </summary>
        private void GetResult()
        {
            try
            {
                double sum = 0;
                double k = 0;
                //s=m+mm+mmm+mmmm+mmmmm m=3
                //  3+33+333+3333+33333
                int jiwei = Convert.ToInt32(textBox1.Text);
                int weishu = Convert.ToInt32(textBox2.Text);
                for (int i = 0; i < weishu; i++)
                {
                    k = k + jiwei * Math.Pow(10, i);
                    sum += k;
                }
                lblResult.Text = sum.ToString();
            }
            catch
            {
                MessageBox.Show("输入有误,请重新输入!", "输入有误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 重新计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComputerAgain_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            lblResult.Text = null;
        }
    }
}
