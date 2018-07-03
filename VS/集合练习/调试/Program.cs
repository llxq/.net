using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 调试
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你所需要的数组长度:");
            int[] number = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("输入数组：");
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("你输入的数组为：");
            foreach (var item in number)
            {
                Console.Write(item);
            }


            //int number = int.Parse(Console.ReadLine());
            //int[] myint = new int[number];
            //foreach (var ouint in myint)
            //{
            //    Console.Write(ouint+"\n");
            //}
            Console.ReadKey();
        }
    }
}
