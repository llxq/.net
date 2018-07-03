using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型委托和lamda表达式
{
    public delegate int Replace<T>(T t1, T t2);
    class Program
    {
        static void Main(string[] args)
        {
            //求任意类型的最大值，使用泛型委托
            int[] name = { 0, 1, 2, 3, 4, 5, 6 };
            int max = GetMax(name, (int n1, int n2) => { return n1 - n2; });
            Console.WriteLine(max);

            string[] name2 = { "a", "aa", "aaa" };
            string max1 = GetMax<string>(name2, (string s1, string s2) => { return s1.Length - s2.Length; });
            Console.WriteLine(max1);
            Console.ReadKey();

            //lamd表达式
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            list.RemoveAll(a => a > 4);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }

        public static T GetMax<T>(T[] name, Replace<T> re)
        {
            T max = name[0];
            for (int i = 0; i < name.Length; i++)
            {
                if (re(max, name[i]) < 0)
                {
                    max = name[i];
                }
            }
            return max;
        }
    }
}
