using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 改变属性的值和读取有属性的xml文档
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 添加属性
            //XmlDocument doc = new XmlDocument();
            //doc.Load("book.xml");
            ////添加属性
            //XmlElement xe =(XmlElement) doc.SelectSingleNode("books/book/storybook[@name='水浒传']");
            //xe.SetAttribute("水浒传","C#大全");
            //doc.Save("book.xml");
            //Console.WriteLine("修改成功！");
            //Console.ReadKey();
            #endregion
            #region 修改节点的属性
            //XmlDocument doc = new XmlDocument();
            //doc.Load("book.xml");
            //XmlElement xe = (XmlElement)doc.SelectSingleNode("books/book/storybook");
            //xe.SetAttribute("name","三国演义");
            //doc.Save("book.xml");
            //Console.WriteLine("修改成功！");
            //Console.ReadKey();
            #endregion
            #region 读取xml文档
            //XmlDocument doc = new XmlDocument();
            //doc.Load("book2.xml");

            ////获得根节点
            //XmlElement books = doc.DocumentElement;

            ////获取指定根节点下的子节点
            //XmlNodeList node = books.ChildNodes;

            ////获得根节点下的所有子节点
            ////XmlNodeList node = books.GetElementsByTagName("*");

            //foreach (XmlNode item in node)
            //{
            //    Console.WriteLine(item.InnerText);
            //}
            //Console.ReadKey();
            #endregion
            #region 读取带属性的xml文档
            //XmlDocument doc = new XmlDocument();
            //doc.Load("book.xml");
            //XmlNodeList list = doc.SelectNodes("books/book/storybook");
            //foreach (XmlNode item in list)
            //{
            //    Console.WriteLine(item.Attributes["name"].Value);
            //    Console.WriteLine(item.Attributes["count"].Value);
            //}
            //Console.ReadKey();
            #endregion
        }
    }
}
