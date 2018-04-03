using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test1_3
{
    public partial class Test1_3 : Form
    {
        public Test1_3()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string strResult;
            strResult = txtName.Text + ",您好!欢迎使用本程序!";
            lblShow.Text = strResult;//显示结果
        } 
    }
}
