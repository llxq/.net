using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace 创建和客户端通信的Socket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        Thread th;
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //首先创建一个负责监听的socket
                //它监听的是本机的应用程序的端口号，但是这个端口号中包含本机的IP地址
                //监听的目的是：等待客户端连接过来
                //当我监听到了客户端发送过来的请求的时候，创建一个负责通信的socket
                //负责通信的socket是来自：负责监听的socket调用Accept()方法得到的
                //写在一个循环是因为，一个服务器段有可能有很多个客户端连接过来
                //我们应该为每一个客户端创建一个负责通信的socket
                //因为Accept会使用主线程去等待接收客户端连接，使得程序假死
                //这个时候我们可以把他写进一个方法中，然后创建一个新的线程去执行他


                //当点击开始监听的时候，在服务器端创建一个负责监听IP地址和端口号的Socket
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //侦听本机所有的IP地址的对应端口（本机可能有多个IP或者一个IP）
                //这是一个只读字段
                IPAddress ip = IPAddress.Any;
                //IPAddress.Parse(textBox1.Text);

                //创建端口对象
                //textBox2：端口
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(textBox2.Text));

                //监听
                socketWatch.Bind(point); //绑定端口号
                //showMsg("监听成功");
                ShowMsg("监听成功");

                //设置一次性访问的人数
                socketWatch.Listen(10);
                //因为主线程在接收客户端，所以需要写一个线程去执行
                th = new Thread(Listen);
                th.IsBackground = true;
                th.Start(socketWatch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowMsg(string str)
        {
            Receivetxt.AppendText(str + "\r\n");
        }
        //新建一个键值对集合，存放对应IP地址的socket
        Dictionary<string, Socket> dc = new Dictionary<string, Socket>();

        Socket socketSend;
        /// <summary>
        /// 接收客户端的请求，并且创建一个负责通信的Socket，等待与客户端的连接
        /// </summary>
        /// <param name="o"></param>
        private void Listen(object o)
        {
            try
            {
                Socket socketWatch = o as Socket;
                //因为需要实现多次访问
                while (true)
                {
                    //等待客户端的连接   接收客户端的请求,并且创建一个负责通信的Socket
                    //返回的这个socket类型变量是负责通信的
                    socketSend = socketWatch.Accept();

                    //将连接的用户的IP地址端口号和Socket存放子这个键值对集合中
                    dc.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    //将IP地址和端口号添加经ComtextBox
                    comboBox1.Items.Add(socketSend.RemoteEndPoint.ToString());

                    //拿到远程连接的客户端的端口号和IP地址
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功！");

                    //使用线程去执行这个循环
                    Thread td = new Thread(JS);
                    td.IsBackground = true;
                    td.Start(socketSend);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 服务端不停的接收客户端发送过来的消息
        /// </summary>
        /// <param name="o"></param>
        void JS(object o)
        {
            try
            {
                Socket socketSend = o as Socket;
                while (true)
                {
                    //客户端连接成功之后，服务器应该接收客户端发送过来的消息
                    byte[] buffer = new byte[1024 * 1025 * 5];
                    //实际接收的大小
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    //显示信息
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ':' + str);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //让新线程访问主线程创建的程序
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        /// <summary>
        /// 服务器给客户端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string str = Sendtxt.Text.Trim();
                byte[] buffer = Encoding.UTF8.GetBytes(str);

                //我们可以在发送消息的时候再添加一位，通过添加的这个来判断发送的是什么消息
                //定义一个泛型集合来存储要发送的消息，因为集合的长度是可变的
                List<byte> List = new List<byte>();
                List.Add(0);
                List.AddRange(buffer);
                byte[] newbyte = List.ToArray();
                //socketSend.Send(buffer);
                string ip = comboBox1.SelectedItem.ToString();
                dc[ip].Send(newbyte);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = textBox3.Text;
                using (FileStream fileRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    byte[] buffer = new byte[1024 * 102 * 5];
                    int r = fileRead.Read(buffer, 0, buffer.Length);
                    List<byte> list = new List<byte>();
                    list.Add(1);
                    list.AddRange(buffer);
                    byte[] newbyte = list.ToArray();
                    //comboBox1.SelectedItem：下拉框当前选中项
                    dc[comboBox1.SelectedItem.ToString()].Send(newbyte, 0, r + 1, SocketFlags.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 选择发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Title = "选择要发送的文件";
                of.Filter = "所有文件|*.*";
                of.ShowDialog();
                textBox3.Text = of.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 发送震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[1];
                buffer[0] = 2;
                dc[comboBox1.SelectedItem.ToString()].Send(buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
