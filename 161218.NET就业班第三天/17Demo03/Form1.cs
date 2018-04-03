using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17Demo03
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

        private void GetResult()
        {
            string strInput = textBox1.Text.ToString();
            lblNumberBits.Text = strInput.Trim().Length.ToString();
            char[] cs = strInput.ToCharArray();
            Array.Reverse(cs);
            string result = new string(cs);
            lblNewNumber.Text = result;
        }

        /// <summary>
        /// 重新计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComputerAgain_Click(object sender, EventArgs e)
        {
            GetResult();
        }
    }
}
