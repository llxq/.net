using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 登录失败三次锁定用户账户
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("请输入账号！");
                return;
            }
            if (string.IsNullOrEmpty(txtPwd.Text.Trim()))
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            string sql = "select  UserID, UserName, UserPwd, LastErrorDatatime, ErrorNumber from UserInfo where UserName=@UserName";
            UserInfo user = new UserInfo();
            using (SqlDataReader read = SqlHleper.ExecuteReader(sql, new SqlParameter("@UserName", txtName.Text.Trim())))
            {
                if (read.Read())
                {
                    user.UserID = Convert.ToInt32(read["UserID"]);
                    user.UserPwd = read["UserPwd"].ToString();
                    user.LastErrorDatatime = Convert.ToDateTime(read["LastErrorDatatime"]);
                    user.ErrorNumber = Convert.ToInt32(read["ErrorNumber"]);
                    user.UserName = read["UserName"].ToString();
                }
                else
                {
                    MessageBox.Show("账号不存在！");
                    txtName.Text = "";
                    txtPwd.Text = "";
                    txtName.Focus();
                    return;
                }
            }
            int day = DateTime.Now.Subtract(user.LastErrorDatatime).Days;
            int hour = DateTime.Now.Subtract(user.LastErrorDatatime).Hours;
            int minutes = DateTime.Now.Subtract(user.LastErrorDatatime).Minutes;
            int second = DateTime.Now.Subtract(user.LastErrorDatatime).Seconds;
            int time = 900 - (day * 24 * 60 * 60 + hour * 60 * 60 + minutes * 60 + second);
            if (user.UserPwd != txtPwd.Text.Trim().ToString())
            {
                if (user.ErrorNumber < 3 || time <= 0)
                {
                    string updaSql = "update UserInfo set LastErrorDatatime=getdate(),ErrorNumber=ErrorNumber+1 where UserName=@UserName";
                    SqlHleper.ExecuteNonQuery(updaSql, new SqlParameter("@UserName", txtName.Text.Trim()));
                    MessageBox.Show("密码错误!");
                    txtPwd.Text = "";
                    txtPwd.Focus();
                    return;
                }
                if (user.ErrorNumber >= 3 || time >= 0)
                {
                    MessageBox.Show(string.Format("您的账户已被锁定！\n请于{0}秒之后重试！", time.ToString()));
                    return;
                }

            }
            if (user.ErrorNumber < 3 || time <= 0)
            {
                MessageBox.Show("登录成功！");
                string updaSql = "update UserInfo set LastErrorDatatime=getdate(),ErrorNumber=0 where UserID=" + user.UserID;
                SqlHleper.ExecuteNonQuery(updaSql);
            }
            else
            {
                MessageBox.Show(string.Format("您的账户已被锁定！\n请于{0}秒之后重试！", time.ToString()));
            }
        }
        /// <summary>
        /// 设置焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Activated(object sender, EventArgs e)
        {
            txtName.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭当前界面？", "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
