using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 使用委托在窗体间传值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //这个创建对象的时候，在将这个方法赋值给一个委托
            Form2 f2 = new Form2(Gettext);
            f2.Show();
        }

        public void Gettext(string str)
        {
            label1.Text = str;
        }
    }
}
