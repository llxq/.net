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
    public partial class AlterCourse : Form
    {
        public AlterCourse()
        {
            InitializeComponent();
        }
        private SqlConnection sqlcn()
        {
            string counstr = "Server=172.16.12.105;user=sa;pwd=15570104841;database=xscjglxt";
            SqlConnection mycn = new SqlConnection(counstr);
            return mycn;
        }
        private void AlterCourse_Load(object sender, EventArgs e)
        {
            textBox5.Focus();
            this.Text = "修改课程信息";
            groupBox1.Text = "";
            label1.Text = "课程编号";
            label2.Text = "课程号";
            label3.Text = "学分";
            label5.Text = "学号";
            button1.Text = "修改";
            button2.Text = "取消";
            this.label1.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label2.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label3.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label5.Font = new Font("宋体", 9, FontStyle.Bold);
            this.button1.Font = new Font("宋体", 9, FontStyle.Bold);
            this.button2.Font = new Font("宋体", 9, FontStyle.Bold);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //课程编号
            string Knumber = textBox1.Text;
            //课程号
            string Grade = textBox2.Text;
            //学分
            string Number = textBox3.Text;
            //学号
            string name = textBox5.Text;
            //id
            string id = textBox4.Text;

            #region if语句


            //else if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            //{
            //    string sql = "Update 课程信息表 set  课程编号='" + Knumber + "',课程号='" + Grade + "' where id='" + id + "'";
            //    SqlCommand mycom = new SqlCommand(sql, mycn);
            //    mycom.ExecuteNonQuery();
            //}
            //else if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")
            //{
            //    string sql = "Update 课程信息表 set  课程编号='" + Knumber + "',课程号='" + Grade + "',学分='" + Number + "' where id='" + id + "'";
            //    SqlCommand mycom = new SqlCommand(sql, mycn);
            //    mycom.ExecuteNonQuery();
            //}
            //else if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox5.Text.Trim() != "" && textBox4.Text.Trim() == "")
            //{
            //    string sql = "Update 课程信息表 set  课程编号='" + Knumber + "',课程号='" + Grade + "',学分='" + Number + "',学号='" + name + "' where id='" + id + "'";
            //    SqlCommand mycom = new SqlCommand(sql, mycn);
            //    mycom.ExecuteNonQuery();
            //}
            #endregion
            SqlConnection mycn = sqlcn();
            try
            {
                mycn.Open();
                if (textBox4.Text.Trim() == "")
                {
                    MessageBox.Show("请输入查询条件！！！", "错误提示");
                }
                else
                {
                    if (textBox1.Text.Trim() != "")
                    {
                        string sql = "Update 课程信息表 set  课程编号='" + Knumber + "' where id='" + id + "'";
                        SqlCommand mycom = new SqlCommand(sql, mycn);
                        mycom.ExecuteNonQuery();
                        textBox1.Text = "";
                        textBox4.Text = "";
                    }
                    if (textBox2.Text.Trim() != "")
                    {
                        string sql = "Update 课程信息表 set  课程号='" + Grade + "' where id='" + id + "'";
                        SqlCommand mycom = new SqlCommand(sql, mycn);
                        mycom.ExecuteNonQuery();
                        textBox2.Text = "";
                        textBox4.Text = "";
                    }
                    if (textBox3.Text.Trim() != "")
                    {
                        string sql = "Update 课程信息表 set  学分='" + Number + "' where id='" + id + "'";
                        SqlCommand mycom = new SqlCommand(sql, mycn);
                        mycom.ExecuteNonQuery();
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }
                    if (textBox5.Text.Trim() != "")
                    {
                        string sql = "Update 课程信息表 set  学号='" + name + "' where id='" + id + "'";
                        SqlCommand mycom = new SqlCommand(sql, mycn);
                        mycom.ExecuteNonQuery();
                        textBox5.Text = "";
                        textBox4.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("将要关闭窗口，是否继续？!!!!!!", "提示", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }
    }
}
