using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 事件
{
    public delegate void DelPlay();
    class PlayMusic
    {
        public event DelPlay Play;
        public string Name { get; set; }
        public PlayMusic(string name)
        {
            this.Name = name;
        }
        public void PlaySongs()
        {
            Console.WriteLine("开始播放！");
            Thread.Sleep(3000);
            //Play?.Invoke();
            if (Play != null)
            {
                Play();
            }
        }
    }
}
