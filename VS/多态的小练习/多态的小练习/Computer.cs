using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态的小练习
{
    /// <summary>
    /// 电脑 读取数据和写入数据  并且要判断是什么写入和读取的
    /// </summary>
    class Computer
    {
        //用字段存储是什么读取和写入数据
        private MoblieHd _ms;
        public MoblieHd Ms
        {
            get { return _ms; }
            set { _ms = value; }
        }
        public void CpuRead()
        {
            Ms.Read();
        }
        public void CpuWriter()
        {
            Ms.Writer();
        }
    }
}
