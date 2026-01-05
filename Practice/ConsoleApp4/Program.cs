using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 1, y = 2, z = 3;

            //Console.WriteLine("{0}, {1}, {2}", x, y, z); 
            //Console.WriteLine($"{x}, {y}, {z}");

            int posX = 0, posY = 50, posZ = 100;
            Console.WriteLine("X: {0}, Y: {1}, Z: {2}", posX, posY, posZ);
            Console.WriteLine($"X: {posX}, Y: {posY}, Z: {posZ}");
            Console.WriteLine("X: " + posX + ", Y: " + posY + ", Z: " + posZ); 

            int red = 255, green = 128, blue = 0; 

        }
    }
}
