using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    //超市收银
    class SupperMarket
    {
        //展示货物
        public void Show()
        {
            //调用仓库的展示方式
            wh.Show();
        }

        //先取货
        WareHouse wh = new WareHouse();

        //写一个构造函数，当我们创建超市对象的时候，仓库需要有货物
        public SupperMarket()
        {
            //进货
            wh.GoProduct("Acer", 1000);
            wh.GoProduct("SamSung", 1000);
            wh.GoProduct("Sauce", 1000);
            wh.GoProduct("Banana", 1000);
        }

        //和用户交互
        public void AskBuying()
        {
            Console.WriteLine("欢迎光临，请问您需要购买什么");
            Console.WriteLine("我们有 Acer，SamSung，Sauce，Banana");
            string strTaple = Console.ReadLine();
            Console.WriteLine("您需要多少？");
            int count = int.Parse(Console.ReadLine());
            //取货,里面包含需要取的货物名称和数量
            ProductFather[] pf = wh.Getproduct(strTaple, count);
            //结账
            double ReMoney = Money(pf);
            Console.WriteLine($"您总共需要支付{ReMoney}元");
            Console.WriteLine("请选择你的打折方式：1--不打折，2--打9折，3--打8.5折，4--满300减50，5--满500减100");
            string input = Console.ReadLine();
            //通过用户的输入返回一个打折的对象
            CalFather c = Cf(input);
            double totalmoner = c.GetTotlaMoney(ReMoney);
            Console.WriteLine($"打完折之后您应付{totalmoner}元");
            //Change(totalmoner);
            for (int i = 0; i < pf.Length; i++)
            {
                Console.WriteLine("您的购买信息为：");
                Console.WriteLine("商品名称："+pf[i].Name+",\t单价："+pf[i].Price+",\tID："+pf[i].Id);
            }

        }

        //public void Change(double totalmoner)
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("请输入付款金额：");
        //        double Payment = double.Parse(Console.ReadLine());
        //        if (Payment - totalmoner >= 0)
        //        {
        //            Console.WriteLine($"找您{Payment - totalmoner}");
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("您输入的金额不足！");
        //            Console.WriteLine("请继续付款");
        //            Payment = double.Parse(Console.ReadLine());
        //        }
        //    }
        //}

        /// <summary>
        /// 根据用户的输入，选择打折的方式
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public CalFather Cf(string input)
        {
            CalFather c = null;
            switch (input)
            {
                case "1":
                    c = new CalNone();
                    break;
                case "2":
                    c = new CalRate(0.9);
                    break;
                case "3":
                    c = new CalRate(8.5);
                    break;
                case "4":
                    c = new CalMN(300, 50);
                    break;
                case "5":
                    c = new CalMN(500, 100);
                    break;
            }
            return c;
        }

        //结账
        public double Money(ProductFather[] pf)
        {
            double ReMoner = 0;
            for (int i = 0; i < pf.Length; i++)
            {
                ReMoner += pf[i].Price;
            }
            return ReMoner;
        }
    }
}
