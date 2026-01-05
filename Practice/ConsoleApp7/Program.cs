using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 숫자 데이터 형식
            // 정수, 실수 

            //int integerNum = 10;
            //float floatNum = 3.14f;
            //double doubleNum = 3.14;

            //Console.WriteLine(integerNum);
            //Console.WriteLine(floatNum);
            //Console.WriteLine(doubleNum);

            // 게임 캐릭터 스탯 

            byte level = 50;
            short attack = 1500;
            int gold = 12345;
            long exp = 999999L;

            Console.WriteLine("=== 캐릭터 정보 ===");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"소지금: {gold:N0}골드"); // N0: 천 단위 구분 
            Console.WriteLine( $"경험치 {exp:N0}");

            Console.WriteLine("\n=== 타입별 최대값 ===");
            Console.WriteLine($"byte 최대값: {byte.MaxValue}");
            Console.WriteLine($"short 최대값: {short.MaxValue}");
            Console.WriteLine($"int 최대값: {int.MaxValue}");  
            Console.WriteLine($"long 최대값: {long.MaxValue}");    
        }
    }
}
