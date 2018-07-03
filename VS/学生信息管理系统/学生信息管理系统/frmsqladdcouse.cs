using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生信息管理系统
{
    public partial class frmsqladdcouse : Form
    {
        public frmsqladdcouse()
        {
            InitializeComponent();
        }
        private Label mylabel(Label mylb)
        {
            mylb.Font = new Font("宋体", 9, FontStyle.Bold);
            return mylb;
        }
        private Button mybt(Button bt)
        {
            bt.Font = new Font("宋体", 9, FontStyle.Bold);
            return bt;
        }
        private void frmsqladdcouse_Load(object sender, EventArgs e)
        {
            this.Text = "添加课程信息";
            groupBox1.Text = "";
            label1.Text = "课程编号";
            label2.Text = "学分";
            label3.Text = "课程名称";
            button1.Text = "添加";
            button2.Text = "取消";
            mylabel(label1);
            mylabel(label2);
            mylabel(label3);
            mybt(button1);
            mybt(button2);
        }
    }
}
