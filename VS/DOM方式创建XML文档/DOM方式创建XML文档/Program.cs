using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DOM方式创建XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Preson> list = new List<Preson>();
            list.Add(new Preson() { Name = "张三", Id = 1, Age = 20, Gender = '男' });
            list.Add(new Preson() { Name = "李四", Id = 2, Age = 25, Gender = '男' });
            list.Add(new Preson() { Name = "王五", Id = 3, Age = 30, Gender = '女' });
            list.Add(new Preson() { Name = "赵七", Id = 4, Age = 18, Gender = '男' });
            list.Add(new Preson() { Name = "赵丽", Id = 5, Age = 50, Gender = '女' });
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            XmlElement preson = doc.CreateElement("Preson");
            doc.AppendChild(preson);
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement student = doc.CreateElement("Student");
                student.SetAttribute("StudentId", list[i].Id.ToString());
                preson.AppendChild(student);
                XmlElement name = doc.CreateElement("Name");
                name.InnerText = list[i].Name;
                student.AppendChild(name);
                XmlElement age = doc.CreateElement("Age");
                age.InnerText = list[i].Age.ToString();
                student.AppendChild(age);
                XmlElement gender = doc.CreateElement("Gender");
                gender.InnerText = list[i].Gender.ToString();
                student.AppendChild(gender);
            }
            doc.Save("Student.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();
        }
    }
    class Preson
    {
        public string Name { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
    }
}
