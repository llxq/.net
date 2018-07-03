using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmmand
{
   public class Preson
    {
        public void Write()
        {
            File.WriteAllText("1.txt","张三李四王五");
        }
    }
}
