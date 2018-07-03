using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace 对XML文档的增删查该
{
    class Program
    {
        static void Main(string[] args)
        {
            //首先创建一个DOC对象
            XmlDocument doc = new XmlDocument();
            //判断该文档是否存在
            if (File.Exists("Student.xml"))
            {
                //如果存在的话
                //加载文档
                doc.Load("Student.xml");

                //获取该文档的根
                XmlElement Preson = doc.DocumentElement;

                //添加数据
                XmlElement student = doc.CreateElement("Student");
                student.SetAttribute("StudentName", "10");
                Preson.AppendChild(student);
                XmlElement name = doc.CreateElement("Name");
                name.InnerText = "张三";
                student.AppendChild(name);
                XmlElement age = doc.CreateElement("Age");
                age.InnerText = "18";
                student.AppendChild(age);
                XmlElement gender = doc.CreateElement("Gender");
                gender.InnerText = "女";
                student.AppendChild(gender);
            }
            else
            {
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                XmlElement preson = doc.CreateElement("Preson");
                doc.AppendChild(preson);
                XmlElement student = doc.CreateElement("Student");
                student.SetAttribute("StudentID","6");
                preson.AppendChild(student);
                XmlElement name = doc.CreateElement("Name");
                name.InnerText = "小青";
                student.AppendChild(name);
                XmlElement age = doc.CreateElement("Age");
                age.InnerText = "20";
                student.AppendChild(age);
                XmlElement gender = doc.CreateElement("Gender");
                gender.InnerText = "女";
                student.AppendChild(gender);
            }
            doc.Save("Student.xml");
            Console.WriteLine("添加成功！");
            Console.ReadKey();
        }
    }
}
