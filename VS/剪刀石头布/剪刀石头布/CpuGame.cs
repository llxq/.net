using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 剪刀石头布
{
    class CpuGame
    {
        public string Fist
        {
            get;
            set;
        }
        public int Getcpu()
        {
            Random r = new Random();
            int number = r.Next(1, 4);
            switch (number)
            {
                case 1:
                    this.Fist = "剪刀";
                    break;
                case 2:
                    this.Fist = "石头";
                    break;
                case 3:
                    this.Fist = "布";
                    break;
            }
            return number;
        }
    }
}
