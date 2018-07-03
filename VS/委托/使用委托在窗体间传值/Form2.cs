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
    //声明一个委托对象
    public delegate void DelText(string str);
    public partial class Form2 : Form
    {
        //这个就是用来那个赋值的方法的
        public DelText _de;
        public Form2(DelText de)
        {
            InitializeComponent();
            this._de = de;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //当程序运行到这的时候，这个字段存储的就是那个赋值的方法
            //这个时候直接调用这个方法即可
            _de(textBox1.Text);
        }

    }
}
