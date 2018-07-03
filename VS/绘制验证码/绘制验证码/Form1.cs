using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 绘制验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //产生5个随机数
            string str = null;
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                int rumber = r.Next(0, 10);
                str += rumber;
            }

            //创建GDI对象
            //创建像素位图，这个类继承与Image
            Bitmap bit = new Bitmap(100, 30);
            //创建GDI对象对的时候，我们可以调用FromImage方法来实现图片的绘制
            //FromImage：从指定的Image创建一个Graphics
            Graphics G = Graphics.FromImage(bit);

            //开始画图，通过循环一个一个画
            for (int i = 0; i < 5; i++)
            {
                //定义一个字符串存储字体
                string[] font = { "微软雅黑", "仿宋", "隶书", "楷体", "宋体" };
                //定一个color数组，存放颜色
                Color[] color = { Color.Yellow, Color.Blue, Color.Red, Color.Green, Color.Pink };
                //位置，为了不让他们重叠，应该让他们的间隔一样，也就是横坐标可以一样，但是纵坐标可以不一样
                Point p1 = new Point(i * 18, r.Next(0, 5));

                //开始画图
                //因为color没有重载不能直接调用，这个时候我们可以使用 new SolidBrush   
                G.DrawString(str[i].ToString(), new Font(font[r.Next(0, 5)], 20, FontStyle.Bold), new SolidBrush(color[r.Next(0, 5)]), p1);
            }

            //绘制直线
            for (int i = 0; i < 28; i++)
            {
                //绘制两点的坐标，
                //横纵坐标必须是0到验证码的宽度之间随机
                Point p1 = new Point(r.Next(0, bit.Width), r.Next(0, bit.Height));
                Point p2 = new Point(r.Next(0, bit.Width), r.Next(0, bit.Height));
                //绘制直线
                G.DrawLine(new Pen(Brushes.Green), p1, p2);
            }

            //添加像素颗粒，其实就是那些小点点
            for (int i = 0; i < 250; i++)
            {
                //调用图像bit的一个方法 setpixel,指定像素的颜色
                //需要两个点
                Point p = new Point(r.Next(0, bit.Width), r.Next(0, bit.Height));
                bit.SetPixel(p.X, p.Y,Color.Black);
            }

            //将图片镶嵌在PictureBox中
            pictureBox1.Image = bit;
        }

    }
}









