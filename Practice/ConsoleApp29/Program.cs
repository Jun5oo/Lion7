using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Swap1(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp; 
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Swap1(ref x, ref y);
            Console.WriteLine("x : " + x + " y: " + y);

        }
    }
}
