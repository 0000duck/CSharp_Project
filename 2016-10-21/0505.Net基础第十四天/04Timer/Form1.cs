using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace _04Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("你中病毒了，关不掉了吧~~");
            //abcde
          label1.Text=  label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 每隔一秒钟 把当前的时间赋值给Lable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            //11:22分播放音乐  叫我起床
            if (DateTime.Now.Hour==11&&DateTime.Now.Minute==29&&DateTime.Now.Second==50)
            {
                //播放音乐
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"C:\Users\洪佳朋\Desktop\1.wav";
                sp.Play();    
            }
        }

        /// <summary>
        /// 当窗体加载的时候 将当前系统的时间赋值给我们的Lable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }
    }
}
