using System;
using System.Drawing;
using System.Windows.Forms;

namespace 你是不是傻逼
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("没错，你就是傻逼！");
            System.Environment.Exit(0);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width - button2.Width;
            int y = this.ClientSize.Height - button2.Height;
            Random r = new Random();
            button2.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));

        }
        public int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "是";
            i++;
            if (i > 1)
            {
                MessageBox.Show("果然还是傻逼");
                System.Environment.Exit(0);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult D = MessageBox.Show("关闭就能改变你是傻逼的事了？", "嗯哼？", MessageBoxButtons.YesNo);
            switch (D)
            {
                case DialogResult.Yes:
                    MessageBox.Show("傻逼");
                    e.Cancel = true;
                    break;
                case DialogResult.No:
                    MessageBox.Show("这才对嘛");
                    e.Cancel = true;
                    break;
            }
        }
    }
}
