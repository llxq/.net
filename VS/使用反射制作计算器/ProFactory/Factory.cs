using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProOperation;
using System.Reflection;
using System.IO;

namespace ProFactory
{
    public class Factory
    {
        public static Operation Getoper(string type, int n1, int n2)
        {
            Operation oper = null;
            //动态获取程序集
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plug");
            string[] files = Directory.GetFiles(path, "*.dll");
            foreach (string item in files)
            {
                //加载程序集
                Assembly ass = Assembly.LoadFile(item);
                //获取公开的程序集的数据
                Type[] tp = ass.GetExportedTypes();
                foreach (Type t in tp)
                {
                    //判断当前数据是否是继承与父类和是否是抽象类
                    if (!t.IsAbstract && t.IsSubclassOf(typeof(Operation)))
                    {
                        //创建子类对象赋值给 oper 这个父类
                        //数据类型，需要的构造函数的参数
                        oper = (Operation)Activator.CreateInstance(t, n1, n2);
                    }
                    //判断当前运算符是否和输入进来的运算符相等
                    if (type == oper.Types)
                    {
                        return oper;
                    }
                    else
                    {
                        return oper = null;
                    }
                }
            }

            return oper;
        }
    }
}