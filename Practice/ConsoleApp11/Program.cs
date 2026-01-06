using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //연산자 
            //int a = 5, b = 3;
            //int sum = a + b;
            //bool isEqual = (a == b);

            //Console.WriteLine(sum);
            //Console.WriteLine(isEqual);

            //단항 연산자 
            //int number = 5; 
            //Console.WriteLine(-number);
            //Console.WriteLine(+number);

            //bool flag = true;
            //Console.WriteLine(!flag);

            //int a = 10, b = 3;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            int a = 5;
            int b = 4;
            
            Console.WriteLine(a += b);
            Console.WriteLine(a -= b);
            Console.WriteLine(a *= b);
            Console.WriteLine(a /= b);
            Console.WriteLine(a % b);
        }
    }
}
