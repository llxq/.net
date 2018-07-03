using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace 学生信息管理系统
{
    public partial class flmlogin : Form
    {
        public flmlogin()
        {
            InitializeComponent();
        }
        private void flmlogin_Load(object sender, EventArgs e)
        {

            this.Text = "学生成绩管理系统";
            this.IsMdiContainer = true;
            //登录界面
            flmlogin flom1 = new flmlogin();
            flom1.TopMost = true;
            flom1.Show();
            toolStripStatusLabel1.Text = "欢迎使用本系统......";
            toolStripStatusLabel2.Text = "";
            toolStripStatusLabel3.Text = DateTime.Now.ToString();



        }
        private void 关于本系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutcs at = new aboutcs();
            at.Show();
        }
        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //查询学生信息
            frmsqimangestu fg = new frmsqimangestu();
            fg.Show();
        }

        private void 学生信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //添加学生信息
            frmsqladdstu fq = new frmsqladdstu();
            fq.Show();
        }

        private void 学生信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //修改学生信息
            frmsqleditstu edit = new frmsqleditstu();
            edit.Show();
        }

        private void 学生信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //查询学生信息
            frmsqimangestu fg = new frmsqimangestu();
            fg.Show();
        }

        private void 课程信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //课程信息管理 查询  删除
            frmsqlmangcourse mcourse = new frmsqlmangcourse();
            mcourse.Show();
        }

        private void 课程信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //添加课程信息
            frmsqladdcouse addcouse = new frmsqladdcouse();
            addcouse.Show();
        }

        private void 课程信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //修改课程信息
            frmsqleditcourse deitcourse = new frmsqleditcourse();
            deitcourse.Show();
        }

        private void 课程信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //课程信息管理 查询  删除
            frmsqlmangcourse mcourse = new frmsqlmangcourse();
            mcourse.Show();
        }

        private void 成绩管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //成绩管理
            frmsqlmangcourse mangcourse = new frmsqlmangcourse();
            mangcourse.Show();
        }

        private void 删除学生成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //成绩管理
            frmsqlmangcourse mangcourse = new frmsqlmangcourse();
            mangcourse.Show();
        }

        private void 添加学生成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //添加成绩信息
            frmsqladdsource sourceadd = new frmsqladdsource();
            sourceadd.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 学生信息查询ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
    }


