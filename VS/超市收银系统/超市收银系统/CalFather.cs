using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    //打折父类
    abstract class CalFather
    {
        //创建一个抽象类作为打折的父类
        /// <summary>
        /// 打折的方式
        /// </summary>
        /// <param name="money">打折之前的价钱</param>
        /// <returns>打折之后的价钱</returns>
        public abstract double GetTotlaMoney(double money);
    }
}