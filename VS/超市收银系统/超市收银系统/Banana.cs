﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    //香蕉
    class Banana : ProductFather
    {
        public Banana(string id, double price, string name)
            : base(id, price, name)
        {
        }
    }
}
