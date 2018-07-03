using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 剪刀石头布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Game(string str)
        {
            PalyGame p = new PalyGame();
            int number1 = p.Player(str);
            lbPlayer.Text = str;
            CpuGame c = new CpuGame();
            int number2 = c.Getcpu();
            lbCpu.Text = c.Fist;
            LbResult.Text= PlayResult.Res(number2,number1).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            Game(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "石头";
            Game(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "布";
            Game(str);
        }
    }
}
