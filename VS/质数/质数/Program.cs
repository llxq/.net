using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 质数
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  判断一百以内的是质数的数值
            //判断一百以内的是质数的数值
            for (int i = 2; i < 100; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b) Console.WriteLine(i);
            }
            #endregion
            #region  乘法口诀表
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i}*{j}={i * j}\t");
                }
                Console.WriteLine();
            }
            #endregion



            Console.WriteLine("请输入第一个数：");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符：");
            string otr = Console.ReadLine();
            Console.WriteLine("请输入第二个数：");
            int number2 = int.Parse(Console.ReadLine());

            switch (otr)
            {
                case "+":
                    Console.WriteLine($"您输入的结果是：{number1 + number2}");
                    break;
                case "-":
                    Console.WriteLine($"您输入的结果是：{number1 - number2}");
                    break;
                case "*":
                    Console.WriteLine($"您输入的结果是：{number1 * number2}");
                    break;
                case "/":
                    Console.WriteLine($"您输入的结果是：{number1 / number2}");
                    break;

            }

            Console.ReadKey();
        }
    }
}
