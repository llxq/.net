using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 练习
{
    class InforMation
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public int Id { get; set; }

        //重写equals方法
        public override bool Equals(object obj)
        {
            InforMation i = obj as InforMation;
            if (this.Name == i.Name && this.Gender == i.Gender && this.Id == i.Id && this.Age == i.Age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
