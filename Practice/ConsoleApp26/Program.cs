using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        //정수반환
        static int GetNumber() //정수반환
        {
            return 42;
        }
        static string GetString()
        {
            return "Hello World!";
        }

        static string ConnectMessage(string name)
        {
            return name + "님이 접속했습니다";
        }
        static void Main(string[] args)
        {
            string cm = ConnectMessage("준수");
            Console.WriteLine(cm);
        }
    }
}
