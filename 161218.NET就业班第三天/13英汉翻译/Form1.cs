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

namespace _13英汉翻译
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> dic = new Dictionary<string, string>();
        private void Form1_Load(object sender, EventArgs e)
        {           
            string[] contents= File.ReadAllLines("english.txt",Encoding.Default);
            for (int i = 0; i < contents.Length; i++)//由于每行数据都截取 做一个循环
            {
                int index = contents[i].IndexOf(" ");//每行数据第一次出现空格的位置
                string english = contents[i].Substring(0,index);
                string chinese = contents[i].Substring(index+1).Trim();
                //判断
                if (!dic.ContainsKey(english))//如果键不重复就添加
                {
                    dic.Add(english,chinese);
                }
                else//包含就追加
                {
                    //有重复的 累加给英文单词所对应的中文解释
                    //dic[english] += chinese;
                    dic[english] = dic[english] + chinese;
                    //abandon v.抛弃 放弃
                    //abandon v我是凑数的
                }

                #region 麻烦的
                //string[] temp = contents[i].Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                //string chinese = string.Empty;//把第一项干掉后 后面的汉语累加起来(可能有空格)，存在chinese里
                //for (int j = 0; j < temp.Length; j++)
                //{
                //    chinese += temp[j];
                //}
                ////有重复的值,添加之前做一个判断
                //if (!dic.ContainsKey(temp[0]))
                //{
                //    dic.Add(temp[0], chinese);
                //}
                //else
                //{
                //    //有重复的  累加给英文单词所对应的中文解释
                //    dic[temp[0]]+=chinese;
                //}
                #endregion
            }
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                textBox2.Text = "请输入要翻译的单词!!";
            }
            else
            {
                string english = textBox1.Text.ToLower().Trim();
                if (dic.ContainsKey(english))
                {
                    textBox2.Text = dic[english];
                }
                else
                {
                    textBox2.Text = "请下载最新版本的英文词典!!";
                }
            }            
        }
    }
}
