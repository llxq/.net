using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    //产品父类
    class ProductFather
    {
        //自动属性会添加一个字段
        public string Name
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
        public string Id
        {
            get;
            set;
        }
        public ProductFather(string id, double price, string name)
        {
            this.Id = id;
            this.Price = price;
            this.Name = name;
        }
    }
}
