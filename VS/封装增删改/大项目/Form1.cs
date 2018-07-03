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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadClassInformation();
            dataGridView1.Rows[0].Selected = false;
        }
        /// <summary>
        /// 显示数据
        /// </summary>
        /// <param name="v"></param>
        private void LoadClassInformation()
        {
            List<ClassInformation> list = new List<ClassInformation>();
            string sql = "select * from 课程信息表";
            using (SqlDataReader reade = SqlHelper.ExecuteReader(sql))
            {
                if (reade.HasRows)
                {
                    while (reade.Read())
                    {
                        list.Add(new ClassInformation()
                        {
                            Id = Convert.ToInt32(reade["id"]),
                            StudentNumber = reade["学号"].ToString(),
                            CNONumber = reade["课程号"].ToString(),
                            CourseId = reade["课程编号"].ToString(),
                            Credit = reade["学分"].ToString()
                        });
                    }
                }
                dataGridView1.DataSource = list;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Rows[0].Selected = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddAndUpdate(1);

        }

        private void btnUpdater_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ClassInformation cf = new ClassInformation();
                cf.StudentNumber = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                cf.CourseId = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cf.CNONumber = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                cf.Credit = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cf.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                ea.obj = cf;
                ShowAddAndUpdate(2);
            }
            else
            {
                MessageBox.Show("请选择要修改的行");
            }
        }
        //注册事件
        public event EventHandler evt;
        EventArg ea = new EventArg();
        private void ShowAddAndUpdate(int a)
        {
            AddAndUptade ap = new AddAndUptade();
            //注册事件  后面这个实质是一个委托
            this.evt += new EventHandler(ap.SetText);
            ap.FormClosing += Ap_FormClosing;
            ea.p = a;
            if (evt != null)
            {
                evt(this, ea);
                ap.Show();
            }
           
        }

        private void Ap_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadClassInformation();
        }
    }
}
