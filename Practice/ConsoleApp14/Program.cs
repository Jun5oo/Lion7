using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 20;
            //int max = (a > b) ? a : b;
            //Console.WriteLine(max);

            //int score = 85;
            //string result = (score >= 60) ? "합격" : "불합격";

            //Console.WriteLine("=== 시험 결과 ===");
            //Console.WriteLine($"점수: {score}");
            //Console.WriteLine($"결과: {result}");

            //예제2: 레벨에 따른 등급 
            //레벨 45 
            //50보다 크면 고급, 30~50 사이면 중급, 그렇지 않으면 초급 

            //int level = 45;
            //string grade;

            //grade = level > 50 ? "고급" : (level < 30 ? "초급" : "중급");


            //Console.WriteLine("플레이어 등급");
            //Console.WriteLine($"레벨: {level}");
            //Console.WriteLine($"등급: {grade}");

            //int health = 30;
            //int maxHealth = 100;

            //string safetyLevel = (double)health / maxHealth >= 0.7 ? "안전" :
            //                   (double)health / maxHealth >= 0.3 ? "주의" : "위험";

            //Console.WriteLine(safetyLevel);

            // 예제 2: 데미지 계산
            int baseDamage = 50;
            int bonusDamage = 20;
            double criticalMultiplier = 1.5;

            // 잘못된 계산
            double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            // 올바른 계산
            double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            Console.WriteLine($"기본 데미지: {baseDamage}");
            Console.WriteLine($"보너스 데미지: {bonusDamage}");
            Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            Console.WriteLine($"올바른 계산: {damage2}");  // 105.0

        }
    }
}
