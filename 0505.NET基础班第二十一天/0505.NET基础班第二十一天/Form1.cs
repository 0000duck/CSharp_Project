using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0505.NET基础班第二十一天
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //程序加载的时候，取消自动播放
            musicPlayer.settings.autoStart = false;
        }
        //bool btnFlag = true;
        private void btnPlayOrPause_Click(object sender, EventArgs e)
        {
            #region 普通按钮点击事件 
            //if (btnFlag == true)
            //{
            //    musicPlayer.Ctlcontrols.play();
            //    btnFlag = false;
            //    btnPlayOrPause.Text = "暂停";
            //}
            //else
            //{
            //    musicPlayer.Ctlcontrols.pause();
            //    btnFlag = true;
            //    btnPlayOrPause.Text = "播放";
            //}

            //if (btnPlayOrPause.Text == "播放")
            //{
            //    if (btnFlag)
            //    {
            //        try
            //        {
            //            //获得选中的歌曲  让音乐从头播放
            //            musicPlayer.URL = listPath[listBox1.SelectedIndex];
            //        }
            //        catch { }                                      
            //    }   
            //        musicPlayer.Ctlcontrols.play();
            //        btnPlayOrPause.Text = "暂停";                  
            //}
            //else
            //{
            //    musicPlayer.Ctlcontrols.pause();
            //    btnPlayOrPause.Text = "播放";
            //    btnFlag = false;
            //}
            #endregion
        }
        bool btnFlag = true;
        bool b = true;
        /// <summary>
        /// 播放或暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbPlayOrPause_Click(object sender, EventArgs e)
        {

            #region
            //if (btnFlag == true)
            //{
            //    musicPlayer.Ctlcontrols.play();
            //    btnFlag = false;
            //    btnPlayOrPause.Text = "暂停";
            //}
            //else
            //{
            //    musicPlayer.Ctlcontrols.pause();
            //    btnFlag = true;
            //    btnPlayOrPause.Text = "播放";
            //}
            #endregion
            if (btnFlag)
            {
                if (b)
                {
                    try
                    {
                        //获得选中的歌曲  让音乐从头播放
                        musicPlayer.URL = listPath[listBox1.SelectedIndex];
                    }
                    catch { }
                }
                btnFlag = false;
                musicPlayer.Ctlcontrols.play();
                btnPlayOrPause.Text = "暂停";
                //跟换图片
                pbPlayOrPause.BackgroundImage = Image.FromFile(@"E:\visual studio 2015\Projects\0505.NET基础班第二十一天\0505.NET基础班第二十一天\images\暂停.png");
                //播放动画
                //while (true)
                //{
                //    this.pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                //    this.pictureBox1.Refresh();
                //}
                //Image image = (Image)this.pictureBox1.Image;
                //image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                //this.pictureBox1.Image = image;
            }
            else
            {
                musicPlayer.Ctlcontrols.pause();
                btnPlayOrPause.Text = "播放";
                btnFlag = true;
                b = false;
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
        }
        //存储音乐文件的全路径
        List<string> listPath = new List<string>();
        /// <summary>
        /// 打开对话框 选择音乐文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"E:\CloudMusic";
            ofd.Filter = "mp3文件|*.mp3|音乐文件|*.wav|所有文件|*.*";
            ofd.Title = "请选择音乐文件呦亲";
            ofd.Multiselect = true;//多选
            ofd.ShowDialog();

            //获得在文本框中选择文件的全路径
            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                //将音乐文件的全路径存储到泛型集合中
                listPath.Add(path[i]);

                //将音乐文件的文件名存储到listBox中
                listBox1.Items.Add(Path.GetFileName(path[i]));
            }
        }
        /// <summary>
        /// 双击播放对应的音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("请先选择音乐文件");
                return;//结束本次双击事件
            }
            try
            {
                musicPlayer.URL = listPath[listBox1.SelectedIndex];
                musicPlayer.Ctlcontrols.play();
                btnPlayOrPause.Text = "暂停";
                lblInformation.Text = musicPlayer.Ctlcontrols.currentPosition.ToString();
                //
                IsExistLrc(listPath[listBox1.SelectedIndex]);//()全路径
            }
            catch { }
        }
        /// <summary>
        /// 下一曲方法
        /// </summary>
        private void NextSong()
        {
            //获得当前选中项的索引
            int index = listBox1.SelectedIndex;

            //清空所有选中项的索引
            listBox1.SelectedIndices.Clear();

            index++;
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            try
            {
                //将改变后的索引重新的赋值给当前选中项的索引
                listBox1.SelectedIndex = index;
                musicPlayer.URL = listPath[index];
                musicPlayer.Ctlcontrols.play();
            }
            catch { }
        }

        /// <summary>
        /// 点击删除选中项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //先删集合还是先删列表呢？

            //首先获得要删除的歌曲的数量
            int count = listBox1.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                //先删除集合
                listPath.RemoveAt(listBox1.SelectedIndex);
                //再删列表
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        /// <summary>
        /// 调高声音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTurnUp_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume += 5;
            // MessageBox.Show(musicPlayer.settings.volume.ToString());
        }
        /// <summary>
        /// 减小声音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTurnDown_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume -= 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //如果播放器的状态等于正在播放中
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                lblInformation.Text = musicPlayer.currentMedia.duration.ToString() + "\r\n" + musicPlayer.currentMedia.durationString + "\r\n" + musicPlayer.Ctlcontrols.currentPosition.ToString() + "\r\n" + musicPlayer.Ctlcontrols.currentPositionString;
            }

            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                lblInformation.Text = musicPlayer.currentMedia.duration.ToString() + "\r\n" + musicPlayer.currentMedia.durationString + "\r\n" + musicPlayer.Ctlcontrols.currentPosition.ToString() + "\r\n" + musicPlayer.Ctlcontrols.currentPositionString;

                double d1 = double.Parse(musicPlayer.currentMedia.duration.ToString());

                double d2 = double.Parse(musicPlayer.Ctlcontrols.currentPosition.ToString()) + 1;

                if (d1 <= d2)
                {
                    NextSong();
                }
            }
        }

        //开始做歌词
        void IsExistLrc(string songPath)
        {
            //清空两个集合里面的内容。不然下一首歌还是上一首歌的歌词
            //listLrcText.Clear();
            //listPath.Clear();
            songPath += ".lrc";
            if (File.Exists(songPath))
            {
                //读取歌词文件
                string[] lrcText = File.ReadAllLines(songPath, Encoding.Default);
                //格式化歌词
                FormatLrc(lrcText);
            }
            else//不存在歌词
            {
                lblSongText.Text = "----未找到歌词----";
            }
        }
        //存储时间
        List<double> listTime = new List<double>();
        //存储歌词
        List<string> listLrcText = new List<string>();
        /// <summary>
        /// 格式化歌词
        /// </summary>
        /// <param name="lrcText"></param>
        void FormatLrc(string[] lrcText)
        {
            for (int i = 0; i < lrcText.Length; i++)
            {
                //[00:15.57]当我和世界不一样
                string[] lrcTemp = lrcText[i].Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                //00:15.57   lrcTemp[0]
                //当我和世界不一样 lrcTemp[1]
                string[] lrcNewTemp = lrcTemp[0].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                //00 lrcNewTemp[0]
                //15.57 lrcNewTemp[1]
                double time = double.Parse(lrcNewTemp[0]) * 60 + double.Parse(lrcNewTemp[1]);
                //把截取出来的时间加到泛型集合中
                listTime.Add(time);
                //把这个时间所对应的歌词存到泛型集合中
                listLrcText.Add(lrcTemp[1]);
            }
        }
        /// <summary>
        /// 播放歌词
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                //遍历集合拿到每一个时间
                for (int i = 0; i < listTime.Count; i++)
                {
                    if (musicPlayer.Ctlcontrols.currentPosition >= listTime[i] && musicPlayer.Ctlcontrols.currentPosition < listTime[i + 1])
                    {
                        lblSongText.Text = listLrcText[i];
                    }
                }
            }
            catch { }
        }
        /// <summary>
        /// 上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnUp_Click(object sender, EventArgs e)
        {
            UpSong();
        }
        /// <summary>
        /// 上一曲方法
        /// </summary>
        private void UpSong()
        {
            //获得当前选中项的索引
            int index = listBox1.SelectedIndex;

            //清空所有选中项的索引
            listBox1.SelectedIndices.Clear();

            index--;
            if (index < 0)
            {
                index = listBox1.Items.Count - 1;
            }
            try
            {
                //将改变后的索引重新的赋值给当前选中项的索引
                listBox1.SelectedIndex = index;
                musicPlayer.URL = listPath[index];
                musicPlayer.Ctlcontrols.play();
            }
            catch { }
        }

        /// <summary>
        /// 下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBtnDown_Click(object sender, EventArgs e)
        {
            NextSong();
        }
        /// <summary>
        /// 上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbUp_Click(object sender, EventArgs e)
        {
            UpSong();
        }
        /// <summary>
        /// 下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbNext_Click(object sender, EventArgs e)
        {
            NextSong();
        }
    }
}
