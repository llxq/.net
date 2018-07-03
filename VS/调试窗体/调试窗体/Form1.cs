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

namespace 调试窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection ds()
        {
            //打开数据库
            string counstr = "Server=.;user=sa;pwd=15570104841;database=xscjglxt";
            SqlConnection mycon = new SqlConnection(counstr);
            return mycon;
        }
        private string user()
        {
            SqlConnection mycon = ds();
            mycon.Open();
            string str = "Select 用户名 from 用户信息表";
            SqlCommand sqcomm = new SqlCommand(str,mycon);
            return sqcomm.ToString();
        }

        private string pwd()
        {
            SqlConnection mycon = ds();
            mycon.Open();
            string str = "Select 密码 from 用户信息表";
            SqlDataAdapter da = new SqlDataAdapter(str, mycon);
            string user = da.ToString();
            return user;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == user() && textBox2.Text == pwd())
            //{
            //    MessageBox.Show("登录成功！", "登录提示");
            //}
            //else
            //{
            //    MessageBox.Show("登录失败！\n请输入正确用户名或密码！", "错误提示");
            //    textBox1.Text = "";
            //    textBox2.Text = "";
            //}



            if (textBox1.Text.Trim() != "")
            {
                if (Convert.ToInt32(textBox1.Text) > 100)
                {

                }
            }




            MessageBox.Show(pwd());
            MessageBox.Show(user());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.Text = DateTime.Now.ToString("HH:mm:ss");
            string s = DateTime.Now.ToString("HH:mm:ss");
            s = numericUpDown1.Value.ToString();
        }
    }
}
