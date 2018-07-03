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
    public partial class InquireStudent : Form
    {
        public InquireStudent()
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
        private SqlConnection Sqlcn()
        {
            string counstr = "Server=172.16.12.105;user=sa;pwd=15570104841;database=xscjglxt";
            SqlConnection mycn = new SqlConnection(counstr);
            return mycn;
        }
        private void InquireStudent_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            this.Text = "学生信息管理";
            groupBox1.Text = "查询条件";
            label1.Text = "学号";
            label2.Text = "性别";
            label3.Text = "姓名";
            label4.Text = "班级";
            button1.Text = "查询";
            button2.Text = "删除";
            button3.Text = "取消";
            string[] gender = { "男", "女" };
            for (int i = 0; i < 2; i++)
            {
                comboBox1.Items.Add(gender[i]);
            }
            mylabel(label1);
            mylabel(label2);
            mylabel(label3);
            mylabel(label4);
            mybt(button1);
            mybt(button2);
            mybt(button3);
        }
        public int _row = 1;
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //鼠标右键选中整行
            if (e.Button == MouseButtons.Right)
            {
                _row = e.RowIndex;
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }
        //取消
        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("将要关闭窗口，是否继续？！！！！", "退出提示", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }
        //显示数据
        private DataSet Ds(string sql)
        {
            SqlConnection mycn = Sqlcn();
            DataSet dds = new DataSet();
            try
            {
                mycn.Open();
                SqlDataAdapter ds = new SqlDataAdapter(sql, mycn);
                ds.Fill(dds, "学生信息表");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycn.Close();
            }
            return dds;
        }
        //查询
        private void button1_Click(object sender, EventArgs e)
        {
            //学号
            string Xnumber = textBox1.Text;
            //性别
            string Sex = comboBox1.Text;
            //姓名
            string Name = textBox2.Text;
            //班级
            string Grade = textBox3.Text;


            SqlConnection mycn = Sqlcn();
            try
            {
                mycn.Open();
                if (textBox1.Text.Trim() != "")
                {
                    string sql = "Select * from 学生信息表 where 学号='" + Xnumber + "'";
                    SqlCommand mycm = new SqlCommand(sql, mycn);
                    mycm.ExecuteNonQuery();
                    dataGridView1.DataSource = Ds(sql).Tables[0];
                    textBox1.Text = "";
                }
                if (comboBox1.Text.Trim() != "")
                {
                    string sql = "Select * from 学生信息表 where 性别='" + Sex + "'";
                    SqlCommand mycm = new SqlCommand(sql, mycn);
                    mycm.ExecuteNonQuery();
                    dataGridView1.DataSource = Ds(sql).Tables[0];
                    comboBox1.Text = "";

                }
                if (textBox2.Text.Trim() != "")
                {
                    string sql = "Select * from 学生信息表 where 姓名='" + Name + "'";
                    SqlCommand mycm = new SqlCommand(sql, mycn);
                    mycm.ExecuteNonQuery();
                    dataGridView1.DataSource = Ds(sql).Tables[0];
                    textBox2.Text = "";
                }
                if (textBox3.Text.Trim() != "")
                {
                    string sql = "Select * from 学生信息表 where 班级='" + Grade + "'";
                    SqlCommand mycm = new SqlCommand(sql, mycn);
                    mycm.ExecuteNonQuery();
                    dataGridView1.DataSource = Ds(sql).Tables[0];
                    textBox3.Text = "";
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

        //删除
        private void button2_Click(object sender, EventArgs e)
        {
            //是否查询了数据
            if (this.dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("请先查询需要删除的数据！！！", "错误提示");
            }
            else
            {
                if (_row != 1)
                {
                    if (DialogResult.Yes == MessageBox.Show("是否删除选中的数据？！！！", "错误提示", MessageBoxButtons.YesNo))
                    {
                        SqlConnection mycn = Sqlcn();
                        try
                        {
                            mycn.Open();
                            string id = this.dataGridView1.Rows[_row].Cells[0].Value.ToString().Trim();
                            string sql = "delete 学生信息表 where id='" + id + "'";
                            SqlCommand mycm = new SqlCommand(sql, mycn);
                            mycm.ExecuteNonQuery();
                            this.dataGridView1.Rows.RemoveAt(_row);
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
                else
                {
                    MessageBox.Show("请单击鼠标右键选择需要删除的行！", "错误提示");
                }
            }
        }
    }
}
