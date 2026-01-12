using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////배열 -> 효율적 

            ////방법 1
            //int[] scores = new int[5];   //5개의 사물함을 준비

            ////방법 2 초기값과 함께 선언
            //int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            ////방법 3: 간단한 초기화
            //int[] values = { 1, 2, 3, 4, 5 };

            ////4번째
            //scores[0] = 1;
            //scores[1] = 2;
            //scores[2] = 3;
            //scores[3] = 4;
            //scores[4] = 5;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //string[] inventory = new string[5];

            ////아이템 추가
            //inventory[0] = "회복 포션";
            //inventory[1] = "마나 포션";
            //inventory[2] = "강철 검";
            //inventory[3] = "가죽 갑옷";
            //inventory[4] = "마법 반지";


            ////인벤토리 출력
            //Console.WriteLine("=== 인벤토리 ====");

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}
            //인벤토리 시스템 (최대 5개)
            //string[] inventory = new string[5];

            ////아이템 추가
            //inventory[0] = "회복 포션";
            //inventory[1] = "마나 포션";
            //inventory[2] = "강철 검";
            //inventory[3] = "가죽 갑옷";
            //inventory[4] = "마법 반지";


            ////인벤토리 출력
            //Console.WriteLine("=== 인벤토리 ====");

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}


            ////특정 아이템 사용
            //Console.WriteLine($"{inventory[0]}를 사용했습니다!");
            //inventory[0] = "(비어있음)";

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}

            //Console.WriteLine("=== 캐릭터 스탯 ===");
            // HP 100 
            // MP 50 
            // 공격력 80 
            // 방어력 60 
            // 민첩 45 


            //int[] status = { 100, 50, 80, 60, 45 };
            //string[] statusField = { "HP", "MP", "공격력", "방어력", "민첩" }; 

            //for(int i=0; i<status.Length; i++)
            //{
            //    Console.WriteLine($"{statusField[i]}: {status[i]}");
            //}

            //Console.WriteLine("=== 일일 퀘스트 진행도 ===");
            //string[] monsterName = { "고블린", "오크", "슬라임", "드래곤", "좀비" };
            //int required = 5;
            //int[] currentCaught = { 5, 3, 8, 2, 7 };

            //for (int i = 0; i < monsterName.Length; i++)
            //{
            //    Console.Write($"{monsterName[i]}: {currentCaught[i]}/{required}");
            //    if (currentCaught[i] >= required)
            //        Console.WriteLine(" 완료");
            //    else
            //        Console.WriteLine(" 진행중");
            //}

            //int[] scores = { 85, 92, 78, 95, 88 };

            ////배열 길이
            //Console.WriteLine("총 점수 개수: " + scores.Length);

            ////배열 순회
            //Console.WriteLine("개별 점수");
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"플레이어 {i + 1} : {scores[i]}점");
            //}


            ////합계 계산
            //int sum = 0;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    sum += scores[i];
            //}

            //Console.WriteLine($"총점 : {sum}점");
            //Console.WriteLine($"평균 : {(float)sum / (float)scores.Length}점");

            //int max = 0;
            //int min = 999; 

            //for(int i=0; i< scores.Length; i++)
            //{
            //    if (scores[i] > max)
            //        max = scores[i];
            //    if (scores[i] < min)
            //        min = scores[i];
            //}

            ////최고점 찾기
            //Console.WriteLine($"최고점: {max}");

            ////최저점 찾기 
            //Console.WriteLine($"최저점: {min}");

            ////Array 클래스 메서드 활용
            //Console.WriteLine("=== Array 메서드 ===");

            ////정렬
            //int[] sortedScores = (int[])scores.Clone();  //복사본 생성
            //Array.Sort(sortedScores);
            //Console.WriteLine("정렬 후: ");

            ////for (int i = 0; i < sortedScores.Length; i++)
            ////{
            ////    Console.WriteLine(sortedScores[i]);
            ////}

            ////반복문 foreach
            //foreach (int score in sortedScores)
            //{
            //    Console.WriteLine(score);
            //}




            ////85, 92, 78, 95, 88

            ////역순정렬
            //Array.Reverse(sortedScores);
            //Console.WriteLine("역순: ");

            //for (int i = 0; i < sortedScores.Length; i++)
            //{
            //    Console.WriteLine(sortedScores[i]);
            //}

            //foreach (int score in sortedScores)
            //{
            //    Console.WriteLine(score);
            //}
            ////검색
            //int searchScore = 92;
            //int index = Array.IndexOf(scores, searchScore);
            //Console.WriteLine($"{searchScore}점의 위치: 인덱스 {index}");
            //Console.WriteLine("찾은값 : " + scores[index]);

            //int[,] array = new int[3, 4];

            //// 전체 요소 개수
            //int totalElements = array.Length;  // 12 (3 x 4)

            //// 특정 차원의 길이
            //int rows = array.GetLength(0);     // 3 (행 개수)
            //int cols = array.GetLength(1);     // 4 (열 개수)

            //// Rank: 배열의 차원 수
            //int dimensions = array.Rank;       // 2

            //string[,] seats = new string[3, 3];
            //string[] s = { "A", "B", "C" }; 

            //for(int i=0; i<seats.GetLength(1); i++)
            //{
            //    for(int j=1; j<=seats.GetLength(0); j++)
            //        Console.Write($"[{s[i]}{j}]");

            //    Console.WriteLine();
            //}


            ////=== 좌석 배치도 ===

            ////[A1][A2][A3]
            ////[B1][B2][B3]
            ////[C1][C2][C3]

            ////3 x 3 좌석 배치도
            //string[,] seats = new string[3, 3]
            //{
            //   { "A1","A2","A3"},
            //   { "B1","B2","B3"},
            //   { "C1","C2","C3"}
            //};

            //Console.WriteLine("=== 좌석 배치도 ===");


            ////행(row) 반복
            //for (int row = 0; row < seats.GetLength(0); row++)
            //{
            //    //열(column) 반복
            //    for (int col = 0; col < seats.GetLength(1); col++)
            //    {
            //        Console.Write($"[{seats[row, col]}]");
            //    }
            //    Console.WriteLine(); //줄바꿈
            //}


            ////첫 번째 좌석: A1
            ////중앙 좌석: B2
            ////마지막 좌석: C3
            //Console.WriteLine("첫 번째 좌석: " + seats[0, 0]);
            //Console.WriteLine("중앙 좌석: " + seats[1, 1]);
            //Console.WriteLine("마지막 좌석: " + seats[2, 2]);

            ////2D 게임맵
            //int[,] map = new int[5, 5]
            //{
            //  { 0,0,1,0,0},
            //  { 0,2,1,0,3},
            //  { 0,0,1,0,0},
            //  { 1,1,1,0,0},
            //  { 0,0,0,0,9},
            //};

            //Console.WriteLine("==던전맵==");
            //Console.WriteLine("0: 통로 1: 벽 2: 몬스터 3: 보물 9: 출구\n");
            //Console.OutputEncoding = Encoding.UTF8;

            ////맵 출력
            //for (int y = 0; y < map.GetLength(0); y++)
            //{
            //    for (int x = 0; x < map.GetLength(1); x++)
            //    {
            //        switch (map[y, x])
            //        {
            //            case 0:
            //                Console.Write("⬜ ");
            //                break;
            //            case 1:
            //                Console.Write("⬛ ");
            //                break;
            //            case 2:
            //                Console.Write("👹 ");
            //                break;
            //            case 3:
            //                Console.Write("💎 ");
            //                break;
            //            case 9:
            //                Console.Write("🚪 ");
            //                break;
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //string[] name = new string[3] { "김철수", "이영희", "박민수" };
            //string[] className = new string[4] { "국어", "영어", "수학", "과학" }; 

            //int[,] grade = new int[3, 4]
            //{
            //    {85, 90, 88, 92},
            //    {78, 85, 90, 87},
            //    {92, 88, 95, 90}
            //};

            //Console.WriteLine("=== 성적표 ===");
            //Console.WriteLine("이름  국어  영어  수학  과학  평균");
            //Console.WriteLine("==============");

            //for (int i=0; i<grade.GetLength(0); i++)
            //{
            //    int sum = 0;
            //    double avg = 0;

            //    Console.Write($"{name[i]} ");

            //    for (int j=0; j < grade.GetLength(1); j++)
            //    {
            //        sum += grade[i, j]; 
            //        Console.Write($"{grade[i, j]}   ");
            //    }

            //    avg = (double) sum / grade.GetLength(1);
            //    Console.WriteLine($"{avg:F1}점");
            //}

            //Console.WriteLine();

            //Console.WriteLine("=== 과목별 평균 ===");

            //for(int i=0; i<grade.GetLength(1); i++)
            //{
            //    int sum = 0;
            //    double avg = 0; 

            //    for(int j=0; j < grade.GetLength(0); j++)
            //        sum += grade[j, i]; 

            //    avg = ((double)sum / grade.GetLength(0));

            //    Console.WriteLine($"{className[i]} : {avg:F1}점");

            //}

            //// 가변 배열
            //string[][] raid = new string[3][];

            //raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" };  //4명
            //raid[1] = new string[] { "도적", "전사", "힐러" };            //3명
            //raid[2] = new string[] { "마법사", "궁수", "힐러", "전사", "탱커" }; //5명

            //Console.WriteLine("=== 레이드 파티 구성 ===");
            //for (int i = 0; i < raid.Length; i++)
            //{
            //    Console.WriteLine($"파티 {i + 1} ({raid[i].Length}명):");
            //    for (int j = 0; j < raid[i].Length; j++)
            //    {
            //        Console.WriteLine($" - {raid[i][j]}");
            //    }
            //}

            //// 선언 방법
            //List<int> numbers = new List<int>();           // 빈 리스트
            //List<string> names = new List<string>();       // 문자열 리스트
            //List<float> prices = new List<float>();        // 실수 리스트

            //// 초기값과 함께 선언
            //List<int> scores = new List<int> { 85, 90, 78, 95 };
            //List<string> items = new List<string> { "검", "방패", "포션" };

            //// C# 3.0 이후 간단한 초기화
            //var players = new List<string> { "철수", "영희", "민수" };

            //List<string> inventory = new List<string>();

            //Console.WriteLine("=== 도적 인벤토리 시스템 ===");

            //inventory.Add("회복 포션");
            //inventory.Add("마나 포션");
            //inventory.Add("강철 검");
            //Console.WriteLine("아이템 3개 추가");

            //Console.WriteLine($"인벤토리 ({inventory.Count}개): ");

            //for(int i=0; i<inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}
            //Console.WriteLine();
            //inventory[0] = "초록포션";

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}
            //Console.WriteLine();
            ////특정 위치에 추가 (Insert)
            //inventory.Insert(1, "전설 검");

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}

            ////아이템 제거 (Remove)
            //inventory.Remove("초록포션");
            //Console.WriteLine();

            //for (int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}

            //Dictionary<string, int> stats = new Dictionary<string, int>();

            //stats.Add("HP", 150);
            //stats.Add("MP", 80); 

            //foreach(KeyValuePair<string, int> stat in stats)
            //{
            //    Console.WriteLine($"{stat.Key}: {stat.Value}");
            //}

            //if (stats.ContainsKey("방어력"))
            //    Console.WriteLine(stats["방어력"]);
            //else
            //    Console.WriteLine("해당 스탯은 존재하지 않습니다.");

            int goldAmount = 600; 

            Console.WriteLine("=== 상점 아이템 ===");
            Dictionary<string, int> items = new Dictionary<string, int>()
            {
                {"회복 포션", 50},
                {"마나 표션", 40 },
                {"강철 검", 500 },
                {"가죽 갑옷", 300 },
                {"마법 반지", 1000 }
            };


            foreach(var item in items) 
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.Write("구매할 아이템 입력: ");
            string itemName = Console.ReadLine(); 

            if(items.ContainsKey(itemName) && goldAmount >= items[itemName])
            {
                Console.WriteLine($"{itemName} 구매 성공!");
                Console.WriteLine($"남은 골드: {goldAmount - items[itemName]}"); 
            }
            else
            {
                Console.WriteLine("아이템이 존재하지 않거나 골드가 부족합니다.");
            }
        }

    }
}
