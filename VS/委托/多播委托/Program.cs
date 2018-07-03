using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多播委托
{
    public delegate void DelText();
    class Program
    {
        static void Main(string[] args)
        {
            //这个就是多播委托
            DelText del = T1;
            del += T2;
            del += T3;
            del += T4;
            del -= T4;
            del -= T3;
        }
        static void T1() { }
        static void T2() { }
        static void T3() { }
        static void T4() { }
    }
}
