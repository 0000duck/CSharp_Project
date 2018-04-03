using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 使用GDI绘制验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击更换验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //[1]创建随机数对象
            Random r = new Random();
            string str = null;
            //[2]产生随机数
            for (int i = 0; i < 5; i++)
            {
                int rNum = r.Next(0, 10);
                str += rNum;
            }            
            //[3]创建GDI 对象
            Bitmap bmp = new Bitmap(150,40);
            Graphics g = Graphics.FromImage(bmp);

            //[4]通过循环一个一个的往图片里画随机数
            for (int i = 0; i < 5; i++)
            {
                Point p = new Point(i*20,0);
                string[] fonts = {"微软雅黑","宋体","楷体","隶属","仿宋" };
                Color[] colors={Color.Yellow,Color.Blue,Color.Brown,Color.Red,Color.Blue };
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, 5)], 20, FontStyle.Bold), new SolidBrush(colors[r.Next(0,5)]),p);
            }
            //[5]画线(不要超出图片大小)
            for (int i = 0; i <20; i++)
            {
                Point p1 = new Point(r.Next(0,bmp.Width),r.Next(0,bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                g.DrawLine(new Pen(Brushes.Green), p1,p2);
            }
            //[6]给图片画像素颗粒
            for (int i = 0; i < 500; i++)
            {
                Point p = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
            bmp.SetPixel(p.X, p.Y, Color.Black);
        }
            
            //[7]将图片镶嵌到PictureBox中
            pictureBox1.Image = bmp;//因为bmp继承自picture
            
           
        }
    }
}
