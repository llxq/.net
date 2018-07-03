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
    public partial class frmsqlmangcourse : Form
    {
        public frmsqlmangcourse()
        {
            InitializeComponent();
        }

        private void frmsqlmangcourse_Load(object sender, EventArgs e)
        {
            this.Text = "课程信息管理";
            groupBox1.Text = "查询条件";
            label1.Text = "课程编号";
            label2.Text = "课程名称";
            button1.Text = "查询";
            button2.Text = "删除";
            button3.Text = "取消";
            this.label1.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label2.Font = new Font("宋体", 9, FontStyle.Bold);
            this.button1.Font = new Font("宋体", 9, FontStyle.Bold);
            this.button2.Font = new Font("宋体", 9, FontStyle.Bold);
        }
    }
}
