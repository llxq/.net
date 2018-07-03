using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ArrayList集合的用法
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //输出十个十以内的随机数
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int Ranumber = r.Next(0, 10);
                //判断集合中中是否包含了已经有的随机数
                if (!list.Contains(Ranumber))
                {
                    list.Add(Ranumber);
                }
                else
                {
                    //如果包含了这个随机数的话 那么我么就应该让这个i-- 要不然就会少一个数
                    i--;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
