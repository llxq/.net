using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 删除节点
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load("book.xml");

            #region 添加节点
            //XmlElement xe = doc.DocumentElement;
            //XmlElement storybook = doc.CreateElement("storybook");
            //xe.AppendChild(storybook);
            //XmlElement name = doc.CreateElement("name");
            //name.InnerText = "通话故事";
            //storybook.AppendChild(name);
            //XmlElement count = doc.CreateElement("count");
            //count.InnerText = "100";
            //xe.AppendChild(count);
            //doc.Save("book.xml");
            //Console.WriteLine("添加成功！");
            //Console.ReadKey();
            #endregion
            #region 删除节点
            //首先选中需要删除的节点
            //XmlNode node = doc.SelectSingleNode("books/storybook");
            //node.RemoveAll();
            //doc.Save("book.xml");
            //Console.WriteLine("删除成功！");
            //Console.ReadKey();
            #endregion
        }
    }
}
