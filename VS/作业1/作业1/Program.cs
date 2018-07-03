using System;
using System.Text;
using System.IO;
namespace 作业1
{
    class Program
    {
        static void Main(string[] args)
        {
            //写文档，并且新建文件
            using (FileStream filewrite = new FileStream(@"D:\Exam.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string strwrite = "这是测试";
                byte[] bufer = Encoding.Default.GetBytes(strwrite);
                filewrite.Write(bufer, 0, bufer.Length);
            }

            //读取文件
            using (FileStream fileread = new FileStream(@"D:\Exam.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] b = new byte[1024 * 1024];
                int r = fileread.Read(b, 0, b.Length);
                string strread = Encoding.Default.GetString(b, 0, r);
                Console.WriteLine(strread);
            }

            //复制文档
            File.Copy(@"D:\Exam.txt", @"E:\Exam.txt", true);
            Console.ReadKey();
        }
    }
}
