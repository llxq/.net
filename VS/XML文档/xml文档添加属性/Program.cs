using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xml文档添加属性
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            XmlElement books = doc.CreateElement("books");
            doc.AppendChild(books);
            XmlElement book = doc.CreateElement("book");
            books.AppendChild(book);
            XmlElement storybook = doc.CreateElement("storybook");
            //为子节点添加属性
            storybook.SetAttribute("name","水浒传");
            storybook.SetAttribute("count","100");
            book.AppendChild(storybook);
            doc.Save("有属性的xml文档.xml");
            Console.WriteLine("保存成功！");
            Console.ReadKey();

        }
    }
}
