//Janujan Vaseekaran
// ICS3U1 - Into to Computer Science 
// B5 Assignment 
// 2024-03-04
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Degrees C       |       Degrees F");
            Console.WriteLine(" ----------------------------");

            for (int i = 0; i < 100; i = i + 5) 
            {
                double degreesC;
                double degreesF;
                degreesC = i;
                degreesF = ((degreesC * 1.8) + 32);
                Console.WriteLine("  " + i + "              | " + "       " + degreesF);
               
            }
            Console.ReadKey(); 
        }
    }
}
