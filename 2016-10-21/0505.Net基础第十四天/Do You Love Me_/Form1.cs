using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Do_You_Love_Me_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnLove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("打死你个龟孙~~");
            this.Close();
        }

        private void btnLove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你呦思密达");
            this.Close();
        }

        private void btnUnLove_MouseEnter(object sender, EventArgs e)
        {
            //给按钮一个新的坐标
            //这个按钮活动的最大宽度就是 窗体的宽度减去按钮的宽度
            int x = this.ClientSize.Width - btnUnLove.Width;
            int y = this.ClientSize.Height - btnUnLove.Height;

            Random r = new Random();
            //给按钮一个随机的坐标
            btnUnLove.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
        }
    }
}
