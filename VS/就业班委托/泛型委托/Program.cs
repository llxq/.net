using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型委托
{
    public delegate int DeleMax<T>(T t1, T t2);
    class Program
    {
        static void Main(string[] args)
        {
            int[] names = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(GetMax<int>(names, (n1, n2) => { return n1 - n2; }));
            Console.ReadKey();
        }
        static T GetMax<T>(T[] names, DeleMax<T> de)
        {
            T max = names[0];
            for (int i = 0; i < names.Length; i++)
            {
                if (de(names[i], max) > 0)
                {
                    max = names[i];
                }
            }
            return max;
        }
    }
}
