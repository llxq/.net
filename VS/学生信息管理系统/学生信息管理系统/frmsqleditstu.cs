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
    public partial class frmsqleditstu : Form
    {
        public frmsqleditstu()
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
        private void frmsqleditstu_Load(object sender, EventArgs e)
        {
            this.Text = "修改学生信息";
            groupBox1.Text = "";
            label1.Text = "学号";
            label2.Text = "性别";
            label3.Text = "班级";
            label4.Text = "姓名";
            label5.Text = "生日";
            label6.Text = "电话";
            label7.Text = "家庭住址";
            button1.Text = "修改";
            button2.Text = "取消";
            string[] gender = { "男", "女" };
            for (int i = 0; i < 2; i++)
            {
                comboBox1.Items.Add(gender[i]);
            }
            mylabel(label1);
            mylabel(label2);
            mylabel(label3);
            mylabel(label4);
            mylabel(label5);
            mylabel(label6);
            mylabel(label7);
            mybt(button1);
            mybt(button2);
        }
    }
}
