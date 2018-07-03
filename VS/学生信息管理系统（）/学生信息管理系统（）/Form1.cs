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

namespace 学生信息管理系统__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool a = false;
        public bool b = false;
        public bool ac = false;

        private SqlConnection sqc()
        {
            string counstr = "Server=.;user=sa;pwd=15570104841;database=xscjglxt";
            SqlConnection mycn = new SqlConnection(counstr);
            return mycn;
        }
        private DataSet ds()
        {
            string counstr = "Server=.;user=sa;pwd=15570104841;database=xscjglxt";
            SqlConnection mycn = new SqlConnection(counstr);
            DataSet ds = new DataSet();
            try
            {
                mycn.Open();
                string sql = "Select * from 学生信息表";
                SqlDataAdapter sds = new SqlDataAdapter(sql, mycn);
                sds.Fill(ds, "学生信息表");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycn.Close();
            }
            return ds;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //显示表格
            dataGridView1.DataSource = ds().Tables[0];
            this.Text = "学生成绩管理系统";
            this.IsMdiContainer = true;
            toolStripStatusLabel1.Text = "欢迎使用本系统......";
            toolStripStatusLabel2.Text = "";
            toolStripStatusLabel3.Text = DateTime.Now.ToString();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                System.Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }

        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InquireStudent ist = new InquireStudent();
            ist.Show();
        }

        private void 学生信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent ad = new AddStudent();
            ad.Show();
        }

        private void 学生信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterStudent ast = new AlterStudent();
            ast.Show();
        }

        private void 学生信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InquireStudent ist = new InquireStudent();
            ist.Show();
        }

        private void 课程信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inquirecourse qcs = new Inquirecourse();
            qcs.Show();
        }

        private void 课程信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse ac = new AddCourse();
            ac.Show();
        }

        private void 课程信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterCourse ac = new AlterCourse();
            ac.Show();
        }

        private void 课程信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inquirecourse qcs = new Inquirecourse();
            qcs.Show();
        }

        private void 成绩管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InquireGrade ig = new InquireGrade();
            ig.Show();
        }

        private void 删除学生成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InquireGrade ig = new InquireGrade();
            ig.Show();
        }

        private void 添加学生成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGrade ag = new AddGrade();
            ag.Show();
        }

        private void 关于本系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about at = new about();
            at.Show();
        }
        private DataSet dst()
        {
            SqlConnection mycn = sqc();
            DataSet ds = new DataSet();
            try
            {
                mycn.Open();
                string sql = "Select * from 成绩表";
                SqlDataAdapter sda = new SqlDataAdapter(sql, mycn);
                sda.Fill(ds, "成绩表");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycn.Close();
            }
            return ds;

        }
        private void 显示成绩表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = true;
            b = false;
            ac = false;
            dataGridView1.DataSource = dst().Tables[0];

        }
        private DataSet dsst()
        {
            SqlConnection mycn = sqc();
            DataSet ds = new DataSet();
            try
            {
                mycn.Open();
                string sql = "Select * from 课程信息表";
                SqlDataAdapter sda = new SqlDataAdapter(sql, mycn);
                sda.Fill(ds, "成绩表");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycn.Close();
            }
            return ds;

        }
        private void 显示课程表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b = true;
            a = false;
            ac = false;
            dataGridView1.DataSource = dsst().Tables[0];
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (a == true)
            {
                dataGridView1.DataSource = dst().Tables[0];
            }
            else if (b == true)
            {
                dataGridView1.DataSource = dsst().Tables[0];
            }
            else if (ac == true)
            {
                dataGridView1.DataSource = Studentds().Tables[0];
            }
            else
            {
                dataGridView1.DataSource = Studentds().Tables[0];
            }
        }
        private DataSet Studentds()
        {
            SqlConnection mycn = sqc();
            DataSet ds = new DataSet();
            try
            {
                mycn.Open();
                string sql = "Select * from 学生信息表";
                SqlDataAdapter sda = new SqlDataAdapter(sql, mycn);
                sda.Fill(ds, "学生信息表");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycn.Close();
            }
            return ds;

        }
        private void 显示学生信息表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ac = true;
            a = false;
            b = false;
            dataGridView1.DataSource = Studentds().Tables[0];
        }

        private void 修改学生成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterGrade ag = new AlterGrade();
            ag.Show();
        }
    }
}
