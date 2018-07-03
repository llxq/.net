using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 作业
{
    public partial class Menuclass : Form
    {
        public Menuclass()
        {
            InitializeComponent();
        }

        private void Result()
        {
            List<string> aihao = new List<string>();
            foreach (Control c in groupBox2.Controls)
            {
                if (c is CheckBox && ((CheckBox)c).Checked)
                {
                    aihao.Add(c.Text);
                }
            }
            for (int i = 0; i < aihao.Count; i++)
            {
                s = aihao[i] + s + ",";
            }
            MessageBox.Show("姓名：" + textBox1.Text + "\n籍贯：" + comboBox1.Text + "\n性别" + radioButton1.Text + "\n爱好：" + s, "显示结果");
        }
        private void Menuclass_Load(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString();
            toolStripStatusLabel1.Text = "登录账号：admin 登录时间为：" + time + "";

        }

        private void Menuclass_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        public string s;
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Result();
            }
            else if (radioButton1.Checked)
            {
                Result();
            }
            else
            {
                MessageBox.Show("请填写性别！", "提示");
            }
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString();
            toolStripStatusLabel1.Text = "登录账号：admin 登录时间为：" + time + "";
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "" && richTextBox1.Text.Trim() != "")
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的文本", "错误提示");
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "" && richTextBox1.Text.Trim() != "")
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = fontDialog1.Color;
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的文本", "错误提示");
            }
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 显示结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Result();
            }
            else if (radioButton1.Checked)
            {
                Result();
            }
            else
            {
                MessageBox.Show("请填写性别！", "提示");
            }

        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "" && richTextBox1.Text.Trim() != "")
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的文本", "错误提示");
            }
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "" && richTextBox1.Text.Trim() != "")
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionColor = fontDialog1.Color;
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的文本", "错误提示");
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
