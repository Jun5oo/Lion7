using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수 선언 후 값 저장 
            //string greeting;
            //greeting = "Hello World!";

            //Console.WriteLine(greeting);

            // 변수 초기화 
            //int score = 100;
            //double temperature = 36.5;
            //string city = "Seoul";

            // 변수 
            //Console.WriteLine(score); 
            //Console.WriteLine(temperature);
            //Console.WriteLine(city);

            // 방법1: 선언 후 할당 (두 줄) 
            int health;
            health = 100;

            // 방법2: 선언과 동시에 초기화 (한 줄) 
            int maxHealth = 100;
            int damage = 15; 

            // 게임로직 출력 
            Console.WriteLine("체력: " + health + "/" + maxHealth);
            Console.WriteLine($"데미지를 입었습니다. {damage}"); 
        }
    }
}
