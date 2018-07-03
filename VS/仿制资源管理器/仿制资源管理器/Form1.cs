using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仿制资源管理器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
        }
        /// <summary>
        /// 获取文件夹下的所有文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="tnc">根节点集合</param>
        private void GetDirectioryAndFile(string path, TreeNodeCollection tnc)
        {
            //获取该文件夹下的所有文件
            string[] dics = Directory.GetDirectories(path);
            for (int i = 0; i < dics.Length; i++)
            {
                //获取到路径下的文件名
                string dicsName = Path.GetFileNameWithoutExtension(dics[i]);
                //将文件名字加载到节点集合下
                //获得节点
                TreeNode tn = tnc.Add(dicsName);
                #region 这个是有问题的查看
                ////找到的根节点下面查看是否有TXT文档
                //string[] fileNames = Directory.GetFiles(dics[i]);
                //for (int j = 0; j < fileNames.Length; j++)
                //{
                //    //添加子节点
                //    tn.Nodes.Add(Path.GetFileNameWithoutExtension(fileNames[j]));
                //    //记住节点
                //    //访问nodes[j]，这个就是访问这个节点下的某个节点
                //    tn.Nodes[j].Tag = fileNames[j];
                //}

                #endregion
                //递归
                GetDirectioryAndFile(dics[i], tn.Nodes);
            }
            //这个方法可以在初始目录下如果有TXT的话可以读取出来
            string[] filenames = Directory.GetFiles(path);
            for (int i = 0; i < filenames.Length; i++)
            {
                //因为这个tnc 现在是当前循环到的子节点
                TreeNode tn = tnc.Add(Path.GetFileNameWithoutExtension(filenames[i]));
                tn.Tag = filenames[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string pathname = textBox2.Text.ToString().Trim('"');
                GetDirectioryAndFile(pathname, treeView1.Nodes);
            }
            catch
            { }
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //获取存储的路径
                string filepath = treeView1.SelectedNode.Tag.ToString();
                textBox1.Text = File.ReadAllText(filepath, Encoding.Default);
            }
            catch { }
        }
    }
}
