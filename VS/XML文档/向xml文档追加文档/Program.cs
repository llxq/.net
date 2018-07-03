using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 向xml文档追加文档
{
    class Program
    {
        static void Main(string[] args)
        {
            //首先创建xml文档
            XmlDocument doc = new XmlDocument();
            XmlElement books;
            //判断指定xml文档是否存在
            if (File.Exists("book.xml"))
            {
                //如果存在则加载文档
                doc.Load("book.xml");
                //获取根节点
                books = doc.DocumentElement;
            }
            else
            {
                //否则创建第一行
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                books = doc.CreateElement("books");
                doc.AppendChild(books);
            }
            XmlElement book = doc.CreateElement("book");
            books.AppendChild(book);
            XmlElement teachbook = doc.CreateElement("name");
            teachbook.InnerText = "C#大全";
            book.AppendChild(teachbook);
            XmlElement name = doc.CreateElement("count");
            name.InnerText = "100";
            book.AppendChild(name);
            doc.Save("book.xml");
            Console.WriteLine("保存成功！");
            Console.ReadKey();
        }
    }
}
