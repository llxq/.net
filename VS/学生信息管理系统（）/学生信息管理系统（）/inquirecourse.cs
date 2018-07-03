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
    public partial class Inquirecourse : Form
    {
        public Inquirecourse()
        {
            InitializeComponent();
        }
        private Label mylabel(Label mylb)
        {
            mylb.Font = new Font("宋体", 9, FontStyle.Bold);
            return mylb;
        }
        private Button Mybt(Button bt)
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
        //显示数据
        private DataSet Ds(string inquire)
        {
            SqlConnection myc = Sqlcn();
            DataSet dts = new DataSet();
            try
            {
                myc.Open();
                SqlDataAdapter sd = new SqlDataAdapter(inquire, myc);
                sd.Fill(dts, "课程信息表");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myc.Close();
            }
            return dts;
        }
        private void inquirecourse_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            this.Text = "课程信息管理";
            groupBox1.Text = "查询条件";
            label1.Text = "学号";
            label2.Text = "课程号";
            label3.Text = "课程编号";
            label4.Text = "学分";
            button1.Text = "查询";
            button2.Text = "删除";
            button3.Text = "取消";
            mylabel(label1);
            mylabel(label2);
            mylabel(label3);
            mylabel(label4);
            Mybt(button1);
            Mybt(button2);
            Mybt(button3);
        }
        //查询
        private void button1_Click(object sender, EventArgs e)
        {
            //学号
            string Number = textBox1.Text;
            //课程号
            string Knumber = textBox2.Text;
            //课程编号
            string Bnumber = textBox3.Text;
            //学分
            string Xnumber = textBox4.Text;
            SqlConnection mycn = Sqlcn();
            try
            {
                mycn.Open();
                if (textBox1.Text.Trim() != "")
                {
                    string sql = "Select *from 课程信息表 where 学号='" + Number + "'";
                    SqlCommand mycm = new SqlCommand(sql, mycn);
                    mycm.ExecuteNonQuery();
                    dataGridView1.DataSource = Ds(sql).Tables[0];
                    textBox1.Text = "";
                }
                if (textBox2.Text.Trim() != "")
                {
                    string sql = "Select * from 课程信息表 where 课程号='" + Knumber + "'";
                    SqlCommand mycm = new SqlCommand(sql, mycn);
                    mycm.ExecuteNonQuery();
                    dataGridView1.DataSource = Ds(sql).Tables[0];
                    textBox1.Text = "";
                }
                if (textBox3.Text.Trim() != "")
                {
                    string sql = "Select * from 课程信息表 where 课程编号='" + Bnumber + "'";
                    SqlCommand mycm = new SqlCommand(sql, mycn);
                    mycm.ExecuteNonQuery();
                    dataGridView1.DataSource = Ds(sql).Tables[0];
                    textBox1.Text = "";
                }
                if (textBox4.Text.Trim() != "")
                {
                    string sql = "Select * from 课程信息表 where 学分='" + Xnumber + "'";
                    SqlCommand mycm = new SqlCommand(sql, mycn);
                    mycm.ExecuteNonQuery();
                    dataGridView1.DataSource = Ds(sql).Tables[0];
                    textBox1.Text = "";
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
        //设置一个值为当前选择的行的索引值
        public int _row = 1;
        //鼠标单击事件
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _row = e.RowIndex;
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                //this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
            }
        }
        //删除
        private void button2_Click(object sender, EventArgs e)
        {
            #region  重复了
            //学号
            //string Number = textBox1.Text;
            ////课程号
            //string Knumber = textBox2.Text;
            ////课程编号
            //string Bnumber = textBox3.Text;
            ////学分
            //string Xnumber = textBox4.Text;
            //SqlConnection mycn = Sqlcn();
            //try
            //{
            //    mycn.Open();
            //    string sql = "";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    mycn.Close();
            //}
            #endregion
            //首先判断当前表格是否含有数据
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("请先查询要删除的语句！！", "提示");
            }
            else
            {
                //判断是否选中了一行
                if (_row != 1)
                {
                    if (DialogResult.Yes == MessageBox.Show("是否删除选中的数据？", "删除提示", MessageBoxButtons.YesNo))
                    {

                        //获取当前选中行的第一个数的值  其实就是id主键的值
                        string id = this.dataGridView1.Rows[_row].Cells[0].Value.ToString().Trim();
                        //删除数据
                        SqlConnection mycn = Sqlcn();
                        try
                        {
                            mycn.Open();
                            string sql = "delete from 课程信息表 where id='" + id + "'";
                            SqlCommand mycm = new SqlCommand(sql, mycn);
                            mycm.ExecuteNonQuery();
                            dataGridView1.Rows.RemoveAt(_row);
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
                    MessageBox.Show("请单击鼠标右键选择需要删除的行！！！", "提示");
                }
            }
        }
        //取消
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("将要关闭窗口，是否继续？！！！", "退出提示", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }
    }
}
