using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _13Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXianshi_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnYinCang_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
