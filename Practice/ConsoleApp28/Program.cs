using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {

        //매개변수 int a 대신받아준다.
        static void Attack(ref int a)
        {
            Console.WriteLine("공격력 : " + a);
            a++;

        }

        static void Attack(int a, int d, out int attack, out int defense)
        {
            attack = a;
            defense = d;
            attack++;
            defense++;
        }


        static void Main(string[] args)
        {
            //ref 키워드 참조
            //C# 내부적으로 포인터 개발자들이 신경덜쓰게 잘만들어놓음

            int a = 10;

            Attack(ref a);

            Console.WriteLine("a 값 : " + a);

            int attack;
            int defense;


            Attack(10, 20, out attack, out defense);

            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"공격력 : {defense}");


        }
    }
}
