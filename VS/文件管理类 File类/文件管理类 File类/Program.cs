using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 文件管理类_File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //打开一个文档
            //File.Open(@"C:\Users\Administrator\Desktop\C#新知识.txt",FileMode.Open);
            //Console.WriteLine("打开成功！");




            //先学习一个path类 （操作文件路径的）
            //先引入命名空间  using System.Io;
            //这是一个静态类，不需要创建对象

            //path类的常用方法
            string str = @"C:\Users\Administrator\Desktop\C#新知识.txt";
            //常规方法获取文件名
            //int index = str.LastIndexOf("\\");
            //string s = str.Substring(index+1);
            //Console.WriteLine(s);

            //获取文件名字  包含扩展名！
            Path.GetFileName(str);
            Console.WriteLine(Path.GetFileName(str));

            //获取文件扩展名
            Path.GetExtension(str);
            Console.WriteLine(Path.GetExtension(str));

            //获取文件名  不包含扩展名
            Path.GetFileNameWithoutExtension(str);
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));

            //获得文件夹所在的文件名   也就是除了文件名和扩充名剩下的文件夹的名字
            Path.GetDirectoryName(str);
            Console.WriteLine(Path.GetDirectoryName(str));

            //获得文件的全路径
            Path.GetFullPath(str);
            Console.WriteLine(Path.GetFullPath(str));

            //连接两个路径
            Path.Combine(str, str);
            Console.WriteLine(Path.Combine(str,str));
            Console.ReadKey();
        }
    }
}
