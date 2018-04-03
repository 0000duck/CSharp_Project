using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace _10打开对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            //点击弹出对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //设置对话框的标题
            ofd.Title = "请选择要打开的文件呦亲~";
            //设置对话框可以多选
            ofd.Multiselect = true;
            //设置对话框的初始目录
            ofd.InitialDirectory= @"F:\C#";
            //设置对话框的文件类型
            ofd.Filter = "文本文件|*.txt|媒体文件|*.wmv|图片文件|*.jpg|所有文件|*.*";
            //展示对话框
            ofd.ShowDialog();

            //获得在打开对话框中选中文件的路径
            string path = ofd.FileName;
            if (path=="")
            {
                return;//结束当前方法
            }
            using (FileStream fsRead=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read))
            {
                byte[] buffer = new byte[1024*1024*5];
                int r = fsRead.Read(buffer,0,buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer,0,r);
            }
        }
    }
}
