using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_first_WondowsFrom_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "第1行";
            //progressBar1.PerformStep();
            //progressBar1.Value = 10;          
        }
        int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            label1.Text = "第" + i + "行";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }
    }
}
