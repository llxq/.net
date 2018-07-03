using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace 登录失败三次锁定账户
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usernamesql = "select  UserID, UserName, UserPwd, LastErrorDatatime, ErrorNumber from UserInfo where UserName=@UserName";
            string userpwdsql = "select  UserID, UserName, UserPwd, LastErrorDatatime, ErrorNumber from UserInfo where UserPwd=@UserPwd ";
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@UserName", txtName.Text.Trim()));
            //int n = SqlHleper.ExecuteNonQuery(sql, list.ToArray());
            bool b = false;
            UserInfo user = new UserInfo();
            using (SqlDataReader readname = SqlHleper.ExecuteReader(usernamesql, list.ToArray()))
            {
                if (readname.Read())
                {
                    list.Add(new SqlParameter("@UserPwd", txtPwd.Text.Trim()));
                    user.UserName = readname["UserName"].ToString();
                    b = true;
                }
            }
            if (b)
            {
                using (SqlDataReader readpwd = SqlHleper.ExecuteReader(userpwdsql, list.ToArray()))
                {
                    if (readpwd.Read())
                    {
                        user.UserID = Convert.ToInt32(readpwd["UserID"]);
                        user.UserPwd = readpwd["UserPwd"].ToString();
                        user.LastErrorDatatime = Convert.ToDateTime(readpwd["LastErrorDatatime"]);
                        user.ErrorNumber = Convert.ToInt32(readpwd["ErrorNumber"]);
                    }
                }
            }

            if (user.UserName != null && user.UserPwd == null/*!SqlHleper.ExecuteReader(username).HasRows*/)
            {
                string updaSql = "update UserInfo set LastErrorDatatime=getdate(),ErrorNumber=ErrorNumber+1 where UserName=@UserName";
                SqlHleper.ExecuteNonQuery(updaSql, new SqlParameter("@UserName", txtName.Text.Trim()));
                MessageBox.Show("密码错误！");
                return;
            }
            else if (user.UserName == null /*SqlHleper.ExecuteReader(userpwd).HasRows*/)
            {
                MessageBox.Show("账号不存在！");
                return;
            }
            if (user.ErrorNumber < 3 || DateTime.Now.Subtract(user.LastErrorDatatime).Minutes > 15)
            {
                MessageBox.Show("登录成功！");
                string updaSql = "update UserInfo set LastErrorDatatime=getdate(),ErrorNumber=0 where UserName=@UserName";
                SqlHleper.ExecuteNonQuery(updaSql, new SqlParameter("@UserName", txtName.Text.Trim()));
            }
            else
            {
                MessageBox.Show("账户被锁定");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { "qwe" };
            MessageBox.Show((string.Join("???", list)).ToString());
        }
    }
}
