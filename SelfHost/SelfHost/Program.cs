using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            new AppHost().Init().Start("http://*:8088/");
            "ServiceStack SelfHost listening at http://10.136.46.60:8088 ".Print();
            Process.Start("http://10.136.46.60:8088/");

            Console.ReadLine();
        }
    }
}
