using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int manaCost = 1; 

            string cardName = "Fire Fly";
            string cardEffect1 = "Battlecry: Add a 1/2";
            string cardEffect2 = "Elemental to your hand";

            int attack = 1;
            int hp = 2; 
            string monsterType = "Elemental"; 


            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃ {manaCost}                     ┃");
            Console.WriteLine($"┃                       ┃");
            Console.WriteLine($"┃                       ┃");
            Console.WriteLine($"┃                       ┃");
            Console.WriteLine($"┃                       ┃");
            Console.WriteLine($"┃                       ┃");
            Console.WriteLine($"┃        {cardName}       ┃");
            Console.WriteLine($"┃                       ┃");
            Console.WriteLine($"┃                       ┃");
            Console.WriteLine($"┃  {cardEffect1} ┃");
            Console.WriteLine($"┃ {cardEffect2}┃");
            Console.WriteLine($"┃                       ┃");
            Console.WriteLine($"┃ {attack}      {monsterType}     {hp}┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
}
