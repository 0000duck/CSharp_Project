using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _03_浏览器控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Uri          
            string text = cmbContent.Text;
            Uri uri = new Uri("http://"+text);
            webBrowser1.Url = uri;
        }

    }
}
