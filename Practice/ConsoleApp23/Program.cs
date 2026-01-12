using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Hello()
        {
            Console.WriteLine("안녕하세요");
        }

        static void ShowGameStart()
        {

            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║ ⚔ RPG 게임 시작 ⚔ ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
        }

        //함수 정의: 구분선 출력 
        static void PrintSeparator()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            ShowGameStart();
            PrintSeparator();
        }
    }
}
