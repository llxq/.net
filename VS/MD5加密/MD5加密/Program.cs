using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //d3d9446802a44259755d38e6d163e820
            //d3d944682a44259755d38e6d163e820
            string s = GetMD5("10");
            Console.WriteLine(s);
            Console.ReadLine();
        }
        public static string GetMD5(string str)
        {
            //创建一个MD5对象
            //因为MD5是一个抽象类，所以不能创建他的实例
            MD5 m = MD5.Create();
            //开始加密
            //需要将接收过来的字符串转换为字节数组
            byte[] buffer = Encoding.Default.GetBytes(str);
            //返回一个加密好的字节数组，将转换过来的字节数组加密为一个字节数组
            byte[] MD5buffer = m.ComputeHash(buffer);
            //将字节数组转换为字符串
            //遍历将每一个元素转换为字符串16进制
            string MD5str = "";
            for (int i = 0; i < MD5buffer.Length; i++)
            {
                MD5str += MD5buffer[i].ToString("x2");
            }
            return MD5str;
        }
    }
}
