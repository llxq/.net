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

namespace 摇奖机
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
            button1.Text = "开始";
        }
        public bool a;
        private void button1_Click(object sender, EventArgs e)
        {
            if (a == false)
            {
                button1.Text = "暂停";
                a = true;
                Thread th = new Thread(PlayGame);
                th.IsBackground = true;
                th.Start();
            }
            else
            {
                a = false;
                button1.Text = "开始";
            }
        }
        private void PlayGame()
        {
            while (a)
            {
                Random r = new Random();
                //int number = r.Next(0, 10);
                label1.Text = r.Next(0, 10).ToString();
                label2.Text = r.Next(0, 10).ToString();
                label3.Text = r.Next(0, 10).ToString();
            }
        }
    }
}
