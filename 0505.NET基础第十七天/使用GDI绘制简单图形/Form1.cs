﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 使用GDI绘制简单图形
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //一根笔 颜色 一张纸 两点 绘制直线的对象
        }
        /// <summary>
        /// 使用GDI绘制一条直线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //创建GDI对象
            Graphics g = this.CreateGraphics();//new Graphics();
            //创建画笔对象
            Pen pen = new Pen(Brushes.Red );
            //创建两个点
            Point p1 = new Point(30,50);
            Point p2 = new Point(250,250);

            g.DrawLine(pen,p1,p2);
        }
        int i = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            i++;
            label1.Text = i.ToString(); ;
            //创建GDI对象
            Graphics g = this.CreateGraphics();//new Graphics();
            //创建画笔对象
            Pen pen = new Pen(Brushes.Red);
            //创建两个点
            Point p1 = new Point(30, 50);
            Point p2 = new Point(250, 250);

            g.DrawLine(pen, p1, p2);
        }
        /// <summary>
        /// 使用GDI绘制矩形
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            Size size = new System.Drawing.Size(80,80);
            Rectangle rec = new Rectangle(new Point(50,50),size);
            g.DrawRectangle(pen,rec);
        }
        /// <summary>
        /// 使用GDI绘制扇形
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Blue);
            Size size = new System.Drawing.Size(180, 180);
            Rectangle rec = new Rectangle(new Point(150, 150), size);
            g.DrawPie(pen, rec, 60, 60);
        }
        /// <summary>
        /// 使用GDI绘制文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawString("朋朋是最帅的哦",new Font("楷体",30,FontStyle.Underline),Brushes.Black,new Point(300,300));
        }
    }
}
