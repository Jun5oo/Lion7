using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        //static void Attack(string skillName, string target, int damage)
        //{
        //    Console.WriteLine($"스킬 발동: {skillName}");
        //    Console.WriteLine($"{target}에게 {damage} 데미지!");
        //}

        //static void Attack()
        //{
        //    Console.WriteLine($"스킬 발동!");
        //    Console.WriteLine($"적에게 5 데미지!");
        //}

        //static void CastFireBall(string target, int damage = 100, int manCost = 30)
        //{
        //    Console.WriteLine($"파이어볼 시전!");
        //    Console.WriteLine($"대상: {target}");
        //    Console.WriteLine($"데미지: {damage}");
        //    Console.WriteLine($"마나 소모 {manCost}"); 
        //}

        static void UsePotion(string potionType, int healAmount)
        {
            Console.WriteLine($"{potionType} 사용!");
            Console.WriteLine($"회복량: {healAmount} Hp");
        }

        static void SummonMonster(string monsterName, int monsterLevel, int monsterAmount)
        {
            Console.WriteLine($"{monsterName} 소환!");
            Console.WriteLine($"레벨: {monsterLevel}"); 
            Console.WriteLine($"수량: {monsterAmount}");
        }


        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Attack();
            //Console.WriteLine();
            //Attack("찌르기", "적", 5); 

            //CastFireBall("고블린", 150, 40);
            //Console.WriteLine();
            //CastFireBall("오크", 20); 
            //Console.WriteLine();
            //CastFireBall("드래곤"); 
            //Console.WriteLine();녀

            UsePotion("회복 포션", 50);
            UsePotion("고급 회복포션", 100);

            Console.WriteLine();

            SummonMonster("슬라임", 1, 1);
            SummonMonster("고블린", 5, 1);
            SummonMonster("드래곤", 50, 3); 
        }
    }
}
