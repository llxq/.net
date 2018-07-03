using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 剪刀石头布
{
    class PlayResult
    {
        public enum Result
        {
            玩家赢,
            电脑赢,
            平手
        }
        public static Result Res(int PlayerNumber, int CpuNumber)
        {
            if (PlayerNumber - CpuNumber == -1 || PlayerNumber - CpuNumber == 2)
            {
                return Result.玩家赢;
            }
            else if (PlayerNumber == CpuNumber)
            {
                return Result.平手;
            }
            else
            {
                return Result.电脑赢;
            }

        }
    }
}
