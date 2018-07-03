using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    /// <summary>
    /// 满M 减N
    /// </summary>
    class CalMN:CalFather
    {
        public double M
        {
            set;
            get;
        }
        public double N
        {
            set;
            get;
        }
        public CalMN(double m, double n)
        {
            this.M = m;
            this.N = n;
        }
        public override double GetTotlaMoney(double money)
        {
            if (money >= this.M)
            {
                return money - (int)(money / this.M) * this.N;
            }
            else
            {
                return money;
            }
        }
    }
}
