using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace 服务端
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 开始监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //创建监听的Socket，获得IP地址和端口号
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //获取本机的IP地址
                IPAddress ip = IPAddress.Any;

                //创建端口对象
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(Dktxt.Text));

                //开始监听
                socketWatch.Bind(point);
                ShowMsg("监听成功！");

                //设置一次性访问的人数
                socketWatch.Listen(10);

                //接收客户发送过来的消息
                Thread th = new Thread(Listen);
                th.IsBackground = true;
                th.Start(socketWatch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //定义一个接收消息的socket

        Socket socketSend;
        //定义一个键值对集合来存放IP地址端口号还有用来通信的socket
        Dictionary<string, Socket> dc = new Dictionary<string, Socket>();

        /// <summary>
        /// 客户端的连接，创建与之通信的Socket，并且接发消息
        /// </summary>
        /// <param name="o"></param>
        void Listen(object o)
        {
            try
            {
                Socket socketWatch = o as Socket;
                while (true)
                {
                    //接收客户端的连接
                    socketSend = socketWatch.Accept();
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功！");
                    //将连接过来的ip和端口号和通信用的socket存放在这个键值对集合中
                    //再将IP地址和端口号放进comBox中
                    dc.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    comboBox1.Items.Add(socketSend.RemoteEndPoint.ToString());

                    //接收客户端的消息
                    Thread th = new Thread(Server);
                    th.IsBackground = true;
                    th.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 接收消息
        /// </summary>
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
                        sf.Title = "请填写保存名称";
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

        void ShowMsg(string str)
        {
            //追加文本
            Receivetxt.AppendText(str + "\r\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 发送文字消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = Encoding.Default.GetBytes(Sendtxt.Text);
                List<byte> list = new List<byte>();
                list.Add(0);
                list.AddRange(buffer);
                byte[] newbuffer = list.ToArray();
                string str = comboBox1.SelectedItem.ToString();
                dc[str].Send(newbuffer);
                ShowMsg("本机发送：" + Sendtxt.Text);
                Sendtxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "请选择你所需要打开的文件";
            of.Filter = "文本文件|*.txt|所有文件|*.*";
            of.ShowDialog();
            textBox3.Text = of.FileName.ToString();
        }
        /// <summary>
        /// 发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fileRead = new FileStream(textBox3.Text, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    string str = comboBox1.SelectedItem.ToString();
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int r = fileRead.Read(buffer, 0, buffer.Length);
                    List<byte> list = new List<byte>();
                    list.Add(1);
                    list.AddRange(buffer);
                    byte[] newbuffer = list.ToArray();
                    dc[str].Send(newbuffer, 0, r + 1, SocketFlags.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
