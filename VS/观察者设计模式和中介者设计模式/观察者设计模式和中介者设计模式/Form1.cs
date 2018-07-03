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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Myfrm1 f1 = new Myfrm1();
            f1.Show();
            MyFrm2 f2 = new MyFrm2();
            //事件执行
            f1.Sd += f2.SetText;
            //委托执行
            //f1.set += f2.SetText;
            //观察者和中介者普通方法实现
            // f1.masage.Add(f2);
            f2.Show();
            Myfrm3 f3 = new Myfrm3();
            //观察者和中介者普通方法实现
            //f1.masage.Add(f3);
            //委托实现
            //f1.set += f3.SetText;
            //事件实现
            f1.Sd += f3.SetText;
            f3.Show();
        }
    }
}
