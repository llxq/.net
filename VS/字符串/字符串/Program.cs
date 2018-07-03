using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 字符串
{
    class Program
    {
        public enum Gender
        {
            男,
            女
        }
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个路径");
            //读取文档(Txt)文件的内容
            string counstr = Console.ReadLine();
            //string counstr = @"C: \Users\Administrator\Desktop\C#遗漏知识.txt";
            string[] sstr = File.ReadAllLines(counstr,Encoding.Default);
            for (int i = 0; i < sstr.Length; i++)
            {
                Console.WriteLine(sstr[i]);
            }


            //将字符串转换为枚举！
            //Gender d = (Gender)Enum.Parse(typeof(Gender), "男");
            //Console.WriteLine();

            //将字符串反转
            string str = "Hello C Sharp";
            //这样就可以分割这个字符串   分割的字符串是分割符前后形成一个新的字符
            string[] Newstr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //这个时候在反转就可以了
            for (int i = 0; i < Newstr.Length / 2; i++)
            {
                string temp = Newstr[i];
                Newstr[i] = Newstr[Newstr.Length - 1 - i];
                Newstr[Newstr.Length - 1 - i] = temp;
            }
            //接着就可以再以空格分割输出
            str = string.Join(" ", Newstr);
            Console.WriteLine(str);



            //找出e所在的位置
            string s = "abceebqweqwejqbweqkwejbqwbe";
            //这个方法只能寻找单个字符
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'e')
                {
                    Console.WriteLine(i);
                }
            }
            int index = s.IndexOf('e');
            Console.WriteLine(index);
            while (index != -1)
            {
                index = s.IndexOf('e', index + 1);
                if (index != -1)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    break;
                }
            }


            //string S = "a  b--c=d";
            //删除不必要的字符
            //char[] ch = { ' ', '-', '=' };
            //这样删除的话  还会在删除的地方赋值为空值  这样的话占内存
            //string[] Str = S.Split(ch);
            //这样删除的话  可以把赋值给的空值也给删除 
            //string[] st = S.Split(ch, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(st.ToString());

            //创建一个计时器   用来记录程序运行的时间
            Stopwatch sw = new Stopwatch();
            //开始计时
            sw.Start();
            //判断两个字符是否相同
            string S1 = "abc";
            string S2 = "ABC";
            if (S2.Contains("A"))
            {
                S2 = S2.Replace('A', 'x');
                Console.WriteLine(S2);
            }


            //判断两个数是否是一样的，这个StringComparison.OrdinalIgonreCase 
            //则是可以让这两个数不区分大小写比较
            if (S1.Equals(S2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("两个数的结果是一样的");
            }
            else
            {
                Console.WriteLine("两个数的结果不一样");
            }
            //结束计时
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
