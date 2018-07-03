using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态的小练习
{
    /// <summary>
    /// 这个是U盘  继承自moblieHd
    /// </summary>
    public class USB:MoblieHd
    {
        public override void Read()
        {
            Console.WriteLine("U盘读取数据");
        }
        public override void Writer()
        {
            Console.WriteLine("U盘写入数据");
        }
    }
}
