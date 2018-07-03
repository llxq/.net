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
    public partial class frmsqladdsource : Form
    {
        public frmsqladdsource()
        {
            InitializeComponent();
        }

        private void frmsqladdsource_Load(object sender, EventArgs e)
        {
            this.Text = "添加成绩信息";
            label1.Text = "学号";
            label2.Text = "课程号";
            label3.Text = "成绩";
            button1.Text = "添加";
            button2.Text = "取消";
            this.label1.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label2.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label3.Font = new Font("宋体", 9, FontStyle.Bold);
            this.button1.Font = new Font("宋体", 9, FontStyle.Bold);
            this.button2.Font = new Font("宋体", 9, FontStyle.Bold);


        }
    }
}
