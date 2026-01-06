using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //문제1 
            int currentHP = 80;
            int maxHP = 100;

            int monsterDamage = 25;
            int hpPotion = 30;
            int poisonDamage = 5;

            Console.WriteLine($"초기체력: {currentHP}/{maxHP}"); 
            currentHP -= monsterDamage;
            Console.WriteLine($"데미지 -25: {currentHP}/{maxHP}");
            currentHP += hpPotion;
            Console.WriteLine($"회복 +30: {currentHP}/{maxHP}");
            currentHP -= poisonDamage;
            Console.WriteLine($"독데미지 -5: {currentHP}/{maxHP}");
            Console.WriteLine();


            //문제2 
            int expPerMonster = 150;
            int monstersKilled = 3;
            int expForLevelUp = 500;

            int currentExp = monstersKilled * expPerMonster; 

            Console.WriteLine($"처치한 몬스터: {monstersKilled}마리");
            Console.WriteLine($"획득 경험치: {currentExp}");
            Console.WriteLine($"레벨업까지 필요: {expForLevelUp - currentExp}");
            Console.WriteLine();


            //문제3 
            int totalGold = 1234;
            int partyMembers = 5;
            Console.WriteLine($"총 골드: {totalGold}");
            Console.WriteLine($"파티원: {partyMembers}명");
            Console.WriteLine($"1인당 골드: {totalGold / partyMembers}");
            Console.WriteLine($"남은 골드: {totalGold % partyMembers}");
            Console.WriteLine();

            //문제4 
            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            int currentHp = 60;
            int maxHp = 100;


            bool levelCondition = playerLevel >= requiredLevel;
            bool keyCondition = hasKey;
            bool hpCondition = (double)currentHp / maxHp >= 0.5;

            Console.WriteLine("=== 던전 입장 조건 ==");
            Console.WriteLine($"레벨 조건 (30 이상): {levelCondition}");
            Console.WriteLine($"열쇠 보유: {keyCondition}");
            Console.WriteLine($"체력 조건 (50% 이상): {hpCondition}");
            Console.WriteLine($"입장 가능: {levelCondition && keyCondition && hpCondition}");
            Console.WriteLine();

            //문제5 
            int originalPrice = 5000;
            bool isVIP = true;
            bool hasCoupon = true;

            // 할인율 계산: 가격 * 0.8
            // 쿠폰 할인: 가격 - 500

            double price = originalPrice; 
            
            Console.WriteLine($"원가: {originalPrice}");
            
            if(isVIP) price *=  0.8;

            Console.WriteLine($"VIP 할인 (20%): {price}");

            if (hasCoupon) price -= 500; 
            Console.WriteLine($"쿠폰 할인 (-500): {price}");

            Console.WriteLine($"최종 가격: {price}"); 
        }
    }
}
