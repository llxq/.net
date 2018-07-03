using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProOperation;

namespace ProAdd
{
    class Add : Operation
    {
        public Add(int n1, int n2) : base(n1, n2)
        {
        }
        public override string Types
        {
            get { return "+"; }
        }
        public override int GetResult()
        {
            return this.NumberOne + this.NumberTwo;
        }
    }
}
