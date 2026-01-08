using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int day = 3;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break; 
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;                
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;                 
            //    case 4:
            //        Console.WriteLine("화요일");
            //        break; 
            //}

            //캐릭터 선택화면을 switch로 만드시오
            //jobChoice = 1; //1: 전사 2: 마법사 3: 궁수 4: 도적
            //Console.WriteLine("=== 캐릭터 생성 ===");
            //Console.WriteLine();
            //Console.WriteLine("1: 전사 2: 마법사 3: 궁수 4: 도적");
            //Console.WriteLine();
            //Console.WriteLine("생성할 캐릭터를 입력하세요");

            //int jobChoice = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //switch (jobChoice)
            //{
            //    case 1:
            //        Console.WriteLine("전사를 선택했습니다.");
            //        Console.WriteLine();
            //        Console.WriteLine("직업: 전사");
            //        Console.WriteLine("특성: 높은 체력과 방어력");
            //        Console.WriteLine("주 무기: 검");
            //        Console.WriteLine("스탯: 체력 + 100, 공격력 +10"); 
            //        break; 
            //    case 2: 
            //        Console.WriteLine("마법사를 선택했습니다.");
            //        Console.WriteLine();
            //        Console.WriteLine("직업: 마법사");
            //        Console.WriteLine("특성: 강력한 마법공격");
            //        Console.WriteLine("주 무기: 지팡이, 마법서");
            //        Console.WriteLine("스탯: 마나 +100, 주문공격력 +20");
            //        break;
            //    case 3:
            //        Console.WriteLine("궁수를 선택했습니다.");
            //        Console.WriteLine();
            //        Console.WriteLine("직업: 궁수");
            //        Console.WriteLine("빠른 이동속도와 먼 사거리");
            //        Console.WriteLine("주 무기: 활");
            //        Console.WriteLine("스탯: 이동속도 +10, 사거리 +30");
            //        break;
            //    case 4: 
            //        Console.WriteLine("도적을 선택했습니다.");
            //        Console.WriteLine();
            //        Console.WriteLine("직업: 도적");
            //        Console.WriteLine("빠른 이동속도와 공격력");
            //        Console.WriteLine("주 무기: 단검");
            //        Console.WriteLine("스탯: 이동속도 +15, 공격력 + 20");
            //        break;
            //    default:
            //        Console.WriteLine("잘못된 입력입니다.");
            //        break; 
            //}
            //// 아이템 타입별 설명
            //Console.WriteLine("\n=== 아이템 정보 ===");
            //string itemType = "weapon";

            //switch (itemType)
            //{
            //    case "weapon":
            //        Console.WriteLine("무기 - 공격력 증가");
            //        break;
            //    case "armor":
            //        Console.WriteLine("방어구 - 방어력 증가");
            //        break;
            //    case "potion":
            //        Console.WriteLine("물약 - 체력/마나 회복");
            //        break;
            //    case "accessory":
            //        Console.WriteLine("장신구 - 특수 능력 부여");
            //        break;
            //    default:
            //        Console.WriteLine("알 수 없는 아이템");
            //        break;
            //}

            //// 요일별 이벤트
            //Console.WriteLine("\n=== 오늘의 이벤트 ===");
            //int dayOfWeek = 3;  // 0:일, 1:월, 2:화, 3:수, 4:목, 5:금, 6:토

            //switch (dayOfWeek)
            //{
            //    case 0:
            //        Console.WriteLine("일요일: 경험치 2배");
            //        break;
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //        Console.WriteLine("평일: 일반 보상");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일: 골드 2배");
            //        break;
            //    case 6:
            //        Console.WriteLine("토요일: 아이템 드롭률 2배");
            //        break;
            //    default:
            //        Console.WriteLine("잘못된 요일");
            //        break;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("천마연산신공"); //엄청길게 캐스팅해야하는 구절
            //}

            //int goblinNum = 5;

            //Console.WriteLine("=== 몬스터 웨이브 시작 ==="); 

            //for(int i=1; i<=5; i++)
            //    Console.WriteLine($"고블린 #{i} 생성!");

            //Console.WriteLine($"총 {goblinNum} 생성 완료"); 

            //for(int i=5; i>=1; i--)
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine($"{i}..."); 
            //}

            //Thread.Sleep(1000);
            //Console.WriteLine("게임 시작!");

            //// Random 객체 생성
            //Random random = new Random();

            //// 주요 메서드
            //int number1 = random.Next();           // 0 ~ int.MaxValue
            //int number2 = random.Next(10);         // 0 ~ 9
            //int number3 = random.Next(1, 7);       // 1 ~ 6 (주사위)
            //double number4 = random.NextDouble();  // 0.0 ~ 1.0

            //검 종류 
            //무한의 대검
            //카타나
            //엑스칼리버
            //정기점검
            //집행검
            //빛의 봉인검 

            //List<string> swordLists = new List<string> { "무한의 대검", "카타나", "엑스칼리버", "정기점검", "집행검", "빛의 봉인검" }; 

            //for( ; ; )
            //{
            //    Random random = new Random();
            //    int idx = random.Next(0, swordLists.Count);
            //    Console.WriteLine(swordLists[idx]);
            //    Thread.Sleep(1000);
            //}

            string sword = "무한의 대검"; 

            Random rand = new Random(); 

            for(int i=0; i<20; i++)
            {
                int p = rand.Next(1, 101);

                if (p >= 1 && p <= 10)
                    sword = "무한의 대검";
                else if (p >= 11 && p <= 30)
                    sword = "카타나";
                else if (p >= 31 && p <= 60)
                    sword = "엑스칼리버";
                else if (p >= 61 && p <= 100)
                    sword = "정기점검";

                Console.WriteLine(sword);
                Thread.Sleep(500); 
            }
        }
    }
}
