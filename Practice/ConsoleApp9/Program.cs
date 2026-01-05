using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1ms 1000 = 1초 
            //Console.Write("안");
            //Thread.Sleep(1000);
            //Console.Write("녕");
            //Thread.Sleep(1000);
            //Console.Write("하");
            //Thread.Sleep(1000);
            //Console.Write("세");
            //Thread.Sleep(1000);
            //Console.Write("요");
            //Thread.Sleep(1000);
            //Console.WriteLine(".");

            int seconds = 10; 

            while(seconds >= 0)
            {
                Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");

                Console.WriteLine($"    {seconds}초 뒤에 게임이 시작됩니다.    ");

                Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

                seconds--; 
                Thread.Sleep(1000);
                Console.Clear(); 
            }

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");

            Console.WriteLine($"       게임이 시작되었습니다.    ");

            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        }
    }
}
