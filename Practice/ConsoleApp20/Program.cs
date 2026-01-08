using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(70, 25); //콘솔 창 크기 설정 (가능 80, 세로 25)
            Console.SetBufferSize(70, 25); //버퍼 크기도 동일하게 설정 (스크롤 방지)

            int width = Console.WindowWidth - 1;
            int height = Console.WindowHeight - 1;

            //테두리 벽 
            bool[,] wall = new bool[width, height];
            //블록 위치 
            bool[,] block = new bool[width, height];
            
            for(int y=0; y<height; y++)
            {
                for(int x=0; x<width; x++)
                {
                    if (y == 0 || y == height - 1|| x == 0 || x == width - 1)
                        wall[x, y] = true; 
                }
            }

            // 캐릭터 위치
            int currentX = 10;
            int currentY = 10;
            // 캐릭터 방향 
            int dirX = 1;
            int dirY = 0;
            //음식을 생성해도 되는가 
            bool isFoodExist = false; 
            //음식 위치 
            int foodX = 0;
            int foodY = 0;

            //점수 
            int score = 0;

            Random random = new Random();

            ConsoleKeyInfo keyInfo; //키 관련된 정보
            Console.CursorVisible = false;

            // 벽 그리기 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (wall[x, y])
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write("@");
                    }
                }
            }

            while (true)
            {
                // 방향키 입력으로 인한 방향 전환 
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            dirX = 0;
                            dirY = -1;
                            break;
                        case ConsoleKey.DownArrow:
                            dirX = 0;
                            dirY = 1;
                            break;
                        case ConsoleKey.LeftArrow:
                            dirX = -1;
                            dirY = 0;
                            break;
                        case ConsoleKey.RightArrow:
                            dirX = 1;
                            dirY = 0;
                            break;
                        case ConsoleKey.Escape: break;
                    }
                }

                Console.SetCursorPosition(currentX, currentY);

                if (!block[currentX, currentY])
                    Console.Write(" ");
                else
                    Console.Write("X"); 

                int nextX = currentX + dirX; 
                int nextY = currentY + dirY;

                // 블럭 또는 벽에 부딪혔을 때 
                if (block[nextX, nextY] || wall[nextX, nextY])
                {
                    Console.Clear();
                    Console.WriteLine($"GameOver: {score}점을 획득했습니다.");
                    break;
                }

                // 음식을 획득했을 때 
                if (foodX == nextX && foodY == nextY)
                {
                    score++;
                    block[foodX, foodY] = true;
                    isFoodExist = false;

                    block[nextX, nextY] = true; 
                }

                currentX = nextX;
                currentY = nextY;

                if (!isFoodExist)
                {
                    int randY = random.Next(2, height - 2); 
                    int randX = random.Next(2, width - 2);

                    if (!block[randX, randY])
                    {
                        isFoodExist = true;
                        foodX = randX;
                        foodY = randY; 
                    }
                }

                // 먹이 그리기 
                Console.SetCursorPosition(foodX, foodY);
                Console.Write("1"); 

                // 플레이어 그리기 
                Console.SetCursorPosition(currentX, currentY); //좌표
                Console.Write("a"); //현재 위치 출력

                Thread.Sleep(100);

            }

        }
    }
}
