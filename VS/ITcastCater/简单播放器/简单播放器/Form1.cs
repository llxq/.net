using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace 简单播放器
{
    public partial class F1 : Form
    {
        public F1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();
        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileopen = new OpenFileDialog();
                fileopen.Title = "请选择需要打开的文件";
                fileopen.Filter = "MP3文件|*.mp3|Wav文件|*.wav|所有文件|*.*";
                fileopen.Multiselect = true;
                fileopen.ShowDialog();
                string[] str = fileopen.FileNames;
                for (int i = 0; i < str.Length; i++)
                {
                    listBox1.Items.Add(Path.GetFileName(str[i]));
                    list.Add(str[i]);
                }
                if (listBox1.Items.Count > 0)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\Administrator\Desktop\VS\简单播放器\简单播放器\img\1.jpg");
            playMusic.settings.autoStart = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }
        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        bool b = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "播放")
            {
                if (listBox1.SelectedIndex < 0)
                {
                    playMusic.URL = list[0];
                    listBox1.SelectedIndex = 0;
                    playMusic.Ctlcontrols.play();
                    button1.Text = "暂停";
                }
                else
                {
                    if (b == false)
                    {
                        playMusic.URL = list[listBox1.SelectedIndex];
                    }
                    playMusic.Ctlcontrols.play();
                    button1.Text = "暂停";
                }

            }
            else if (button1.Text == "暂停")
            {
                b = true;
                playMusic.Ctlcontrols.pause();
                button1.Text = "播放";
            }
        }
        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            playMusic.Ctlcontrols.stop();
            button1.Text = "播放";
        }
        /// <summary>
        /// 双击播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("请选择需要播放的文件");
                return;
            }
            try
            {
                playMusic.URL = list[listBox1.SelectedIndex];
                playMusic.Ctlcontrols.play();
                button1.Text = "暂停";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        int index;
        private void button4_Click(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
            listBox1.SelectedIndices.Clear();
            if (index < 0)
            {
                index = 0;
            }
            else
            {
                if (index == 0)
                {
                    index = listBox1.Items.Count - 1;
                }
                else
                {
                    index--;
                }
            }
            playMusic.URL = list[index];
            playMusic.Ctlcontrols.play();
            button1.Text = "暂停";
            listBox1.SelectedIndex = index;
        }
        /// <summary>
        /// 下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
            listBox1.SelectedIndices.Clear();
            if (index < 0)
            {
                index = 0;
            }
            else
            {
                if (index == listBox1.Items.Count - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            button1.Text = "暂停";
            playMusic.URL = list[index];
            playMusic.Ctlcontrols.play();
            listBox1.SelectedIndex = index;
        }
        /// <summary>
        /// 删除选中项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取选中的个数
            int count = listBox1.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                //按照个数删除选中的索引
                //必须先删除集合的在删除列表的，因为我们删除是根据列表的缩影删除的
                list.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            if (listBox1.Items.Count == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                playMusic.Ctlcontrols.pause();
            }
        }
        /// <summary>
        /// 显示歌词
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 静音 放音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "放音")
            {
                playMusic.settings.mute = true;
                button6.Text = "静音";
            }
            else if (button6.Text == "静音")
            {
                playMusic.settings.mute = false;
                button6.Text = "放音";
            }
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            b = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //判断播放器的状态是否处于播放中
            if (playMusic.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //获取当前进度
                double d1 = playMusic.Ctlcontrols.currentPosition + 1;
                //获取总的进度条
                double d2 = playMusic.currentMedia.duration;
                //判断两个是否相同
                if (d1 >= d2)
                {
                    index = listBox1.SelectedIndex;
                    listBox1.SelectedIndices.Clear();
                    if (index < 0)
                    {
                        index = 0;
                    }
                    else
                    {
                        if (index == listBox1.Items.Count - 1)
                        {
                            index = 0;
                        }
                        else
                        {
                            index++;
                        }
                    }
                    button1.Text = "暂停";
                    playMusic.URL = list[index];
                    playMusic.Ctlcontrols.play();
                    listBox1.SelectedIndex = index;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            playMusic.settings.volume += 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            playMusic.settings.volume -= 5;
        }
    }
}
