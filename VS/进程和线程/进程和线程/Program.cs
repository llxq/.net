using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 进程和线程
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 进程       
            //Process[] p = Process.GetProcesses();
            ////Peocess的GetProcess方法是个静态方法，可以访问当前计算机正在运行的所有进程
            ////返回一个process类数组
            //foreach (var item in p)
            //{
            //    //关闭当前当前的进程
            //    //item.Kill();
            //    Console.WriteLine(item);
            //}

            ////通过进程开启应用程序
            //Process.Start("里面填写需要打开的程序");


            ////通过一个进程打开指定的文件
            //ProcessStartInfo psi = new ProcessStartInfo("里面添加一个路径即可");
            ////第一步，创建一个进程对象
            //Process pc = new Process();
            ////调用他的一个方法 StratInFo()，需要一个processstartinfor类对象
            //pc.StartInfo = psi;
            //pc.Start();
            //Console.ReadKey();
            #endregion
        }
    }
}
