using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace 客户端4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Socket socketSend;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //负责通信的Socket
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //获取服务端的IP
                IPAddress ip = IPAddress.Parse(textBox1.Text);

                //端口号
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(textBox2.Text));

                //客户端连接服务器
                //客户端远程连接服务端需要知道这个服务端的IP地址和端口号
                //获得需要连接的远程服务器应用程序的IP地址和端口号
                socketSend.Connect(point);
                ShowMsg("连接成功！");

                //开启一个新的线程不停的接收客户端发送过来的消息
                Thread th = new Thread(Server);
                th.IsBackground = true;
                th.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ShowMsg(string str)
        {
            Receivetxt.AppendText(str + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 震动
        /// </summary>
        void ZD()
        {
            for (int i = 0; i < 500; i++)
            {
                this.Location = new System.Drawing.Point(350,100);
                this.Location = new System.Drawing.Point(380,130);
            }
        }

        /// <summary>
        /// 接收服务端发送过来的消息
        /// </summary>
        private void Server()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    //拿到发送过来的第一个消息
                    //判断发送过来的是什么消息
                    if (buffer[0] == 0)
                    {
                        string str = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + str);
                    }
                    else if (buffer[0] == 1)
                    {
                        SaveFileDialog sf = new SaveFileDialog();
                        sf.Title = "请选择需要保存的路径";
                        sf.Filter = "文本文件|*.txt|所有文件|*.*";
                        sf.ShowDialog(this);
                        using (FileStream fileWriter = new FileStream(sf.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fileWriter.Write(buffer, 1, r - 1);
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
        /// 客户端给服务端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string txt = Sendtxt.Text.Trim();
                byte[] buffer = Encoding.UTF8.GetBytes(txt);
                socketSend.Send(buffer);
                //Sendtxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
