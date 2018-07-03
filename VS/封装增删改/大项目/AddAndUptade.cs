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

namespace 大项目
{
    public partial class AddAndUptade : Form
    {
        public AddAndUptade()
        {
            InitializeComponent();
        }
        private int p { get; set; }
        /// <summary>
        /// 触发事件,并且判断是增加还是修改,修改的话传值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SetText(object sender, EventArgs args)
        {
            EventArg ea = args as EventArg;
            this.p = ea.p;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Text = "";
                }
            }
            if (this.p == 1)
            {

            }
            else if (this.p == 2)
            {
                ClassInformation cf = ea.obj as ClassInformation;
                txtId.Text = cf.Id.ToString();
                txtNumber.Text = cf.StudentNumber.ToString();
                txtXf.Text = cf.Credit.ToString();
                txtBh.Text = cf.CourseId.ToString();
                txtKch.Text = cf.CNONumber.ToString();
            }
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //设置焦点
        private void AddAndUptade_Activated(object sender, EventArgs e)
        {
            txtNumber.Focus();
        }
        //提交
        private void btnOk_Click(object sender, EventArgs e)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            ClassInformation cf = new ClassInformation();
            cf.Id = Convert.ToInt32(txtId.Text);
            cf.StudentNumber = txtNumber.Text.ToString();
            cf.CourseId = txtBh.Text.ToString();
            cf.Credit = txtXf.Text.ToString();
            cf.CNONumber = txtKch.Text.ToString();
            SqlParameter[] ps = {
                new SqlParameter("@Number",cf.StudentNumber),
                new SqlParameter("@CourseId",cf.CourseId),
                new SqlParameter("@CNONumber",cf.CNONumber),
                new SqlParameter("@Credit",cf.Credit)
            };
            list.AddRange(ps);
            string sql = "";
            if (p == 2)
            {
                list.Add(new SqlParameter("@id", cf.Id));
                sql = "update 课程信息表 set 学号=@Number,课程编号=@CourseId,课程号=@CNONumber,学分=@Credit where id=@id";
            }
            else if (p == 1)
            {
                sql = "insert into 课程信息表 (学号,课程编号,课程号,学分) values (@StudentNumber,@CourseId,@CNONumber,@Credit)";
            }
            int r = SqlHelper.ExecuteNonQuery(sql, list.ToArray());
            MessageBox.Show(r>0?"操作成功！":"操作失败");
            this.Close();
        }
        /// <summary>
        /// 插入
        /// </summary>
        private void Uapdate()
        {
            string sql = "update 课程信息表 set 学号=@Number,课程编号=@CourseId,课程号=@CNONumber,学分=@Credit where id='" + Convert.ToUInt32(txtId.Text) + "'";
            SqlParameter[] ps = {
                new SqlParameter("@Number", SqlDbType.NVarChar),
                new SqlParameter("@CourseId", SqlDbType.NVarChar),
                new SqlParameter("@CNONumber", SqlDbType.NVarChar),
                new SqlParameter("@Credit", SqlDbType.NVarChar)
            };
            ps[0].Value = txtNumber.Text.ToString();
            ps[1].Value = txtBh.Text.ToString();
            ps[2].Value = txtKch.Text.ToString();
            ps[3].Value = txtXf.Text.ToString();
            SqlHelper.ExecuteNonQuery(sql, ps);
            MessageBox.Show("修改成功！");
        }
        /// <summary>
        /// 增加
        /// </summary>
        private void Add()
        {
            string sql = "insert into 课程信息表 (学号,课程编号,课程号,学分) values (@StudentNumber,@CourseId,@CNONumber,@Credit)";
            SqlParameter[] ps = {
                new SqlParameter("@StudentNumber",txtNumber.Text),
                new SqlParameter("@CourseId", SqlDbType.NVarChar),
                new SqlParameter("@CNONumber", SqlDbType.NVarChar),
                new SqlParameter("@Credit", SqlDbType.NVarChar)
            };
            ps[0].Value = txtNumber.Text.ToString();
            ps[1].Value = txtBh.Text.ToString();
            ps[2].Value = txtKch.Text.ToString();
            ps[3].Value = txtXf.Text.ToString();
            SqlHelper.ExecuteNonQuery(sql, ps);
            MessageBox.Show("添加成功！");
        }
    }
}
