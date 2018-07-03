using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123456")
            {
                Menuclass m = new Menuclass();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败！", "登录提示");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("是否退出程序？", "提示", MessageBoxButtons.YesNo);
            switch (d)
            {
                case DialogResult.Yes:
                    System.Environment.Exit(0);
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
