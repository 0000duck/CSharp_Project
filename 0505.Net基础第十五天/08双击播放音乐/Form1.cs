using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace _08双击播放音乐
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //存储音乐文件的全路径
        List<string> listSongs = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //获取音乐文件的全路径
            string[] path = Directory.GetFiles(@"F:\壁纸\music");
            for (int i = 0; i <path.Length; i++)
            {                 
                //获取这个集合当中每一个文件的文件名
                string fileName = Path.GetFileName(path[i]);
                listBox1.Items.Add(fileName);//把文件名给列表了
                listSongs.Add(path[i]);  //把音乐文件的全路径存到listSongs
            }
        }
        /// <summary>
        /// 双击播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //播放音乐
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = listSongs[listBox1.SelectedIndex];
            sp.Play();  
        }
    }
}
