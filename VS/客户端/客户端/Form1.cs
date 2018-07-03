using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace 客户端
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///显示文本消息 
        /// </summary>
        /// <param name="str"></param>
        void ShowMsg(string str)
        {
            textBox4.AppendText(str + "\r\n");
        }

        //负责通信的Socket
        Socket socketSend;

        //定义一个dictionary键值对来存放IP地址端口号和负责通信的Socket
        // Dictionary<string, Socket> dc = new Dictionary<string, Socket>();

        /// <summary>
        /// 连接服务端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //创建一个负责通信的Socket
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //获取客户端的IP地址
                IPAddress ip = IPAddress.Parse(Iptxt.Text);
                //端口号
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(Dktxt.Text));
                //连接服务端
                socketSend.Connect(point);
                ShowMsg("连接成功！");
                //创建一个线程去执行接收消息的方法
                Thread th = new Thread(Server);
                th.IsBackground = true;
                th.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 接收服务端发送过来的消息
        /// </summary>
        /// <param name="o"></param>
        void Server()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    if (buffer[0] == 0)
                    {
                        string str = Encoding.Default.GetString(buffer, 1, r - 1);
                        ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + str);
                    }
                    else if (buffer[0] == 1)
                    {
                        SaveFileDialog sf = new SaveFileDialog();
                        sf.Title = "保存文件";
                        sf.Filter = "文本文件|*.txt|所有文件|*.*";
                        sf.ShowDialog(this);
                        using (FileStream fileWrite = new FileStream(sf.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fileWrite.Write(buffer, 1, r - 1);
                        }
                        MessageBox.Show("保存成功！");
                    }
                    else if (buffer[0] == 2)
                    {
                        ZD();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 发送文本消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Default.GetBytes(textBox5.Text);
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            byte[] newbuffer = list.ToArray();
            socketSend.Send(newbuffer);
            ShowMsg("本机发送：" + textBox5.Text);
            textBox5.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 打开文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "请选择需要打开的文件";
            of.Filter = "文本文件|*.txt|所有文件|*.*";
            of.ShowDialog();
            textBox3.Text = of.FileName;
        }
        /// <summary>
        /// 发送文件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            using (FileStream fileRead = new FileStream(textBox3.Text, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fileRead.Read(buffer, 0, buffer.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newbyte = list.ToArray();
                socketSend.Send(newbyte);
            }
        }
        /// <summary>
        /// 震动方法
        /// </summary>
        void ZD()
        {
            for (int i = 0; i < 500; i++)
            {
                this.Location = new System.Drawing.Point(350, 100);
                this.Location = new System.Drawing.Point(380, 130);
            }
        }

        /// <summary>
        /// 发送震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShake_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[1];
                buffer[0] = 2;
                socketSend.Send(buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
