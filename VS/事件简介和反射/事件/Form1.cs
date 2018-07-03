using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            //创建事件
            btn.Location = new Point(80,80);
            btn.Size = new Size(100,40);
            btn.Text = "这个是动态添加的按钮";
            btn.Click += Btn_Click;
            btn.Click += Btn1_Click1;
            this.Controls.Add(btn);
        }

        private void Btn1_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("这个是第二个动态添加的事件");
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这个是点击的第一下111111111");
        }
    }
}
