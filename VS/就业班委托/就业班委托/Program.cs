using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 就业班委托
{
    public delegate void Dele();
    public delegate void Dele1(string str);
    public delegate string Dele2();
    public delegate string Dele3(string str);
    class Program
    {
        static void Main(string[] args)
        {
            //Dele de = Test;
            //Dele de = delegate () { };
            //Dele de = () => { };

            //Dele1 de = Test;
            //Dele1 de = delegate (string name) { };
            //Dele1 de = (name) => { };

            //Dele2 de = Test;
            //Dele2 de = delegate () { return "123"; };
            //Dele2 de = () => { return "123"; };

            //Dele3 de = Test;
            //Dele3 de = delegate (string name) { return "123"; };
            //Dele3 de = (name) => { return "123"; };
        }
        static string Test(string str) { return "111"; }
    }
}
