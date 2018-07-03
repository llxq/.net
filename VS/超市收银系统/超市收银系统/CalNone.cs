using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    /// <summary>
    /// 不打折类
    /// </summary>
    class CalNone : CalFather
    {
        public override double GetTotlaMoney(double money)
        {
            return money;
        }
    }
}
