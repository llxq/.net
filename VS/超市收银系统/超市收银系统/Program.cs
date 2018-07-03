using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class Program
    {
        static void Main(string[] args)
        {
            //展示超市对象
            //展示货物
            SupperMarket sm = new SupperMarket();
            sm.Show();
            sm.AskBuying();
            Console.ReadKey();
        }
    }
}
