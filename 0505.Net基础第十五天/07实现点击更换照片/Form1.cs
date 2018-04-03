using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace _07实现点击更换照片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //用来存储图片文件的全路径
        List<string> list = new List<string>();
        string[] path = Directory.GetFiles(@"F:\壁纸", "*.jpg");
        private void Form1_Load(object sender, EventArgs e)
        {
           
            for (int i = 0; i < path.Length; i++)
            {
                string fileName = Path.GetFileName(path[i]);
                listBox1.Items.Add(fileName);
            }
        }
        /// <summary>
        /// 双击播放图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Image=Image.FromFile(path[listBox1.SelectedIndex]);
        }
    }
}
