﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _05Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //当点击开始监听的时候 在服务器端创建一个负责监听IP地址跟端口号的Socket
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;//IPAddress.Parse(txtServer.Text);
                //创建端口号对象
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                //监听
                socketWatch.Bind(point);
                ShowMsg("监听成功,开始监听客户端传来的消息!\r\n若要给客户端发消息,请先选择其IP和端口号呦亲❤");
                //在一个时间点内所能连接的最大的客户数量（类似上厕所5个坑）
                socketWatch.Listen(10);//第十一个来了 就排队              

                Thread th = new Thread(Listen);
                th.IsBackground = true;
                th.Start(socketWatch);
            }
            catch { }                 
        }

        //将远程连接的客户端的IP地址和Socket存入集合中
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        /// <summary>
        /// 等待客户端的连接 并且创建与之通信用的Socket
        /// </summary>
        Socket socketSend;
        void Listen(object o)
        {
            Socket socketWatch = o as Socket;//强转 as 如果能够连接成功返回 否则null
            //等待客户端的连接 并且创建一个负责通信的Socket
            while (true)
            {
                try
                {
                    //负责跟客户端通信的Socket
                    socketSend = socketWatch.Accept();
                    //将远程连接的客户端的IP地址和Socket存入集合中
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    //将远程连接的客户端的IP地址和端口号存储下拉框中
                    cboUsers.Items.Add(socketSend.RemoteEndPoint.ToString());
                    //192.168.15.117 ：连接成功
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");
                    //开启 一个新线程不停的接受客户端发送过来的消息
                    Thread th = new Thread(Recive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
                catch  { }
            }
        }
        /// <summary>
        /// 服务器端不停的接受客户端发送过来的消息
        /// </summary>
        /// <param name="o"></param>
        void Recive(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                try
                {
                    //客户端连接成功后，服务器应该接受客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    //实际接受到的有效字节数
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                }
                catch 
                {}
            }
                         
        }
        private void ShowMsg(string str)
        {
            txtLog.AppendText(str+"\r\n");//追加文本 不覆盖之前的文字
        }
        /// <summary>
        /// 服务器给客户端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string str = txtMsg.Text;
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);//?
                List<byte> list = new List<byte>();
                list.Add(0);
                list.AddRange(buffer);
                //将泛型集合转换为数组
                byte[] newBuffer = list.ToArray();
                //获得用户在下拉框中选中的IP地址
                string ip = cboUsers.SelectedItem.ToString();
                string name = "海之角";//+ DateTime.Now.ToString()                
                dicSocket[ip].Send(newBuffer);
                //dicSocket[ip].Send(newBuffer);


                //不涉及下拉框
                //string str = txtMsg.Text;
                //byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);//?
                //socketSend.Send(buffer);
            }
            catch { }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 选择要发送的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"";
            ofd.Title = "请选择要发送的文件";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();
            txtPath.Text = ofd.FileName;
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            //获得要发送文件的路径
            string path = txtPath.Text;
            if (path=="")
            {
                return;
            }
            using (FileStream fsRead=new FileStream(path,FileMode.Open,FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer,0,buffer.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();
                //???
                dicSocket[cboUsers.SelectedItem.ToString()].Send(newBuffer, 0, r + 1, SocketFlags.None);
            }
        }

        /// <summary>
        /// 发送震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZD_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[1];
                buffer[0] = 2;
                dicSocket[cboUsers.SelectedItem.ToString()].Send(buffer);
            }
            catch { }
           
        }

    }
}
