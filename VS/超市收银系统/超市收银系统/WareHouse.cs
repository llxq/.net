using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    //仓库
    class WareHouse
    {
        //首先我们定义一个list集合来存放我们的货物
        //这个集合 list里面存放的就是一个父类集合
        //相当是一个货架
        List<List<ProductFather>> list = new List<List<ProductFather>>();

        //我们需要展示我们的产品
        public void Show()
        {
            //我们需要遍历这个这个数组
            foreach (var item in list)
            {
                Console.Write("我们超市有：");
                Console.WriteLine(item[0].Name + ",\t" + item.Count + "个,\t每个" + item[0].Price + "元");
            }
        }
        //list[0]:Acer
        //list[1]:SamSung
        //list[2]:Sauce
        //list[3]:Banana

        //当我们创建仓库对象的时候，里面应该已经有了货架了
        //这个时候我们可以使用构造函数，因为当创建对象的时候就是需要调用构造函数
        //就是new一个对象的时候调用
        public WareHouse()
        {
            //这个就是相当于是给他添加四个货架，货架里面存放的是一个父类产品
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="price">产品名称</param>
        /// <param name="count">产品数量</param>
        public void GoProduct(string price, int count)
        {
            //先遍历有进多少货物
            for (int i = 0; i < count; i++)
            {
                switch (price)
                {
                    //list[0]是Acer，这个时候我们添加一个Acer对象
                    case "Acer":
                        list[0].Add(new Acer(Guid.NewGuid().ToString(), 5000, "宏碁笔记本"));
                        break;
                    case "SamSung":
                        list[1].Add(new SamSung(Guid.NewGuid().ToString(), 8000, "三星手机"));
                        break;
                    case "Sauce":
                        list[2].Add(new Sauce(Guid.NewGuid().ToString(), 5, "老抽"));
                        break;
                    case "Banana":
                        list[3].Add(new Banana(Guid.NewGuid().ToString(), 2, "大香蕉"));
                        break;
                }
            }
        }
        /// <summary>
        /// 取货
        /// </summary>
        /// <param name="price">取货的名称</param>
        /// <param name="count">取货的数量</param>
        /// <returns></returns>
        public ProductFather[] Getproduct(string price, int count)
        {
            //我们需要定义一个数组接收我们取出来的货物
            ProductFather[] pf = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (price)
                {
                    //判断取出的是什么货物，
                    //list[0]代表取出的是第一个货物
                    //list[0][0]后面那个0是代表取这个货物的第一个货物
                    //取完货物我们应该把这个货删除了

                    case "Acer":
                        if (list[0].Count != 0)
                        {
                            pf[i] = list[0][0];
                            list[0].RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("对不起，货物暂时不足!");
                        }
                        break;
                    case "SamSung":
                        if (list[0].Count != 0)
                        {
                            pf[i] = list[1][0];
                            list[1].RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("对不起，货物暂时不足!");
                        }
                        break;
                    case "Sauce":
                        if (list[0].Count != 0)
                        {
                            pf[i] = list[2][0];
                            list[2].RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("对不起，货物暂时不足!");
                        }
                        break;
                    case "Banana":
                        if (list[0].Count != 0)
                        {
                            pf[i] = list[3][0];
                            list[3].RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("对不起，货物暂时不足!");
                        }
                        break;

                }
            }
            return pf;
        }
    }
}
