using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态的小练习
{
    /// <summary>
    /// MP3硬盘  也是继承自mobliehd
    /// </summary>
    public class Mp3 : MoblieHd
    {
        public override void Read()
        {
            Console.WriteLine("MP3读取数据");
        }
        public override void Writer()
        {
            Console.WriteLine("Mp3写入数据");
        }
        public void Play()
        {
            Console.WriteLine("Mp3播放音乐");
        }
    }
}
