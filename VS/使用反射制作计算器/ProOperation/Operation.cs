using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProOperation
{
    public abstract class Operation
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        //这个属性设置为只读，记录子类的运算符
        public abstract string Types
        { get; }
        public Operation(int n1, int n2)
        {
            this.NumberOne = n1;
            this.NumberOne = n2;
        }

        //获得结果
        public abstract int GetResult();
    }
}
