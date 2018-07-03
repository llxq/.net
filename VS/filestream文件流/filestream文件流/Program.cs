using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filestream文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取文件
            //using (FileStream firead = new FileStream(@"C:\Users\Administrator\Desktop\C#新知识.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    //定义一个字节数组接受
            //    byte[] b = new byte[1024*1024];
            //    int r = firead.Read(b, 0, b.Length);
            //    //解码
            //    string textdata = Encoding.Default.GetString(b,0,r);
            //    Console.WriteLine(textdata);
            //}
            //Console.ReadKey();


            //写入文件
            //\Users\Administrator\Desktop
            Console.WriteLine("请输入文档名字：");
            string name = Console.ReadLine();
            using (FileStream fiwrite = new FileStream(@"E:\" + name + ".txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                Console.WriteLine("输入你需要添加的文本");
                string txt = Console.ReadLine();
                byte[] b = Encoding.Default.GetBytes(txt);
                //编码
                fiwrite.Write(b,0,b.Length);
            }
            Console.ReadKey();
        }
    }
}
