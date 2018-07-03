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

namespace 增删查改小程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 显示数据
        /// </summary>
        void LoadData()
        {
            List<User> list = new List<User>();
            XmlDocument doc = new XmlDocument();
            doc.Load("User.xml");
            XmlElement users = doc.DocumentElement;
            XmlNodeList nodelist = users.ChildNodes;
            foreach (XmlNode item in nodelist)
            {
                list.Add(new User() { Id = Convert.ToInt32(item.Attributes["id"].Value), Name = item["name"].InnerText, Age = Convert.ToInt32(item["age"].InnerText), Gender = item["gender"].InnerText, Password = item["password"].InnerText });
            }
            //添加数据源至DataGridView中
            dataGridView1.DataSource = list;
           
            //取消前面第一行
            dataGridView1.RowHeadersVisible = false;
            //让其点击选中一行
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //不让用户拖动列的顺序
            dataGridView1.AllowUserToOrderColumns = false;
            //不让用户调动列和行的大小
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            //设置列居中
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //取消加载的时候显示第一行
            dataGridView1.ClearSelection();
            LoadData();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("User.xml");
            XmlElement users = doc.DocumentElement;
            XmlElement user = doc.CreateElement("user");
            user.SetAttribute("id", txtAddId.Text.Trim());
            users.AppendChild(user);
            XmlElement name = doc.CreateElement("name");
            name.InnerText = txtAddName.Text.Trim();
            user.AppendChild(name);
            XmlElement age = doc.CreateElement("age");
            age.InnerText = txtAddAge.Text.Trim();
            user.AppendChild(age);
            XmlElement gender = doc.CreateElement("gender");
            gender.InnerText = radAddMain.Checked ? "男" : "女";
            user.AppendChild(gender);
            XmlElement password = doc.CreateElement("password");
            password.InnerText = txtAddPassword.Text.Trim();
            user.AppendChild(password);
            doc.Save("User.xml");
            LoadData();
            MessageBox.Show("添加成功！");
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtxgId.Text);
            XmlDocument doc = new XmlDocument();
            doc.Load("User.xml");
            XmlElement users = doc.DocumentElement;
            XmlNode user = users.SelectSingleNode("/Users/user[@id='" + id + "']");
            user["name"].InnerText = txtxgName.Text;
            user["age"].InnerText = txtxgAge.Text;
            user["password"].InnerText = txtxgPassword.Text;
            string gender = radxgMain.Checked ? "男" : "女";
            user["gender"].InnerText = gender;
            doc.Save("User.xml");
            LoadData();
            MessageBox.Show("修改成功！");
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            XmlDocument doc = new XmlDocument();
            doc.Load("User.xml");
            XmlElement users = doc.DocumentElement;
            XmlNode user = users.SelectSingleNode("/Users/user[@id='" + id + "']");
            users.RemoveChild(user);
            doc.Save("User.xml");
            LoadData();
            MessageBox.Show("删除成功！");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtxgId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtxgName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtxgAge.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtxgPassword.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            string gender = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            if (gender == "男")
            {
                radxgMain.Checked = true;
            }
            else
            {
                radxgWomain.Checked = true;
            }
        }
    }
}
