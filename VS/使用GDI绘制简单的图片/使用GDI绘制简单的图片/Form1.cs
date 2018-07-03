using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 使用GDI绘制简单的图片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics G = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Green);
            G.DrawLine(pen, new Point(50, 50), new Point(100, 100));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics G = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Yellow);
            Size size = new Size(100, 80);
            G.DrawRectangle(pen, new Rectangle(new Point(50, 80), size));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics G = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Blue);
            Size size = new Size(100, 80);
            G.DrawPie(pen, new Rectangle(new Point(100, 200), size), 80, 60);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics G = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            G.DrawString("傻逼", new Font("宋体", 30, FontStyle.Bold), Brushes.Pink, new Point(50, 100));
        }
    }
}
