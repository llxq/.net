using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态的小练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //模拟实现U盘，MP3，移动硬盘插入电脑读取数据
            //先需要把MP3和U盘的父类创建一个对象
            MoblieHd m = new Mp3();
            Computer c = new Computer();
            c.Ms = m;
            c.CpuRead();
            c.CpuWriter();
            Console.ReadKey();
        }
    }
}
