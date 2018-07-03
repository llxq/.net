using System;
namespace 第二题
{
    class Program
    {
        static void Main(string[] args)
        {

            LB l1 = new LB("1001011", '男', 20, "张三");
            LB l2 = new LB("1001012", '男', 20, "李四");
            LB l3 = new LB("1001013", '男', 20, "王五");
            Console.WriteLine("输入学号查询：");
            string str = Console.ReadLine();
            LB[] l = { l1, l2, l3 };
            for (int i = 0; i < l.Length; i++)
            {
                if (l[i].Number == str)
                {
                    Console.WriteLine($"学号：{l[i].Number}\t性别：{l[i].Gneder}\t姓名：{l[i].Name}\t年龄{l[i].Age}");
                }
                 if (l[i].Number != str && i == l.Length-1)
                {
                    Console.WriteLine("没有找到");
                }
            }
            Console.ReadKey();
        }
    }
    public class LB
    {
        public string Number
        {
            get;
            set;
        }
        public char Gneder
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public LB()
        {

        }
        public LB(string number, char gneder, int age, string name)
        {
            this.Number = number;
            this.Gneder = gneder;
            this.Age = age;
            this.Name = name;
        }      
    }
}
