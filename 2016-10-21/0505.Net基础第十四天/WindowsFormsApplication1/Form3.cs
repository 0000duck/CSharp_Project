using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //在窗体3里面拿到窗体1对象  想办法把它传进来
            Test._fr1Test.Close();//Test._fr1Test通过这种方式拿到窗体1对象
        }
    }
}
