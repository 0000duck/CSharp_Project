using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15Demo01
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
            int digital = 0;//数字
            int character = 0;//字符
            int other = 0;
            int blank = 0;
            string str = textBox1.Text.ToString();
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= '0' && ch[i] <= '9')
                {
                    digital++;
                }
                else if (ch[i] >= 'a' && ch[i] <= 'z' || ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    character++;
                }
                else if (ch[i] == ' ')
                {
                    blank++;
                }
                else
                {
                    other++;
                }
            }
            lblChar.Text = character.ToString();
            lblDigital.Text = digital.ToString();
            lblSpaces.Text = blank.ToString();
            lblOther.Text = other.ToString();
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
