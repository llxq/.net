using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProFactory;
using ProOperation;
using System.IO;

namespace ProCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //首先读取配置文件
            //49 86 75 23
            string[] lines = File.ReadAllLines("Config.txt", Encoding.Default);
            int x = 49;
            int y = 86;
            foreach (string item in lines)
            {
                Button btn = new Button();
                btn.Location = new Point(x, y);
                btn.Size = new Size(75, 23);
                x += 80;
                btn.Click += Btn_Click;
                btn.Text = item;
                this.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //获得简单工厂提供的父类对象
            Button btn = sender as Button;
            int n1 = Convert.ToInt32(textBox1.Text.Trim());
            int n2 = Convert.ToInt32(textBox1.Text.Trim());
            Operation oper = Factory.Getoper(btn.Text, n1, n2);
            label1.Text = oper.GetResult().ToString();
        }
    }
}
