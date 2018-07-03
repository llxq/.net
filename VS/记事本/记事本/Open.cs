using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 记事本
{
    class Open
    {
        public string PathOPen
        {
            get;
            set;
        }
        public void Set(RichTextBox txt)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "请选择您所需要打开的文件";
            od.Multiselect = false;
            od.Filter = "文档文件|*.txt";
            od.ShowDialog();
            this.PathOPen = od.FileName;
            if (od.FileName == "")
            {
                return;
            }
            using (FileStream fs = new FileStream(this.PathOPen, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fs.Read(buffer, 0, buffer.Length);
                txt.Text = Encoding.Default.GetString(buffer, 0, r);
            }
        }
    }
}
