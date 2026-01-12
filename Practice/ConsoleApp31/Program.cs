using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static double CalculateAverage(int[] arr)
        {
            int sum = 0;
            double avg = 0; 

            foreach(var num in arr)
                sum += num;

            avg = (double)sum / arr.Length;

            return avg; 
        }

        static string GetGrade(int score)
        {
            if (score >= 90)
                return "A";
            else if (score >= 80)
                return "B";
            else if (score >= 60)
                return "C";
            else
                return "D"; 
        }   

        static bool isPrimary(int a)
        {
            for(int i=2; i<a; i++)
            {
                if (a % i == 0)
                    return false; 
            }

            return true; 
        }

        static bool CanLevelUp(int currentExp, int getExp, out int newExp, int maxExp = 20)
        {
            newExp = currentExp + getExp; 

            if(currentExp + getExp >= maxExp)
            {
                newExp = (currentExp + getExp) % maxExp;
                return true; 
            }

            return false; 
        }

        static bool Enchant(int enchantLevel)
        {
            Random random = new Random();
            int rand = random.Next(1, 101);

            if (rand > enchantLevel * 10)
                return false;
            else
                return true; 
        }

        static void Main(string[] args)
        {
            #region 문제1
            Console.WriteLine("문제1: 평균 계산함수");

            double avg = CalculateAverage(new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}); 
            Console.WriteLine($"평균: {avg:N1}");

            Console.WriteLine();
            #endregion

            #region 문제2
            Console.WriteLine("문제2: 등급 판별함수");
            int score = 89; 
            string grade = GetGrade(score);
            Console.WriteLine($"점수: {score}, 등급: {grade}");

            Console.WriteLine();
            #endregion

            #region 문제3
            Console.WriteLine("문제3: 소수 판별함수");
            
            int a = 17;
            int b = 6;
            int c = 211;

            bool isAPrimary = isPrimary(a); 
            bool isBPrimary = isPrimary(b);
            bool isCPrimary = isPrimary(c);

            Console.WriteLine($"{a}: {isAPrimary}");
            Console.WriteLine($"{b}: {isBPrimary}");
            Console.WriteLine($"{c}: {isCPrimary}");

            Console.WriteLine();

            #endregion

            #region 문제4 
            Console.WriteLine("경험치 시스템");

            int currentExp = 10;
            int getExp = 11;

            Console.WriteLine($"현재 경험치: {currentExp}");
            Console.WriteLine($"새로 획득한 경험치: {currentExp}");

            if (CanLevelUp(currentExp, getExp, out int newExp))
                Console.WriteLine("레벨업!");

            Console.WriteLine($"현재 경험치: {newExp}");

            Console.WriteLine();
            #endregion 

            Console.WriteLine("아이템 강화 시스템");

            int enchantLevel0 = 1; 
            int enchantLevel1 = 5;
            int enchantLevel2 = 7;
            int enchantLevel3 = 9;

            Console.WriteLine($"레벨: {enchantLevel0}");
            Console.WriteLine($"인첸트 성공여부: {Enchant(enchantLevel0)}");
            Console.WriteLine($"레벨: {enchantLevel1}");
            Console.WriteLine($"인첸트 성공여부: {Enchant(enchantLevel1)}");
            Console.WriteLine($"레벨: {enchantLevel2}");
            Console.WriteLine($"인첸트 성공여부: {Enchant(enchantLevel2)}");
            Console.WriteLine($"레벨: {enchantLevel3}");
            Console.WriteLine($"인첸트 성공여부: {Enchant(enchantLevel3)}");

        }
    }
}
