using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 飞行棋
{
    class Program
    {
        //定义一个数组接受地图的初始化
        public static int[] map = new int[100];
        //定义两个玩家  用数组存放
        public static int[] PlayerPos = new int[2];
        //定义一个数组存放两个玩家的姓名
        public static string[] Names = new string[2];
        //定义两个bool变量
        public static bool[] forst = new bool[2];
        static void Main(string[] args)
        {

            GameShow();
            PlayName();
            //当玩家姓名输入完毕的时候 我们应该清屏
            Console.Clear();
            GameShow();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Names[0]}的士兵用A表示");
            Console.WriteLine($"{Names[1]}的士兵用B表示");
            Console.ForegroundColor = ConsoleColor.Yellow;
            T();
            Map();
            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
            {
                Judge();
                if (forst[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    forst[0] = true;
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了{1}", Names[0], Names[1]);
                    Console.ReadKey(true);
                    break;
                }
                if (forst[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    forst[1] = true;
                }
                if (PlayerPos[1] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了{1}", Names[0], Names[1]);
                    Console.ReadKey(true);
                    break;
                }
            }
            Console.ReadKey();
        }
        //封装是否超出地图界限
        public static void Judge()
        {
            if (PlayerPos[0] < 0)
            {
                PlayerPos[0] = 0;
            }
            else if (PlayerPos[0] >= 99)
            {
                PlayerPos[0] = 99;
            }
            if (PlayerPos[1] < 0)
            {
                PlayerPos[1] = 0;
            }
            else if (PlayerPos[1] >= 99)
            {
                PlayerPos[1] = 99;
            }
        }
        //玩游戏
        public static void PlayGame(int playnumber)
        {
            Random R = new Random();
            int number = R.Next(1, 7);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Names[playnumber]}玩家按任意键开始掷骰子");
            //这行代码的意思就是说 让用户按任意键继续 但是不返回按的值
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{Names[playnumber]}投掷了{number}");
            //Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Names[playnumber]}玩家按任意键行动");
            Console.ReadKey(true);
            PlayerPos[playnumber] += number;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"玩家{Names[playnumber]}行动完了");
            //Console.ReadKey(true);
            if (PlayerPos[playnumber] == PlayerPos[1 - playnumber])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("玩家{0}踩到了玩家{1},玩家{2}退6格", Names[playnumber], Names[1 - playnumber], Names[playnumber]);
                PlayerPos[playnumber] -= 6;
                Console.ReadKey(true);
            }
            else
            {
                //判断玩家0踩的是什么
                switch (map[PlayerPos[playnumber]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了方块，安全！", Names[playnumber]);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}踩到了幸运轮盘,请选择1-交换位置 2-轰炸对方,让玩家{1}退6格", Names[playnumber], Names[1 - playnumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}选择了跟{1}交换位置", Names[playnumber], Names[1 - playnumber]);
                                int trmp;
                                trmp = PlayerPos[playnumber];
                                PlayerPos[playnumber] = PlayerPos[1 - playnumber];
                                PlayerPos[1 - playnumber] = trmp;
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择了轰炸玩家{1},玩家{2}退6格", Names[playnumber], Names[1 - playnumber], Names[1 - playnumber]);
                                PlayerPos[1 - playnumber] -= 6;
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1-交换位置 2-轰炸对方,请重新输入");
                                input = Console.ReadLine();
                                Console.ReadKey(true);
                            }
                        }
                        Console.ReadKey(true);
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到了地雷，退6格", Names[playnumber]);
                        PlayerPos[playnumber] -= 6;
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到了暂停,暂停一回合", Names[playnumber]);
                        forst[playnumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到了时空隧道，前前进8格", Names[playnumber]);
                        PlayerPos[playnumber] += 8;
                        Console.ReadKey(true);
                        break;
                }
            }
            Console.Clear();
            Judge();
            T();
            Map();
        }
        //显示各个图标信息
        public static void T()
        {
            Console.Write("图例：◎：代表幸运转盘");
            Console.Write("\t★:代表地雷");
            Console.Write("\t▲:代表幸暂停");
            Console.WriteLine("\t●:代表时空隧道");
        }
        //输入游戏名字
        public static void PlayName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("请输入A的姓名：");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Names[0] = Console.ReadLine();
            while (Names[0] == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("输入的A的姓名不能为空！请重新输入：");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Names[0] = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("请输入B的姓名：");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Names[1] = Console.ReadLine();
            while (Names[1] == "" || Names[0] == Names[1])
            {
                if (Names[1] == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("输入的B的姓名不能为空！请重新输入：");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Names[1] = Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("输入的A和B的姓名不能相同！请重新输入B的姓名：");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Names[1] = Console.ReadLine();
                }
            }
        }
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**********这是一个飞行棋**********");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("**********************************");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("**********************************");
        }

        //地图方法 就是将第一行第一竖第二行第二竖第三行放在了一起 
        public static void Map()
        {
            //绘制图标
            MapIcon();
            //第一行
            FirsrLine();
            Console.WriteLine();
            //第一竖
            FirstErect();
            //第二行
            SecondLine();
            //第二竖
            SecondErect();
            //第三竖
            ThirdlyLine();
            Console.WriteLine();
        }

        //绘制游戏地图的各个图标
        public static void MapIcon()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运转盘
            for (int i = 0; i < luckyturn.Length; i++)
            {
                map[luckyturn[i]] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷
            for (int i = 0; i < landMine.Length; i++)
            {
                map[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };//暂停
            for (int i = 0; i < pause.Length; i++)
            {
                map[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                map[timeTunnel[i]] = 4;
            }
        }

        //i的方法
        public static string Number(int i)
        {
            string str = "";
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.White;
                str = "<>";
            }
            else if (PlayerPos[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.White;
                str = "→";
            }
            else if (PlayerPos[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.White;
                str = "←";
            }
            else
            {
                switch (map[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "★";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        str = "●";
                        break;
                }
            }
            return str;
        }

        //第一行
        public static void FirsrLine()
        {
            //画第一行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(Number(i));
            }
        }
        //第一竖
        public static void FirstErect()
        {
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(Number(i));
                Console.WriteLine();
            }
        }
        //第二行
        public static void SecondLine()
        {
            for (int i = 64; i > 35; i--)
            {
                Console.Write(Number(i));
            }
        }
        //第二竖
        public static void SecondErect()
        {
            for (int i = 65; i < 70; i++)
            {
                Console.WriteLine(Number(i));
            }
        }
        //第三行
        public static void ThirdlyLine()
        {
            for (int i = 70; i < 100; i++)
            {
                Console.Write(Number(i));
            }
        }

    }
}
