using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace 大项目
{
    public class SqlHelper
    {
        public static readonly string str = ConfigurationManager.ConnectionStrings["conntStr"].ConnectionString;
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] ps)
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    if (ps != null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                con.Dispose();
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        /// <summary>
        /// 查询,返回第一行第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] ps)
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    if (ps != null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                con.Dispose();
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] ps)
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    if (ps != null)
                    {
                        cmd.Parameters.AddRange(ps);
                    }
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                con.Dispose();
                throw ex;
            }
        }
    }
}
