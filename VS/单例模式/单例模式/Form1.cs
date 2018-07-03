using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 单例模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Form2 f2 = Form2.Getresult();
                f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Singobject.Getsing().F3 == null)
            {
                Singobject.Getsing().F3 = new Form3();
            }
            Singobject.Getsing().F3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////窗体加载的时候 创建窗体对象
            //Singobject sg = Singobject.Getsing();
            //sg.F3 = new Form3();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Singobject.Getsing().f4 == null)
            {
                Singobject.Getsing().f4 = new Form4();
            }
            Singobject.Getsing().f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Singobject.Getsing().f5 == null)
            {
                Singobject.Getsing().f5 = new Form5();
            }
            Singobject.Getsing().f5.Show();
        }
    }
}
