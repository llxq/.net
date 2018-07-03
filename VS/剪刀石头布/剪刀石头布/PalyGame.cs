using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 剪刀石头布
{
    class PalyGame
    {
        /// <summary>
        /// 返回玩家出的什么
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int Player(string str)
        {
            int number=0;
            switch (str)
            {
                case "剪刀":number = 1;
                    break;
                case "石头":number = 2;
                    break;
                case "布":number = 3;
                    break;
            }
            return number;
        }
    }
}
