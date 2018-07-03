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
    public partial class frmsqleditcourse : Form
    {
        public frmsqleditcourse()
        {
            InitializeComponent();
        }

        private void frmsqleditcourse_Load(object sender, EventArgs e)
        {
            this.Text = "修改课程信息";
            groupBox1.Text = "";
            label1.Text = "课程编号";
            label2.Text = "课程名称";
            label3.Text = "学分";
            button1.Text = "修改";
            button2.Text = "取消";
            this.label1.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label2.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label3.Font = new Font("宋体", 9, FontStyle.Bold);
            this.button1.Font = new Font("宋体", 9, FontStyle.Bold);
            this.button2.Font = new Font("宋体", 9, FontStyle.Bold);

        }
    }
}
