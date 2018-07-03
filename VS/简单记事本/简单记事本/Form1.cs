using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace 简单记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //判断是否保存
        public bool a = false;

        /// <summary>
        /// 打开文件方法
        /// </summary>
        private void Open()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            of.Title = "选择打开的文件";
            of.Filter = "文本文件|*.txt";
            of.ShowDialog();
            if (of.FileName == "")
            {
                return;
            }
            using (FileStream fileRead = new FileStream(of.FileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 3];
                int r = fileRead.Read(buffer, 0, buffer.Length);
                Txt.Text = Encoding.GetEncoding("GB2312").GetString(buffer, 0, r);
            }
        }
        /// <summary>
        /// 保存文件方法
        /// </summary>
        private void Save()
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "保存你的文件";
            sf.Filter = "文本文件|*.txt";
            sf.ShowDialog();
            if (sf.FileName == "")
            {
                return;
            }
            using (FileStream fileWrite = new FileStream(sf.FileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.GetEncoding("GB2312").GetBytes(Txt.Text);
                fileWrite.Write(buffer,0,buffer.Length);
            }
            MessageBox.Show("保存成功！","提示");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolCopy.Enabled = false;
            ToolCut.Enabled = false;
            ToolPaste.Enabled = false;
            ToolDelete.Enabled = false;
            ToolCheck.Enabled = false;
            a = false;
        }
        private void Txt_TextChanged(object sender, EventArgs e)
        {
            ToolCopy.Enabled = true;
            ToolCut.Enabled = true;
            ToolPaste.Enabled = true;
            ToolDelete.Enabled = true;
            ToolCheck.Enabled = true;
        }
        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFile_Click(object sender, EventArgs e)
        {
            Txt.Clear();
        }
        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OPenFile_Click(object sender, EventArgs e)
        {
            if (a == false)
            {
                Open();
            }
            if (a == true)
            {
                Save();
                a = false;
            }
        }
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFile_Click(object sender, EventArgs e)
        {
            Save();
        }
        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolCopy_Click(object sender, EventArgs e)
        {
            if (Txt.SelectedText == "")
            {
                MessageBox.Show("请选择你需要复制的内容！","提示");
            }
            else
            {
                Txt.Copy();
            }
        }
        /// <summary>
        /// 黏贴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolPaste_Click(object sender, EventArgs e)
        {
            if (Txt.SelectedText == "")
            {
                MessageBox.Show("请选择你需要黏贴的内容！", "提示");
            }
            else
            {
                Txt.Paste();
            }
        }
        /// <summary>
        /// 剪切
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolCut_Click(object sender, EventArgs e)
        {
            if (Txt.SelectedText == "")
            {
                MessageBox.Show("请选择你需要剪切的内容！", "提示");
            }
            else
            {
                Txt.Cut();
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolDelete_Click(object sender, EventArgs e)
        {
            if (Txt.SelectedText == "")
            {
                MessageBox.Show("请选择你需要删除的内容！", "提示");
            }
            else
            {
                Txt.SelectedText = "";
            }
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolCheck_Click(object sender, EventArgs e)
        {
            Txt.SelectAll();
        }
        /// <summary>
        /// 字体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            Txt.Font = fd.Font;
        }
        /// <summary>
        /// 颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            Txt.ForeColor = cd.Color;
        }
    }
}
