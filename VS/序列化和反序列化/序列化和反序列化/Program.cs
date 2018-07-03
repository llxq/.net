using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace 序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //序列化对象
            //Preson p = new Preson();
            //p.Name = "张三";
            //p.Age = 20;
            //p.Gender = '男';
            //using (FileStream fiwrite = new FileStream(@"C:\Users\Administrator\Desktop\111.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    //开始序列化对象
            //    BinaryFormatter bf = new BinaryFormatter();
            //    //将对象序列化成二进制
            //    bf.Serialize(fiwrite,p);
            //}
            //Console.WriteLine("成功");
            //Console.ReadKey();



            //反序列化对象
            Preson p;
            using (FileStream fileread = new FileStream(@"C:\Users\Administrator\Desktop\111.txt", FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                //反序列化对象，并且将反序列化之后的对象转换为preson类
                p = (Preson)bf.Deserialize(fileread);
            }
            //打印结果和之前赋值的一样
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
            Console.ReadKey();



        }
    }
    //创建一个类用来序列化
    [Serializable]
    public class Preson
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private char _gander;
        public char Gender
        {
            get { return _gander; }
            set { _gander = value; }
        }
        public int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}

