using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _0505.NET基础班第十六天
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.InitialDirectory = @"C:\Users\洪佳朋\Desktop\CloudMusic";
            ofd.Multiselect = true;
            ofd.Filter = "音乐文件|*.mp3|所有文件|*.*";
            ofd.ShowDialog();
            //获得我们在文件夹中选择所有文件的全路径
            string[] path = ofd.FileNames;
            for (int i=0; i<path.Length;i++)
            {
                //将音乐文件的文件名加载到ListBox中
                listBox1.Items.Add(Path.GetFileName(path[i]));
            }
        }
    }
}
