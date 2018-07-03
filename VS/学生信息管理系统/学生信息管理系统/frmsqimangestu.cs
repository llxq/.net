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
    public partial class frmsqimangestu : Form
    {
        public frmsqimangestu()
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

        private void frmsqimangestu_Load(object sender, EventArgs e)
        {
            this.Text = "学生信息管理";
            groupBox1.Text = "查询条件";
            label1.Text = "学号";
            label2.Text = "性别";
            label3.Text = "姓名";
            label4.Text = "班级";
            button1.Text = "查询";
            button2.Text = "删除";
            button3.Text = "修改";
            string[] gender = { "男", "女" };
            for (int i = 0; i < 2; i++)
            {
                comboBox1.Items.Add(gender[i]);
            }
            mylabel(label1);
            mylabel(label2);
            mylabel(label3);
            mylabel(label4);
            mybt(button1);
            mybt(button2);
            mybt(button3);

        }
    }
}
