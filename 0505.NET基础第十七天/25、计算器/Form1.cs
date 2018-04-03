using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOper.SelectedIndex = 0;
        }
        /// <summary>
        /// 计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(txtNumber1.Text.ToString());
                int n2 = Convert.ToInt32(txtNumber2.Text.ToString());
                string oper = cmbOper.Text.ToString();
                switch (oper)
                {
                    case "+":
                        lblResult.Text = (n1 + n2).ToString();
                        break;
                    case "-":
                        lblResult.Text = (n1 - n2).ToString();
                        break;
                    case "*":
                        lblResult.Text = (n1 * n2).ToString();
                        break;
                    case "/":
                        lblResult.Text = (n1 / n2).ToString();
                        break;
                    default:
                        MessageBox.Show("请选择正确的操作符");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("请输入正确的数字");
            }
           
        }
    }
}
