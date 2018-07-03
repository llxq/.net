using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大项目
{
    class EventArg:EventArgs
    {
        public object obj { get; set; }
        public int p { get; set; }
    }
}
