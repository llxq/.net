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
    public partial class InquireGrade : Form
    {
        public InquireGrade()
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
        private DataSet Ds(string sql)
        {
            SqlConnection mycn = Sqlcn();
            DataSet dds = new DataSet();
            try
            {
                mycn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, mycn);
                da.Fill(dds, "成绩表");
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
        private void InquireGrade_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            this.Text = "成绩管理";
            groupBox1.Text = "查询条件";
            label1.Text = "学号";
            label2.Text = "课程号";
            label3.Text = "课程编号";
            label4.Text = "成绩";
            button1.Text = "查询";
            button2.Text = "删除";
            button3.Text = "取消";
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
            //鼠标释放的时候选中全行
            if (e.Button == MouseButtons.Right)
            {
                _row = e.RowIndex;
                //这一段话的作用是鼠标释放的时候选中整行  可以多选！
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }
        //查询
        private void button1_Click(object sender, EventArgs e)
        {
            //学号
            string Xunmber = textBox1.Text;
            //课程号
            string Name = textBox2.Text;
            //课程编号
            string Knumber = textBox3.Text;
            //成绩
            string Grade = textBox4.Text;
            SqlConnection mycn = Sqlcn();
            try
            {
                mycn.Open();
                if (textBox1.Text.Trim() != "")
                {
                    string sql = "Select * from 成绩表 where 学号='" + Xunmber + "' ";
                    SqlCommand mycm = new SqlCommand(sql, mycn);
                    mycm.ExecuteNonQuery();
                    dataGridView1.DataSource = Ds(sql).Tables[0];
                    textBox1.Text = "";
                }
                if (textBox2.Text.Trim() != "")
                {
                    string sql = "Select * from 成绩表 where 课程号='" + Name + "'";
                    SqlCommand mycm = new SqlCommand(sql, mycn);
                    mycm.ExecuteNonQuery();
                    dataGridView1.DataSource = Ds(sql).Tables[0];
                    textBox2.Text = "";
                }
                if (textBox3.Text.Trim() != "")
                {
                    string sql = "Select * from 成绩表 where 课程编号='" + Knumber + "'";
                    SqlCommand mycm = new SqlCommand(sql, mycn);
                    mycm.ExecuteNonQuery();
                    dataGridView1.DataSource = Ds(sql).Tables[0];
                    textBox3.Text = "";
                }
                if (textBox4.Text.Trim() != "")
                {
                    string sql = "Select * from 成绩表 where 成绩='" + Grade + "'";
                    SqlCommand mycm = new SqlCommand(sql, mycn);
                    mycm.ExecuteNonQuery();
                    dataGridView1.DataSource = Ds(sql).Tables[0];
                    textBox4.Text = "";
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
        private void Button2_Click(object sender, EventArgs e)
        {
            //首先判断否查询了数据
            if (this.dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("请先查询需要删除的数据！！！", "提示");
            }
            else
            {
                //判断是不是选中了行
                if (_row != 1)
                {
                    //是否需要删除
                    if (DialogResult.Yes == MessageBox.Show("是否删除选中的数据？！！！", "删除提示", MessageBoxButtons.YesNo))
                    {
                        //当前选中行的第一个字段的索引值
                        string id = this.dataGridView1.Rows[_row].Cells[0].Value.ToString().Trim();
                        string sql = "delete 成绩表 where id='" + id + "'";
                        SqlConnection mycn = Sqlcn();
                        try
                        {
                            mycn.Open();
                            SqlCommand mycm = new SqlCommand(sql, mycn);
                            mycm.ExecuteNonQuery();
                            //当执行删除之后  DataGridView的数据也应该更新
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
        //取消
        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("将要关闭窗口，是否继续？！！！！", "退出提示", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }


    }
}
