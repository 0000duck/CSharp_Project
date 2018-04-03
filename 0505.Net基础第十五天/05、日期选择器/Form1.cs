using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _05_日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //程序加载的时候 将年份添加到下拉框中
            //获得当前的年份
            int year = DateTime.Now.Year;
            for (int i = year; i >= 1949; i--)
            {
                cboYears.Items.Add(i+"年");
            }
        }
        /// <summary>
        /// 当年分发生改变的时候加载月份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            //添加之前应该清空之前的内容
            cboMouths.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboMouths.Items.Add(i + "月");
            }
        }
        /// <summary>
        /// 当月份发生改变的时候加载几号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboMouths_SelectedIndexChanged(object sender, EventArgs e)
        {
            //添加之前应该清空之前的内容
            cboDays.Items.Clear();
            int day = 0;//定义一个变量来存储天数
            //拿到用户选择的月份  7月
            string strMouth = cboMouths.SelectedItem.ToString().Split(new char[] { '月' }, StringSplitOptions.RemoveEmptyEntries)[0];
            string strYear = cboYears.SelectedItem.ToString().Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];

            int year = Convert.ToInt32(strMouth);
            int mouth = Convert.ToInt32(strYear);

            switch (mouth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: day = 31;
                    break;
                case 2:
                    if ((year%400==0)||year%4==0&&year%100!=0)//满足闰年
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                default: day = 30;
                    break;
            }
            for (int i = 1; i <= day; i++)
            {
                cboDays.Items.Add(i + "日");
            }
        }
    }
}
