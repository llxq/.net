using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托练习求数组最大值
{
    public delegate int DelMax(object o1, object o2);
    class Program
    {
        static void Main(string[] args)
        {
            //object[] names = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(GetMax(names, (o1, o2) => { return (int)o1 - (int)o2; }));

            //object[] names = { "qwe", "qweqwe", "qweqweqwe", "abc" };
            //Console.WriteLine(GetMax(names, (o1, o2) => { return ((string)o1).Length - ((string)o2).Length; }));


            Console.ReadKey();
        }

        static object GetMax(object[] names, DelMax de)
        {
            object max = names[0];
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
