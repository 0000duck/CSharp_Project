﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _07获取当前时间
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string nowTime= DateTime.Now.ToString();
            string strMsg = txtMsg.Text;
            txtChatLog.Text = nowTime+strMsg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMsg.Focus();
        }
    }
}
