using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace _01复习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //用来存储音乐文件的全路径
        List<string> listSongs = new List<string>();
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //设置对话框的标题
            ofd.Title = "请选择要打开的音乐文件呦亲";
            //设置对话框可以多选
            ofd.Multiselect = true;
            //设置对话框的初始目录
            ofd.InitialDirectory = @"F:\壁纸\music";
            //设置对话框的文件类型
            ofd.Filter = "音乐|*.wav|所有文件|*.*";
            ofd.ShowDialog();

            //获得我们在文件夹中选择所有文件的全路径
            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                //将音乐文件的文件名加载到ListBox中
                listBox1.Items.Add(Path.GetFileName(path[i]));
                //将音乐文件的全路径放到泛型集合里面
                listSongs.Add(path[i]);
            }
        }
        /// <summary>
        /// 实现双击播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         SoundPlayer sp = new SoundPlayer();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {           
            sp.SoundLocation = listSongs[listBox1.SelectedIndex];
            sp.Play();
        }
        /// <summary>
        /// 点击下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            //获得当前选中歌曲的索引
            int index = listBox1.SelectedIndex;
            index++;
            if (index==listBox1.Items.Count)
            {
                index = 0;
            }
            //将改变后的索引重新赋值给我当前选中项的索引
            listBox1.SelectedIndex = index;
            sp.SoundLocation = listSongs[index];
            sp.Play();
        }
        /// <summary>
        /// 点击播放上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            //获得当前选中歌曲的索引
            int index = listBox1.SelectedIndex;
            index--;
            if (index<0)
            {
                index = listBox1.Items.Count-1;
            }
            //将改变后的索引重新赋值给我当前选中项的索引
            listBox1.SelectedIndex = index;
            sp.SoundLocation = listSongs[index];
            sp.Play(); 
        }
    }
}
