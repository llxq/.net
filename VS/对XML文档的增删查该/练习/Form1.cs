using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //存取XML中读取的对象
        List<InforMation> list = new List<InforMation>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //程序加载的时候默认一个单选按钮被选中
            RadMain.Checked = true;

            XmlDocument doc = new XmlDocument();
            doc.Load("information.xml");
            XmlElement preson = doc.DocumentElement;
            //拿到所有的所有的子节点
            XmlNodeList xmllist = preson.ChildNodes;
            foreach (XmlNode item in xmllist)
            {
                int id = Convert.ToInt32(item.Attributes["StudentId"].Value);
                string name = item["Name"].InnerText;
                int age = Convert.ToInt32(item["Age"].InnerText);
                char gender = Convert.ToChar(item["Gender"].InnerText);
                list.Add(new InforMation { Id = id, Name = name, Gender = gender, Age = age });
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool islogin = false;
            //获取输入的值，并且匹配
            #region  通过多个if嵌套解决
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (txtID.Text.Trim() == list[i].Id.ToString())
            //    {
            //        if (txtName.Text.Trim() == list[i].Name.ToString())
            //        {
            //            if (txtAge.Text.Trim() == list[i].Age.ToString())
            //            {
            //                if (RadMain.Checked)
            //                {
            //                    if (RadMain.Text == list[i].Gender.ToString())
            //                    {
            //                        MessageBox.Show("登录成功！");
            //                        islogin = true;
            //                        break;
            //                    }
            //                }
            //                else if (radWoman.Checked)
            //                {
            //                    if (radWoman.Text == list[i].Gender.ToString())
            //                    {
            //                        MessageBox.Show("登录成功！");
            //                        islogin = true;
            //                        break;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            #endregion 
            #region 通过重写Information的Equals解决
            try
            {
                InforMation preson = new InforMation();
                preson.Age = Convert.ToInt32(txtAge.Text.Trim());
                preson.Name = txtName.Text.Trim().ToString();
                preson.Id = Convert.ToInt32(txtID.Text.Trim());
                preson.Gender = RadMain.Checked ? '男' : '女';
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Equals(preson))
                    {
                        MessageBox.Show("登录成功！");
                        islogin = true;
                    }
                }
                #endregion
                if (!islogin)
                {
                    MessageBox.Show("登录失败!");
                }
            }
            catch { }
        }
    }
}

