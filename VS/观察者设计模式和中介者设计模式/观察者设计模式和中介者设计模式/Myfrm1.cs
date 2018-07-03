using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 观察者设计模式和中介者设计模式
{
    public delegate void SetTextDel(string str);
    public partial class Myfrm1 : Form
    {
        public Myfrm1()
        {
            InitializeComponent();
            this.masage = new List<IMassage>();
        }
        //委托
        public SetTextDel set { set; get; }
        //事件
        public event SetTextDel Sd;
        public List<IMassage> masage { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            //事件执行
            Sd(this.textBox1.Text.ToString());
            //委托执行
            //set(this.textBox1.Text.ToString());
            //普通方法执行
            foreach (IMassage item in masage)
            {
                item.SetText(this.textBox1.Text.ToString());
            }
        }
    }
}
