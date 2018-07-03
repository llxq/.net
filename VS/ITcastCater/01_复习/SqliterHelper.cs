using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using System.Data;

namespace _01_复习
{
    public static class SqliterHelper
    {
        //连接字符串
        private static readonly string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        //executenonquery方法
        public static int ExecuteNonQuery(string str, params SQLiteParameter[] ps)
        {
            using (SQLiteConnection con = new SQLiteConnection(conStr))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(str, con))
                {
                    con.Open();
                    cmd.Parameters.AddRange(ps);
                    return cmd.ExecuteNonQuery();
                }

            }
        }

        //executescalar方法
        public static object ExecuteScalar(string str, params SQLiteParameter[] ps)
        {
            using (SQLiteConnection con = new SQLiteConnection(conStr))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(str, con))
                {
                    con.Open();
                    cmd.Parameters.AddRange(ps);
                    return cmd.ExecuteScalar();
                }

            }

        }

        //datatable方法
        public static DataTable GetTable(string str, params SQLiteParameter[] ps)
        {
            using (SQLiteConnection con = new SQLiteConnection(conStr))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(str, con);
                DataTable dt = new DataTable();
                adapter.SelectCommand.Parameters.AddRange(ps);
                adapter.Fill(dt);
                return dt;
            }
        }
        //executeReader方法
        public static SQLiteDataReader ExecuteReader(string str, SQLiteParameter[] ps)
        {
            using (SQLiteConnection con = new SQLiteConnection(conStr))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(str, con))
                {
                    cmd.Parameters.AddRange(ps);
                    return cmd.ExecuteReader();
                }
            }
        }
    }
}
