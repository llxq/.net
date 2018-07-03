using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _01_复习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<UserInfo> userinfo = new List<UserInfo>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //C:\Users\Administrator\Desktop
            //"C:\Users\Administrator\Desktop\VS\ITcastCater\01_复习\bin\Debug\ItcastCater.db"
            //连接字符串
            //使用路径 加上版本 version即可
            //放在debug目录下可以使用绝对路径
            #region 手动添加
            //string conStr = @"data source=ItcastCater.db;version=3;";

            ////引入命名空间
            ////创建连接对象
            //using (SQLiteConnection con = new SQLiteConnection(conStr))
            //{
            //    using (SQLiteCommand cmd = new SQLiteCommand("select * from ManagerInfo", con))
            //    {
            //        con.Open();
            //        //用read读取
            //        SQLiteDataReader read = cmd.ExecuteReader();
            //        if (read.HasRows)
            //        {
            //            while (read.Read())
            //            {
            //                userinfo.Add(new UserInfo
            //                {
            //                    Mid = Convert.ToInt32(read["Mid"]),
            //                    Mname = read["Mname"].ToString(),
            //                    Mpwd = read["Mpwd"].ToString(),
            //                    Mtype = read["Mtype"].ToString()
            //                });
            //            }
            //        }
            //    }
            //}
            //dataGridView1.DataSource = userinfo; 
            #endregion
            dataGridView1.DataSource = SqliterHelper.GetTable("select * from ManagerInfo");
        }
    }
}
