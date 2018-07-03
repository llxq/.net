using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace 封装2
{
    public class SqlHelper
        {
            public static readonly string str = ConfigurationManager.ConnectionStrings["connt"].ConnectionString;
            /// <summary>
            /// 增删改
            /// </summary>
            /// <param name="sql">SQL语句</param>
            /// <param name="ps">参数数组</param>
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
            /// 返回一个表,
            /// </summary>
            /// <param name="sql"></param>
            /// <param name="ps"></param>
            /// <returns></returns>
            public static DataTable Table(string sql, params SqlParameter[] ps)
            {
               // SqlConnection con = new SqlConnection(str);
                DataTable dt = new DataTable();
                try
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(sql,str))
                    {
                        //con.Open();
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    //con.Close();
                    //con.Dispose();
                }
            }
        }
    }

