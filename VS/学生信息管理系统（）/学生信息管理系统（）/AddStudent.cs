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
    public partial class AddStudent : Form
    {
        public AddStudent()
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
        //调用数据库
        private SqlConnection sqlcn()
        {
            string counstr = "Server=172.16.12.105;user=sa;pwd=15570104841;database=xscjglxt";
            SqlConnection mycn = new SqlConnection(counstr);
            return mycn;
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            this.Text = "添加学生信息";
            groupBox1.Text = "";
            label1.Text = "学号";
            label2.Text = "性别";
            label3.Text = "班级";
            label4.Text = "姓名";
            label5.Text = "生日";
            label6.Text = "电话";
            label7.Text = "家庭住址";
            button1.Text = "添加";
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
        private SqlCommand scm()
        {
            SqlConnection mycn = sqlcn();
            mycn.Open();
            //学号
            string Xnumber = textBox1.Text;
            //性别
            string sex = comboBox1.Text;
            //班级
            string Grade = textBox2.Text;
            //姓名
            string Name = textBox4.Text;
            //生日
            string Birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            //电话
            string Phone = textBox6.Text;
            //家庭住址
            string Address = textBox3.Text;
            //sql语句
            string sql = "insert into 学生信息表 (学号,姓名,性别,出生日期,班级,电话,家庭住址) values ('" + Xnumber + "','" + Name + "','" + sex + "','" + Birthday + "','" + Grade + "','" + Phone + "','" + Address + "')";
            SqlCommand mycm = new SqlCommand(sql, mycn);
            mycm.ExecuteNonQuery();
            return mycm;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox6.Text.Trim() != "")
                {
                    scm();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox6.Text = "";
                    comboBox1.Text = "";
                    dateTimePicker1.Text = DateTime.Now.ToString("yyyy-MM-dd");
                }
                else
                {
                    MessageBox.Show("输入的字符不能为空！！", "错误提示");
                }
            }
            catch (Exception ex)
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
