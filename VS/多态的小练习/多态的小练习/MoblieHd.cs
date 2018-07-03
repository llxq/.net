using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态的小练习
{
    /// <summary>
    /// 这个是移动硬盘  用来做U盘和MP3的基类
    /// </summary>
    public abstract class MoblieHd
    {
        public abstract void Read();
        public abstract void Writer();
    }
}
