using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test1_2
{
    public partial class Test1_2 : Form
    {
        public Test1_2()
        {
            InitializeComponent();
        }

        private void Test1_2_Load(object sender, EventArgs e)
        {
            //this代表本窗体
            this.Text = "我的第一个Window程序!很爽";//设置本窗体的标题文字
            Label lblShow = new Label();//创建标签控件
            lblShow.Location = new Point(50,30);//设置标签的显示位置
            lblShow.AutoSize = true;//指定自动缩放标签
            lblShow.Text = "欢迎使用本程序!";//设置显示内容
            this.Controls.Add(lblShow);//将标签控件添加到本窗体中 
        }
    }
}
