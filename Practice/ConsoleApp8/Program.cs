using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float singlePrecision = 3.14f; // 4bytes 
            //double doublePrecision = 3.1415926535f; // 8bytes 
            //decimal highPrecision = 3.1415926535897932384626433833m; // 16bytes

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);

            //접미사 사용: 숫자의 데이터 형식을 명시 
            //int integerValue = 100;
            //long longValue = 100L;
            //float floatValue = 3.14f;
            //double doubleValue = 3.14;
            //decimal decimalValue = 3.14m;

            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);
            //Console.WriteLine(doubleValue);

            //char 형식: 단일 문자 
            //char letter = 'A';
            //char symbol = '#';
            //char number = '9'; 

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            //float 이동속도 5.5f; 
            //double 공격속도 1.25 
            //decimal 아이템 가격 12.99

            //float moveSpeed = 5.5f;
            //double attackSpeed = 1.25;
            //decimal itemPrice = 12.99m;

            //Console.WriteLine("==== 캐릭터 능력치 ====");
            //Console.WriteLine($"float 이동속도 {moveSpeed}");
            //Console.WriteLine($"double 공격속도 {attackSpeed}");
            //Console.WriteLine($"decimal 아이템 가격 {itemPrice}"); 

            //string: 여러 문자를 저장 
            //string greeting = "Hello, World!";
            //string name = "Alice";

            //Console.WriteLine(greeting); 
            //Console.WriteLine(name);

            //string playerName = "홍길동";
            //char grade = 'A';
            //char symbol = '★';
            //string welcomMessage = "게임에 오신 것을 환영합니다.";

            //Console.WriteLine("=== RPG 게임 ===");
            //Console.WriteLine($"플레이어: {playerName}");
            //Console.WriteLine($"등급: {grade}등급 {symbol}"); 
            //Console.WriteLine(welcomMessage); 

            // bool 형식: 참(true) 또는 거짓(false)
            //bool isRunning = true;
            //bool isPaused = false;
            //bool hasKey = false;
            //bool isDoorOpen = false;
            //bool isPlayerAlive = true; 

            //int hp = 80;
            //bool healthState = true; 

            //Console.WriteLine("=== 게임 상태 ===");
            //Console.WriteLine($"게임 실행 중: {isRunning}");
            //Console.WriteLine($"일시정지: {isPaused}");
            //Console.WriteLine($"열쇠 소지: {hasKey}");
            //Console.WriteLine($"문 열림: {isDoorOpen}");
            //Console.WriteLine($"플레이어 생존: {isPlayerAlive}");

            //Console.WriteLine("\n=== 캐릭터 상태 ==="); 

            //Console.WriteLine($"체력: {hp}");
            //Console.WriteLine($"건강상태: {healthState}");
            //Console.WriteLine($"위험 상태: {!healthState}"); 

            int number = 123; 
            string numberAsString = number.ToString();

            bool flag = true; 
            string flagAsString = flag.ToString();

            Console.WriteLine(numberAsString);
            Console.WriteLine(flagAsString);
        }
    }
}
