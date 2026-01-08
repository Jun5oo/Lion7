using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("=== 대장장이 키우기 ===");

            //int goldAmount = 0;
            //int cp = 0; 

            //Random rand = new Random();

            //while (true)
            //{
            //    Console.Write("행동을 선택해주세요. 1. 나무캐기 2. 장비제작 3.나가기 "); 
            //    int selected = int.Parse(Console.ReadLine());

            //    if(selected == 1)
            //    {
            //        Console.WriteLine("나무캐기");
            //        int random = rand.Next(100, 200);
            //        Console.WriteLine($"나무를 캐서 팔았습니다. {random}골드를 획득했습니다.");
            //        goldAmount += random;
            //        Console.WriteLine($"현재 골드: {goldAmount}");
            //    }

            //    else if(selected == 2) 
            //    {
            //        Console.WriteLine("장비 제작");
            //        if (goldAmount < 1000)
            //            Console.WriteLine("골드가 부족합니다.");
            //        else
            //        {
            //            int random = rand.Next(10, 100);
            //            goldAmount -= 1000;
            //            Console.WriteLine($"장비를 제작했습니다. 남은 골드: {goldAmount}");
            //            Console.WriteLine($"능력치가 {random}인 장비를 제작했습니다. 능력치가 상승했습니다.");
            //            cp += random; 
            //            Console.WriteLine($"현재 능력치 {cp}");
            //        }
            //    }

            //    else
            //    {
            //        Console.WriteLine("게임을 종료했습니다."); 
            //        break; 
            //    }
            //랜덤

            //Random rand = new Random();

            //Console.WriteLine(" 대장장이 키우기 ");

            //int gold = 100;
            //int input;
            //int random;

            //Thread.Sleep(500);


            ////무한반복
            //while (true)
            //{
            //    Console.Clear(); //화면지우기
            //    Console.WriteLine("1. 나무캐기 ");
            //    Console.WriteLine("2. 장비뽑기 ");
            //    Console.WriteLine("3. 나가기 ");
            //    Console.Write("입력 : ");
            //    input = int.Parse(Console.ReadLine()); //input에 키로 눌린 숫자 담기

            //    if (input == 1) //나무캐기화면
            //    {
            //        while (true)
            //        {
            //            Console.WriteLine("나무캐기(엔터)");
            //            Console.WriteLine("뒤로가기 x");

            //            string str = Console.ReadLine();

            //            gold += 100;
            //            Console.WriteLine("소지금 : " + gold);
            //            if (str == "x")
            //            {
            //                Console.WriteLine("뒤로가기");
            //                break;
            //            }


            //        }
            //    }
            //    else if (input == 2)
            //    {
            //        //장비뽑기
            //        if (gold >= 1000) //돈이 있는지 확인후 뽑기
            //        {
            //            gold -= 1000;

            //            //20번 뽑기
            //            for (int i = 1; i <= 20; i++)
            //            {
            //                random = rand.Next(1, 101);

            //                if (random == 1) // 1퍼
            //                {
            //                    Console.WriteLine("도끼등급 SSS");
            //                }
            //                else if (random >= 2 && random <= 6)
            //                {
            //                    Console.WriteLine("도끼등급 SS");
            //                }
            //                else if (random >= 7 && random <= 17)
            //                {
            //                    Console.WriteLine("도끼등급 S");
            //                }
            //                else if (random >= 18 && random <= 38)
            //                {
            //                    Console.WriteLine("도끼등급 A");
            //                }
            //                else if (random >= 39 && random <= 69)
            //                {
            //                    Console.WriteLine("도끼등급 B");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("도끼등급 C");
            //                }
            //                Thread.Sleep(500); //0.5초정도로 뽑혀라.

            //            }


            //        }
            //        else
            //        {
            //            Console.WriteLine("돈이 부족합니다. \n");
            //            Thread.Sleep(1000);
            //        }
            //    }
            //    else if (input == 3)
            //    {
            //        Console.WriteLine("게임을 나갑니다.");
            //        Environment.Exit(0);
            //    }

            //}

            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //        Console.Write("□");

            //    Console.WriteLine();
            //}
            // === 예제 2: 숫자 표 ===

            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //        Console.Write($"{j} ");
            //    Console.WriteLine();
            //}

            //=== 예제 3: 좌표 찍기 === 
            //(0, 0)(1, 0)(2, 0)
            //(0, 1)(1, 1)(2, 1)
            //(0, 2)(1, 2)(2, 2)

            //for(int i=0; i<3; i++)
            //{
            //    for(int j=0; j<3; j++)
            //    {
            //        Console.Write($"({j},{i})");
            //    }
            //    Console.WriteLine();
            //}

            //예제 4: 계단
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //for (int y = 0; y < 5; y++)
            //{
            //    for (int x = 0; x < 5; x++)
            //    {
            //        Console.Write($"({x},{y}) ");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (j <= i)
            //        {
            //            Console.Write("*");
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (j >= i)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("=== 에제 5: 2단곱셈표 ===");
            //for(int i=1; i<=3; i++)
            //{
            //    for(int j=1; j<=3; j++)
            //        Console.Write($"{i} x {j} = {i * j} ");
               
            //    Console.WriteLine();
            //}

            for(int i=0; i<4; i++)
            {
                for(int j=0; j<4; j++)
                {
                    if (i == 0 && j == 0)
                        Console.Write("■");

                    else if (i == 3 && j == 3) 
                        Console.Write("▲");
                    else
                        Console.Write("ㅁ");
                }
                Console.WriteLine();
            }
        }
    }
}
