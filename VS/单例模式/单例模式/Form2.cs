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
    public partial class Form2 : Form
    {
        //创建一个全局变量
        public static Form2 Getf2 = null;
        private Form2()
        {
            InitializeComponent();
        }

        //新建一个方法，返回一个对象
        public static Form2 Getresult()
        {
            if (Getf2 == null)
            {
                Getf2 = new Form2();
            }
            return Getf2;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Getf2 = new Form2();
        }
    }
}
