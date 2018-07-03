using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //将一个数组中的奇数放到一个集合，再将偶数放到另一个集合中
            //最终将两个集合合并为一个集合，并且奇数显示在左边，偶数显示在右边
            /*Console.WriteLine("输入数组长度：");
            int[] Number = new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("输入数组：");
            for (int i = 0; i < Number.Length; i++)
            {
                Number[i] = Convert.ToInt32(Console.ReadLine());
            }
            List<int> n1 = new List<int>();
            List<int> n2 = new List<int>();
            for (int i = 0; i < Number.Length; i++)
            {
                if (Number[i] % 2 == 0)
                {
                    n1.Add(Number[i]);
                }
                else
                {
                    n2.Add(Number[i]);
                }
            }
            Console.WriteLine("偶数");
            for (int i = 0; i < n1.Count; i++)
            {
                Console.WriteLine(n1[i]);
            }
            Console.WriteLine("奇数");
            for (int i = 0; i < n2.Count; i++)
            {
                Console.WriteLine(n2[i]);
            }*/

            //第二个练习
            Console.WriteLine("请输入个数不定的字符");
            string str = Console.ReadLine();
            //键值对数组
            Dictionary<char, int> dc = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    continue;
                }
                    if (dc.ContainsKey(str[i]))
                    {
                        //这个就是这个建所对应的值++
                        dc[str[i]]++;
                    }
                    else
                    {
                        dc[str[i]] = 1;
                    }
            }
            foreach (KeyValuePair<char, int> outdc in dc)
            {
                Console.WriteLine("{0}出现了{1}次", outdc.Key, outdc.Value);
            }
            Console.ReadKey();
        }

    }
}
