using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 分页
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }
        private int i = 1;
        public int Max = 0;
        private void LoadUserInfo()
        {
            #region 不使用存储过程分页
            string sql = "select UserName, UserPwd from (select * , ROW_NUMBER() over(order by UserId) as num from UserInfo) as T  where T.num between (( @i -1)*4+1) and ( @i *4)";
            string numMax = "select count(*) from UserInfo";
            List<SqlParameter> listps = new List<SqlParameter>();
            SqlParameter ps = new SqlParameter("@i", SqlDbType.NVarChar);
            ps.Value = i;
            listps.Add(ps);
            Max = Convert.ToInt32(SqlHelPer.ExecuteScalar(numMax)) / 4 + 1;
            DataTable dt = SqlHelPer.ExecuteTable(sql, listps.ToArray());
            dgvUserInfo.DataSource = dt;
            dgvUserInfo.AutoGenerateColumns = false;
            lbNum.Text = "当前页数/" + i + "(共" + Max + "页)";
            #endregion

            #region 使用存储过程分页
            //string sql = "declare @count int                                               exec usp_RowNumber @i,4,@count output";
            //string sunMax = "select (CEILING((select COUNT(*) from UserInfo)*1.0/4))";
            //Max = Convert.ToInt32(SqlHelPer.ExecuteScalar(sunMax));
            //List<SqlParameter> listps = new List<SqlParameter>();
            //listps.Add(new SqlParameter("@i", i));
            //System.Data.DataTable dt = SqlHelPer.ExecuteTable(sql, listps.ToArray());
            //dgvUserInfo.DataSource = dt;
            //string sql = "usp_RowNumber";
            //DataTable dt = new DataTable();
            //using (SqlDataAdapter data = new SqlDataAdapter(sql, SqlHelPer.str))
            //{
            //    data.SelectCommand.CommandType = CommandType.StoredProcedure;
            //    data.SelectCommand.Parameters.AddWithValue("@page", 1);
            //    data.SelectCommand.Parameters.AddWithValue("@count",4);
            //    data.SelectCommand.Parameters.AddWithValue("@sumPage",i);
            //    data.Fill(dt);
            //}
            //dgvUserInfo.DataSource =dt;
            //MessageBox.Show(i.ToString());
            #endregion
        }
        private void btnS_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                i = Max;
            }
            else if (i <= Max)
            {
                i--;
            }
            if (i > Max)
            {
                i = 1;
            }
            LoadUserInfo();
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            if (i <= Max)
            {
                i++;
            }
            if (i > Max)
            {
                i = 1;
            }
            LoadUserInfo();
        }
        private void btnShou_Click(object sender, EventArgs e)
        {
            i = 1;
            LoadUserInfo();
        }
        private void btnW_Click(object sender, EventArgs e)
        {
            i = Max;
            LoadUserInfo();
        }
    }
}
