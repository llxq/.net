using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Tex()
        {
            for (int i = 0; i < 10000000; i++)
            {
                //Console.WriteLine(i);

                textBox1.Text = i.ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //新建的线程不能访问主线程
            //这个时候我们可以这样解决
            //让应用程序不去检查跨线程访问，也就是取消跨线程访问
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        Thread th;
        private void button1_Click(object sender, EventArgs e)
        {
            //新建线程
             th = new Thread(Tex);
            //将线程设置为后台线程
            th.IsBackground = true;
            //标记这个线程准备就绪，可以随时被执行。具体什么时候执行这个线程
            //由CPU决定
            th.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //在我们关闭程序的时候，我们应该判断新建的线程是否为Null
            //如果为Null，则表明该线程因为某种原因未关闭
            //我们就需要手动给他关闭
            if (th != null)
            {
                //调用这个方法可以终止线程
                th.Abort();
                //当线程被Abort时，不可以在start，
            }
        }
    }
}
