using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        void Addtree(string node1, params string[] node2)
        {
            TreeNode ParentNode = treeView1.Nodes.Add(node1);
            for (int i = 0; i < node2.Length; i++)
            {
                TreeNode SonNode = new TreeNode(node2[i]);
                ParentNode.Nodes.Add(SonNode);
            }
        }
        /// <summary>
        /// 打开相对应的文件
        /// </summary>
        /// <param name="str"></param>
        void OpenFile(string str)
        {
            using (FileStream fileRead = new FileStream(str, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 3];
                int r = fileRead.Read(buffer, 0, buffer.Length);
                richTextBox1.Text = Encoding.UTF8.GetString(buffer, 0, r);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] node1 = { "基础知识", "指针详解" };
            Addtree("C++ (2)", node1);
            string[] node2 = { "接口", "委托和事件学习", "异常处理" };
            Addtree("C# (3)", node2);
            TreeNode ParentNode1 = treeView1.Nodes.Add("大学物理");
            Addtree("大学英语", "");
        }

        private void toolnew_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        /// <summary>
        /// 选中节点之后打开一个文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "基础知识")
            {
                OpenFile(@"基础知识.txt");
            }
            else if (e.Node.Text == "指针详情")
            {
                OpenFile(@"指针详情.txt");
            }
            else if (e.Node.Text == "接口")
            {
                OpenFile(@"接口.txt");
            }
            else if (e.Node.Text == "委托和事件学习")
            {
                OpenFile(@"委托和事件学习.txt");
            }
            else if (e.Node.Text == "异常处理")
            {
                OpenFile(@"异常处理.txt");
            }
            else if (e.Node.Text == "大学物理")
            {
                OpenFile(@"大学物理.txt");
            }
            else if (e.Node.Text == "大学英语")
            {
                OpenFile(@"大学英语.txt");
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolsave_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Title = "保存文件";
                sf.Filter = "文本文件|*.txt";
                sf.ShowDialog();
                string str = sf.FileName.ToString();
                if (str == "")
                {
                    return;
                }
                using (FileStream fileWriter = new FileStream(str, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(richTextBox1.Text);
                    fileWriter.Write(buffer, 0, buffer.Length);
                }
                str = Path.GetFileNameWithoutExtension(str);
                TreeNode SonNode = new TreeNode(str);
                treeView1.SelectedNode.Nodes.Add(SonNode);
            }
            else
            {
                MessageBox.Show("请选中需要添加的子节点");
            }
        }
    }
}
