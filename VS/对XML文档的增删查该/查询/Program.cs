using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace 查询
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  获得没有属性的值
            //            XmlDocument doc = new XmlDocument();
            //            //XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            //            //doc.AppendChild(dec);

            //            //加载文档
            //            doc.Load("Student.xml");
            //            //获取根节点
            //            XmlElement Preson = doc.DocumentElement;

            //            XmlNodeList list = Preson.ChildNodes;
            //            foreach (XmlNode item in list)
            //            {
            //                //打印元素里面的值
            //                Console.WriteLine(item.InnerText);
            //            }

            //            //获取有属性的值
            //            XmlNodeList list1= doc.GetElementsByTagName("Student");
            //            foreach (XmlElement item in list1)
            //            {
            //                Console.WriteLine(item.Attributes["StudentID"].Value);
            //            }
            //            #region  添加有属性的值
            //            //添加有属性的值
            //            //XmlElement student = doc.CreateElement("Student");
            //            //student.SetAttribute("StudentId","5");
            //            //Preson.AppendChild(student);
            //            //XmlElement name = doc.CreateElement("Information");
            //            //name.SetAttribute ( "Name","廖建新");
            //            //name.SetAttribute("Gender","男");
            //            //name.SetAttribute("Age","21");
            //            //student.AppendChild(name);
            //            //doc.Save("Student.xml");
            //            //Console.WriteLine("保存成功！");
            //            #endregion

            //            Console.ReadKey();
            #endregion
            #region  创建了一个XML文档
            //            //先创建一个XML文档
            //            XmlDocument doc = new XmlDocument();
            //            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            //            doc.AppendChild(dec);
            //            XmlElement order = doc.CreateElement("Order");
            //            doc.AppendChild(order);
            //            XmlElement customerName = doc.CreateElement("CustomerName");
            //            customerName.InnerText = "刘洋";
            //            order.AppendChild(customerName);
            //            XmlElement orderNumber = doc.CreateElement("OrderNumber");
            //            orderNumber.InnerText = "bj10000";
            //            order.AppendChild(orderNumber);
            //            XmlElement items = doc.CreateElement("Items");
            //            order.AppendChild(items);
            //            XmlElement orderItem1 = doc.CreateElement("OrderItem");
            //            orderItem1.SetAttribute("Name","码表");
            //            orderItem1.SetAttribute("Count","100");
            //            items.AppendChild(orderItem1);
            //            XmlElement orderItem2 = doc.CreateElement("OrderItem");
            //            orderItem2.SetAttribute("Name", "雨衣");
            //            orderItem2.SetAttribute("Count", "1100");
            //            items.AppendChild(orderItem2);
            //            XmlElement orderItem3 = doc.CreateElement("OrderItem");
            //            orderItem3.SetAttribute("Name", "手表");
            //            orderItem3.SetAttribute("Count", "200");
            //            items.AppendChild(orderItem3);
            //            doc.Save("Order.xml");
            //            Console.WriteLine("保存成功！");
            //            Console.ReadKey();
            #endregion
            #region 获取刚刚创建的XML文档中的值 修改属性的值
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Order.xml");
            //XmlElement order = doc.DocumentElement;
            ////获取没有属性的值
            //XmlNodeList list = order.ChildNodes;
            //foreach (XmlNode item in list)
            //{
            //    Console.WriteLine(item.InnerText);
            //}
            ////获取有属性的值
            //XmlElement items = order["Items"];
            //XmlNodeList list2 = items.ChildNodes;
            //foreach (XmlNode item in list2)
            //{
            //    Console.WriteLine(item.Attributes["Name"].Value);
            //    Console.WriteLine(item.Attributes["Count"].Value);

            //    //修改属性的值
            //    //if (item.Attributes["Name"].Value == "雨衣")
            //    //{
            //    //    item.Attributes["Name"].Value = "电表";
            //    //    doc.Save("Order.xml");
            //    //}
            //}
            //Console.ReadKey();
            #endregion
            #region  获取有属性的值 XPath方式
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Student.xml");
            //XmlElement preson = doc.DocumentElement;
            //XmlNode id = doc.SelectSingleNode("/Preson/Student[@StudentID='6']");
            //Console.WriteLine(id.Attributes["StudentID"].Value);
            //id.Attributes["StudentID"].Value = "1";
            //doc.Save("Student.xml");
            //Console.WriteLine("修改成功！");
            //Console.ReadKey();
            #endregion
            #region  删除指定带有属性的节点
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Order.xml");
            //XmlElement Order = doc.DocumentElement;
            //XmlNode items = Order.SelectSingleNode("/Order/Items");
            //XmlNode item = Order.SelectSingleNode("/Order/Items/OrderItem[@Name='电表']");
            //items.RemoveChild(item);
            //doc.Save("Order.xml");
            //Console.WriteLine("删除成功！");
            //Console.ReadKey();
            #endregion
            #region 删除指定节点的属性和属性的值
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Order.xml");
            //XmlElement order = doc.DocumentElement;
            //XmlNode items = order.SelectSingleNode("/Order/Items/OrderItem[@Name='电表']");
            //items.Attributes.RemoveNamedItem("Name");
            //doc.Save("Order.xml");
            //Console.WriteLine("删除成功！");
            //Console.ReadKey();
            #endregion
        }
    }
}
