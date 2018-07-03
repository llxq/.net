using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构
{

    class program
    {
        //static string usename()
        //{
        //    string user = "张三";
        //    return user;
        //}
        //static string possword()
        //{
        //    string pwd = "1001011";
        //    return pwd;
        //}
        private static int number(out int i, out string x)
        {
            i = 100;
            x = "qwe q";
            int number1 = 100 + 10;
            return number1;
        }
        private static int number1(ref int i,ref string x)
        {
            i = 100;
            int number = 100 + 10;
            return number;
        }
        static void Main(String[] arges)
        {
            int i = 10;
            int number2 = number(out  i,out string y);

            int x = 0;
            string m = "";
            int w = number1(ref x,ref m);
            Console.WriteLine(y);
            Console.WriteLine(x);

            Console.WriteLine(number2);
            Console.WriteLine(i);
            Console.ReadKey();










            //Console.WriteLine("请输入用户名：");
            //string user = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("请输入密码：");
            //string pwd = Convert.ToString(Console.ReadLine());
            //if (user == usename() && pwd == possword())
            //{
            //    Console.WriteLine("登录成功！");
            //}
            //else
            //{
            //    Console.WriteLine("登录失败！");
            //}
            //    Console.ReadLine();



            ////倒着输出！！！
            //string[] str = {"我","喜欢","你" ,"qw","q"};
            //for (int i = 0; i <str.Length/2; i++)
            //{
            //    string num = str[i];
            //    str[i] = str[str.Length-1-i];
            //    str[str.Length - 1-i] = num;
            //}
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();





            //bool b = int.TryParse("", out int num);







        }
    }
}
