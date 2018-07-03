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

namespace 记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //判断是否保存
        public bool save = true;


        //保存文件的方法
        //private void Savetxt(ref string p)
        //{
        //    try
        //    {
        //        SaveFileDialog s = new SaveFileDialog();
        //        s.Title = "请选择你所保存的路径和名字";
        //        s.Filter = "文本文件|*.txt|所有文件|*.*";
        //        s.ShowDialog();
        //        save = true;
        //        string str = s.FileName;
        //        if (str == "")
        //        {
        //            return;
        //        }
        //        using (FileStream filewrite = new FileStream(str, FileMode.OpenOrCreate, FileAccess.Write))
        //        {
        //            byte[] buffer = Encoding.Default.GetBytes(richTextBox1.Text);
        //            filewrite.Write(buffer, 0, buffer.Length);
        //        }
        //        p = s.FileName;
        //        MessageBox.Show("保存成功！");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //打开文件的方法

        /// <summary>
        /// 打开文档
        /// </summary>
        //private void Opentxt()
        //{
        //    try
        //    {
        //        OpenFileDialog od = new OpenFileDialog();
        //        od.Title = "请选择您所需要打开的文件";
        //        od.Multiselect = false;
        //        od.Filter = "文档文件|*.txt";
        //        od.ShowDialog();
        //        string path = od.FileName;
        //        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
        //        {
        //            byte[] buffer = new byte[1024 * 1024 * 5];
        //            int r = fs.Read(buffer, 0, buffer.Length);
        //            richTextBox1.Text = Encoding.Default.GetString(buffer, 0, r);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            cx.Enabled = false;
            剪切XToolStripMenuItem.Enabled = false;
            恢复ToolStripMenuItem.Enabled = false;
            复制CToolStripMenuItem.Enabled = false;
            删除ToolStripMenuItem.Enabled = false;
            全选ToolStripMenuItem.Enabled = false;
            save = false;
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
            //panel1.Visible = false;
            richTextBox1.WordWrap = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }

        private void 显示TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;
        }

        private void 隐藏FToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // panel1.Visible = false;
        }

        private void 新建7NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                DialogResult dr = MessageBox.Show("未保存文件，是否保存？", "提示", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        Baocun bc = new Baocun();
                        bc.Get(richTextBox1);
                        richTextBox1.Clear();
                        save = true;
                        break;
                    case DialogResult.No:
                        richTextBox1.Clear();
                        save = false;
                        break;
                }
                save = false;
            }
            else
            {
                richTextBox1.Clear();
                save = false;
            }
        }

        public bool dk = true;
        public string openpath;
        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dk = false;
            if (save == false)
            {
                DialogResult dr = MessageBox.Show("未保存文件，是否保存？", "提示", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        Baocun bc = new Baocun();
                        bc.Get(richTextBox1);
                        Open o = new Open();
                        o.Set(richTextBox1);
                        string str = o.PathOPen;
                        save = true;
                        break;
                    case DialogResult.No:
                        richTextBox1.Clear();
                        Open op = new Open();
                        op.Set(richTextBox1);
                        openpath = op.PathOPen;
                        save = false;
                        break;
                }
            }
            else
            {
                Open o = new Open();
                o.Set(richTextBox1);
                openpath = o.PathOPen;
                save = false;
            }
        }

        public string name;
        private void 另存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dk == false && save == false)
            {
                using (FileStream filewrite = new FileStream(openpath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = Encoding.Default.GetBytes(richTextBox1.Text);
                    filewrite.Write(buffer, 0, buffer.Length);
                }
                save = true;
                dk = true;
            }
            else
            {
                if (save == false)
                {
                    Baocun bc = new Baocun();
                    bc.Get(richTextBox1);
                    name = bc.Path;
                    save = true;
                }
                if (save == true)
                {
                    if (name == null)
                    {
                        return;
                    }
                    using (FileStream filewrite = new FileStream(name, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        byte[] buffer = Encoding.Default.GetBytes(richTextBox1.Text);
                        filewrite.Write(buffer, 0, buffer.Length);
                    }
                    save = true;
                }
            }
        }

        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baocun bc = new Baocun();
            bc.Get(richTextBox1);
            save = true;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }

        private void 关闭CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭？", "提示", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    richTextBox1.Clear();
                    break;
                case DialogResult.No:
                    break;

            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭程序？", "提示", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    System.Environment.Exit(0);
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭程序？", "提示", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    e.Cancel = false;
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }
        }

        private void cx_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            cx.Enabled = true;
            剪切XToolStripMenuItem.Enabled = true;
            恢复ToolStripMenuItem.Enabled = true;
            复制CToolStripMenuItem.Enabled = true;
            删除ToolStripMenuItem.Enabled = true;
            全选ToolStripMenuItem.Enabled = true;
        }

        private void 恢复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void 剪切XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
            else
            {
                MessageBox.Show("请选择需要剪切的文档！", "提示");
            }
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Copy();
            }
            else
            {
                MessageBox.Show("请选择需要复制的文档！", "提示");
            }
        }

        private void 黏贴VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectedText = "";
            }
            else
            {
                MessageBox.Show("请选择需要删除的文档！", "提示");
            }
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 字体ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                FontDialog fd = new FontDialog();
                fd.ShowDialog();
                richTextBox1.SelectionFont = fd.Font;
            }
            else
            {
                MessageBox.Show("请选择需要修改字体的文档！", "提示");
            }
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                ColorDialog cd = new ColorDialog();
                cd.ShowDialog();
                richTextBox1.SelectionColor = cd.Color;
            }
            else
            {
                MessageBox.Show("请选择需要修改字体的文档！", "提示");
            }
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行ToolStripMenuItem.Checked == true)
            {
                richTextBox1.WordWrap = true;
                自动换行ToolStripMenuItem.Checked = false;
            }
            else
            {
                richTextBox1.WordWrap = false;
                自动换行ToolStripMenuItem.Checked = true;
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("没有帮助");
        }

        private void 关于本记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Six Six Six");
        }
    }
}
