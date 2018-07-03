using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    /// <summary>
    /// 打折
    /// </summary>
    class CalRate : CalFather
    {
        public double Calrate
        {
            get;
            set;
        }
        public CalRate(double calrate)
        {
            this.Calrate = calrate;
        }
        public override double GetTotlaMoney(double money)
        {
            return money * this.Calrate;
        }
    }
}
