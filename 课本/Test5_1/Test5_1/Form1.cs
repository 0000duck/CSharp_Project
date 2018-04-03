using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test5_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        Books[] bs = new Books[5];//创建Book型的数组对象，用来记录5本图书的信息
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Type type = cbbType.SelectedIndex == 0 ? Type.Computer : Type.Novel;


        }

        private void btnCount_Click(object sender, EventArgs e)
        {

        }

        public class Books {
            //私有静态字段，分别统计计算机类和小说类的书目数量
            private static int computer, novel;
            public static int count;//公共静态字段，统计总图书数量
            //公共字段，描述书目信息
            public string title;
            public Type type;
            public double price;
            //构造函数，用来初始化对象
            public Books(string title,Type type,double price) {
                this.title = title;
                this.type = type;
                this.price = price;

            }

        }
    }
}
