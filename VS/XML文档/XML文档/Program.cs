using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个小xml文档对象
            XmlDocument doc = new XmlDocument();
            //添加第一行
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            //添加第一个根节点
            XmlElement books = doc.CreateElement("books");
            doc.AppendChild(books);

            XmlElement book = doc.CreateElement("book");
            books.AppendChild(book);

            //添加一个子节点
            XmlElement name = doc.CreateElement("name");
            name.InnerText = "水浒传";
            book.AppendChild(name);

            //添加第二个子节点
            XmlElement count = doc.CreateElement("count");
            count.InnerText = "100";
            book.AppendChild(count);

            //保存
            doc.Save("我的第一个Xml文件.xml");
            Console.WriteLine("保存成功！");
            Console.ReadKey();
        }
    }
}
