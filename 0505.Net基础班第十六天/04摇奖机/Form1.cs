using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _04摇奖机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool b = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (b==false)
            {
                btnStart.Text = "暂停";
                Thread th = new Thread(PlayGame);
                th.IsBackground = true;
                th.Start();
                b =true;
            }
            else
            {
                b = false;
                btnStart.Text = "开始";  
            }
                
        }
        private void PlayGame()
        {
            Random r = new Random();
            while (b)
            {
                label1.Text = r.Next(0, 100).ToString();
                label2.Text = r.Next(0, 100).ToString();
                label3.Text = r.Next(0, 100).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //在程序加载的时候取消跨线程的检查
            Control.CheckForIllegalCrossThreadCalls = false;            
        }
    }
}
