using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 记事本
{
    class Baocun
    {
        public string Path
        {
            get;
            set;
        }
        public void Get(RichTextBox txt)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Title = "请选择你所保存的路径和名字";
            s.Filter = "文本文件|*.txt|所有文件|*.*";
            s.ShowDialog();
            string str = s.FileName;
            if (str == "")
            {
                return;
            }
            using (FileStream filewrite = new FileStream(str, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(txt.Text);
                filewrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功！","提示");
            this.Path = s.FileName;
        }

    }
}
