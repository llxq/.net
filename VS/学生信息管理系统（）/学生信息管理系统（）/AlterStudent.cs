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
    public partial class AlterStudent : Form
    {
        public AlterStudent()
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
        private SqlConnection sqlcn()
        {
            string counstr = "Server=172.16.12.105;user=sa;pwd=15570104841;database=xscjglxt";
            SqlConnection mycn = new SqlConnection(counstr);
            return mycn;
        }
        private void AlterStudent_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            this.Text = "修改学生信息";
            groupBox1.Text = "";
            label1.Text = "学号";
            label2.Text = "性别";
            label3.Text = "班级";
            label4.Text = "姓名";
            label5.Text = "出生日期";
            label6.Text = "电话";
            label7.Text = "家庭住址";
            button1.Text = "修改";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("将要关闭窗口，是否继续？！！！！！！", "退出提示", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //id
            string id = textBox7.Text;
            //学号
            string Number = textBox1.Text;
            //性别
            string sex = comboBox1.Text;
            //班级
            string Grade = textBox2.Text;
            //姓名
            string name = textBox4.Text;
            //生日
            string birthday = dateTimePicker1.Value.ToString("yyy-MM-dd");
            //电话
            string phone = textBox6.Text;
            //家庭住址
            string address = textBox3.Text;
            SqlConnection mycn = sqlcn();
            try
            {
                mycn.Open();
                if (textBox7.Text.Trim() != "")
                {
                    //生日
                    if (birthday != DateTime.Now.ToString("yyy-MM-dd"))
                    {
                        string sql1 = "update 学生信息表 set 出生日期='" + birthday + "' where id='" + id + "'";
                        SqlCommand mycom = new SqlCommand(sql1, mycn);
                        mycom.ExecuteNonQuery();
                        dateTimePicker1.Text= dateTimePicker1.Value.ToString("yyy-MM-dd");
                        textBox7.Text = "";
                    }
                    if (textBox1.Text.Trim() != "")
                    {
                        string sql = "update 学生信息表 set 学号='" + Number + "' where id='" + id + "'";
                        SqlCommand mycm = new SqlCommand(sql, mycn);
                        mycm.ExecuteNonQuery();
                        textBox1.Text = "";
                        textBox7.Text = "";
                    }
                    if (comboBox1.Text.Trim() != "")
                    {
                        string sql = "update 学生信息表 set 性别='" + sex + "' where id='" + id + "'";
                        SqlCommand mycm = new SqlCommand(sql, mycn);
                        mycm.ExecuteNonQuery();
                        comboBox1.Text = "";
                        textBox7.Text = "";
                    }
                    if (textBox2.Text.Trim() != "")
                    {
                        string sql = "update 学生信息表 set 班级='" + Grade + "' where id='" + id + "'";
                        SqlCommand mycm = new SqlCommand(sql, mycn);
                        mycm.ExecuteNonQuery();
                        textBox2.Text = "";
                        textBox7.Text = "";
                    }
                    if (textBox4.Text.Trim() != "")
                    {
                        //姓名
                        string sql = "update 学生信息表 set 姓名='" + name + "' where id='" + id + "'";
                        SqlCommand mycm = new SqlCommand(sql, mycn);
                        mycm.ExecuteNonQuery();
                        textBox4.Text = "";
                        textBox7.Text = "";
                    }

                    if (textBox6.Text.Trim() != "")
                    {
                        //电话
                        string sql = "update 学生信息表 set 电话='" + phone + "' where id='" + id + "'";
                        SqlCommand mycm = new SqlCommand(sql, mycn);
                        mycm.ExecuteNonQuery();
                        textBox6.Text = "";
                        textBox7.Text = "";
                    }
                    if (textBox3.Text.Trim() != "")
                    {
                        //家庭住址
                        string sql = "update 学生信息表 set 家庭住址='" + address + "' where id='" + id + "'";
                        SqlCommand mycm = new SqlCommand(sql, mycn);
                        mycm.ExecuteNonQuery();
                        textBox6.Text = "";
                        textBox7.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("请输入查询条件", "错误提示");
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
