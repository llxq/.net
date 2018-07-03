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
    public partial class AlterGrade : Form
    {
        public AlterGrade()
        {
            InitializeComponent();
        }
        private SqlConnection sqlcn()
        {
            string counstr = "Server=172.16.12.105;user=sa;pwd=15570104841;database=xscjglxt";
            SqlConnection mycn = new SqlConnection(counstr);
            return mycn;
        }
        private void AlterGrade_Load(object sender, EventArgs e)
        {
            this.Text = "修改成绩信息";
            label1.Text = "学号";
            label2.Text = "课程编号";
            label3.Text = "成绩";
            label4.Text = "课程号";
            button1.Text = "添加";
            button2.Text = "取消";
            this.label1.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label2.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label3.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label4.Font = new Font("宋体", 9, FontStyle.Bold);
            this.button1.Font = new Font("宋体", 9, FontStyle.Bold);
            this.button2.Font = new Font("宋体", 9, FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("将要关闭窗口，是否继续？!!!!!!", "提示", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //主键
            string id = textBox5.Text;
            //学号
            string Number = textBox1.Text;
            //课程编号
            string Bnumber = textBox2.Text;
            //课程号
            string Knumber = textBox4.Text;
            //成绩
            string Grade = textBox3.Text;
            SqlConnection mycn = sqlcn();
            try
            {
                mycn.Open();
                if (textBox5.Text.Trim() == "")
                {
                    MessageBox.Show("请输入查询条件！！！", "错误提示");
                }
                else
                {
                    if (textBox1.Text.Trim() != "")
                    {
                        string sql = "update 成绩表 set 学号='" + Number + "' where id='" + id + "'";
                        SqlCommand mycm = new SqlCommand(sql, mycn);
                        mycm.ExecuteNonQuery();
                        textBox1.Text = "";
                        textBox5.Text = "";
                    }
                    if (textBox2.Text.Trim() != "")
                    {
                        string sql = "update 成绩表 set 课程编号='" + Bnumber + "' where id='" + id + "'";
                        SqlCommand mycm = new SqlCommand(sql, mycn);
                        mycm.ExecuteNonQuery();
                        textBox2.Text = "";
                        textBox5.Text = "";
                    }
                    if (textBox4.Text.Trim() != "")
                    {
                        string sql = "update 成绩表 set 课程号='" + Knumber + "' where id='" + id + "'";
                        SqlCommand mycm = new SqlCommand(sql, mycn);
                        mycm.ExecuteNonQuery();
                        textBox4.Text = "";
                        textBox5.Text = "";
                    }
                    if (textBox3.Text.Trim() != "")
                    {
                        string sql = "update 成绩表 set 成绩='" + Grade + "' where id='" + id + "'";
                        SqlCommand mycm = new SqlCommand(sql, mycn);
                        mycm.ExecuteNonQuery();
                        textBox3.Text = "";
                        textBox5.Text = "";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycn.Close();
            }
        }
    }
}
