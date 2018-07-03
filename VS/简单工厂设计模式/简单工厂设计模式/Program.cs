using System;
namespace 简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你需要的电脑品牌：");
            string computre = Console.ReadLine();
            Computer c = Brand(computre);
            c.Sayhello();
            Console.ReadKey();
        }
        public static Computer Brand(string computer)
        {
            Computer c = null;
            switch (computer)
            {
                case "Lenovo":
                    c = new Lenovo();
                    break;
                case "Dell":
                    c = new Dell();
                    break;
                case "Acer":
                    c = new Acer();
                    break;
            }
            return c;
        }
    }
    public abstract class Computer
    {
        public abstract void Sayhello();
    }
    public class Lenovo : Computer
    {
        public override void Sayhello()
        {
            Console.WriteLine("我是联想电脑");
        }
    }
    public class Dell : Computer
    {
        public override void Sayhello()
        {
            Console.WriteLine("我是Dell电脑");
        }
    }
    public class Acer : Computer
    {
        public override void Sayhello()
        {
            Console.WriteLine("我是宏碁电脑");
        }
    }
}
