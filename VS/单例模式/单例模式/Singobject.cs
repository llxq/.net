using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    class Singobject
    {
        //私有化构造函数
        private Singobject()
        {
        }

        //定义静态字段存储窗体对象
        private static Singobject _single = null;

        public Form3 F3
        {
            get;
            set;
        }

        public Form4 f4
        {
            get;
            set;
        }
        public Form5 f5
        {
            get;
            set;
        }

        //创建一个静态方法 返回一个窗体对象
        public static Singobject Getsing()
        {
            if (_single == null)
            {
                _single = new Singobject();
            }
            return _single;
        }
    }
}
