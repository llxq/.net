using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace 导出数据
{
    class Program
    {
        static void Main(string[] args)
        {
            string count = "Server=.;user=sa;pwd=15570104841;database=xscjglxt";
            SqlConnection con = new SqlConnection(count);
            try
            {
                con.Open();
                string sql = "select 用户名,密码 from 用户信息表";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //读取数据
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        //判断当前是否有数据
                        if(read.HasRows)
                        using (StreamWriter sw = new StreamWriter("1.txt"))
                        {
                                sw.WriteLine("{0}{1}",read.GetName(0),read.GetName(1));
                                while (read.Read())
                                {
                                    sw.WriteLine("{0}{1}",read[0],read[1]);
                                }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
            Console.WriteLine("导入成功");
            Console.ReadKey();
        }
    }
}
