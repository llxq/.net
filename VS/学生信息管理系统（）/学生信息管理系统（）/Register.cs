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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //连接数据库
            string counstr = "Server=.;user=sa;pwd=15570104841;database=xscjglxt";
            SqlConnection mycon = new SqlConnection(counstr);
            try
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("请输入用户名！", "错误提示");
                    textBox1.Focus();
                }
                else if (textBox2.Text.Trim() == "")
                {
                    MessageBox.Show("请输入密码！", "错误提示");
                    textBox2.Focus();
                }
                else
                {
                    //账号 密码
                    string user = textBox1.Text;
                    string pwd = textBox2.Text;

                    mycon.Open();
                    string sql1 = "Select * from 学生信息表";
                    SqlDataAdapter da = new SqlDataAdapter(sql1, mycon);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "学生信息表");
                    //查询是否存在这个账户
                    string sql = string.Format("Select count(用户名) from 用户信息表 where 用户名='{0}' and 密码='{1}'", user, pwd);
                    SqlCommand mycom = new SqlCommand(sql, mycon);
                    //是否存在第一个值！               
                    int i = Convert.ToInt32(mycom.ExecuteScalar());
                    //大于零则是存在
                    if (i > 0)
                    {
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                    else
                    {
                        MessageBox.Show("账号不存在！", "错误提示");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox1.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycon.Close();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            this.Text = "用户登录";
            label1.Text = "用户名：";
            label2.Text = "密码：";
            button1.Text = "登录";
            button2.Text = "退出";
            this.label1.Font = new Font("宋体", 9, FontStyle.Bold);
            this.label2.Font = new Font("宋体", 9, FontStyle.Bold);
            this.button1.Font = new Font("宋体", 12, FontStyle.Bold);
            this.button2.Font = new Font("宋体", 12, FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("将要关闭程序，是否继续？!!!!!!", "提示", MessageBoxButtons.YesNo))
            {
                System.Environment.Exit(0);
            }
        }
    }
}
