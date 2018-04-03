using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 实训4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Time t = new Time();
            txtboxHour.Text = t.hour.ToString();
            txtboxMinute.Text = t.minute.ToString();
            txtboxSecond.Text = t.second.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Time t = new Time();
            t.AddSecond();
            txtboxHour.Text = t.hour.ToString();
            txtboxMinute.Text = t.minute.ToString();
            txtboxSecond.Text = t.second.ToString();
        }

        class Time {
            public int hour;
            public int minute;
            public int second;
            public Time() {
                hour = System.DateTime.Now.Hour;
                minute = System.DateTime.Now.Minute;
                second = System.DateTime.Now.Second;
            }
            public Time(int h,int m,int s) {
                hour = h;
                minute = m;
                second = s;
            }
            

            public void AddSecond() {
                second++;
                if (second >= 60) {
                    second = second % 60;
                    minute++;
                }
                if (minute>=60) {
                    minute = minute % 60;
                    hour++;
                }
            }
        }

        private void txtboxHour_TextChanged(object sender, EventArgs e)
        {
          
        }

    }
}
