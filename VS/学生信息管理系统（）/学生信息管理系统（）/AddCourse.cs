using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 学生信息管理系统__
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }
        public SqlConnection sqlcn()
        {
            string counstr = "Server=172.16.12.105;user=sa;pwd=15570104841;database=xscjglxt";
            SqlConnection mycn = new SqlConnection(counstr);
            return mycn;
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            this.Text = "添加课程信息";
            label1.Text = "课程编号";
            label2.Text = "课程号";
            label3.Text = "学分";
            label4.Text = "学号";
            button1.Text = "添加";
            button2.Text = "取消";
            this.label1.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label2.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label3.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label4.Font = new Font("宋体", 9, FontStyle.Bold);
            this.button1.Font = new Font("宋体", 9, FontStyle.Bold);
            this.button2.Font = new Font("宋体", 9, FontStyle.Bold);
        }
        private SqlCommand scm()
        {
            SqlConnection sc = sqlcn();
            //学分
             string Xnumber = textBox3.Text;
            //课程编号
            string Knumber = textBox1.Text;
            //课程号
            string Grade = textBox2.Text;
            //学号
            string name = textBox4.Text;
            sc.Open();
            string sql = "insert into 课程信息表 (学号,课程编号,课程号,学分) values ('"+name+"','"+Knumber+"','"+Grade+"','"+Xnumber+"')";
            SqlCommand mycm = new SqlCommand(sql,sc);
            mycm.ExecuteNonQuery();
            return mycm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")
                {
                    scm();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                else
                {
                    MessageBox.Show("输入的值不能为空！", "错误提示");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcn().Close();
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
