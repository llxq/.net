using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileStream复制多媒体文件
{
    class Program 
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\Administrator\Desktop\C# 学习视频\1\1、.Net平台 .avi";
            string targe = @"C:\Users\Administrator\Desktop\复制的.avi";
            Copyfile(source, targe);
            Console.WriteLine("复制成功！");
            Console.ReadKey();
        }
        public static void Copyfile(string source, string target)
        {
            //读取文件
            using (FileStream fileread = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                using (FileStream filewrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    //定义每次接收的大小
                    byte[] b = new byte[1024 * 1024 * 5];
                    while (true)
                    {
                        //读取文件
                        int r = fileread.Read(b, 0, b.Length);
                        if (r == 0)
                        {
                            break;
                        }
                        //写文件咯
                        filewrite.Write(b, 0, r);
                    }
                }
            }
        }
    }
}
