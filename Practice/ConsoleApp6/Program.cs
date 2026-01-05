using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 상수: 값을 변경할 수 없는 변수 
            //const double Pi = 3.14159;
            //const int MaxScore = 100;

            //Console.WriteLine($"Pi: {Pi}");
            //Console.WriteLine($"Max Score: {MaxScore}");

            const int MAX_PLAYER_NUM = 4;
            const int INIT_GOLD = 1000;
            const string VERSION = "1.0.0";

            Console.WriteLine("=== 게임 설정 ===");
            Console.WriteLine($"최대 플레이어: {MAX_PLAYER_NUM}");
            Console.WriteLine($"시작 골드: {INIT_GOLD}G"); 
            Console.WriteLine($"버전: {VERSION}");
        }
    }
}
