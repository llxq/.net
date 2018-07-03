using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    //声明一个委托类型变量指向一个方法
    public delegate void Sayhi(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //匿名函数
            Sayhi sa = delegate (string name) { Console.WriteLine("Holle"+name); };
            sa("张三");
            Console.ReadKey();
        }
    }
}
