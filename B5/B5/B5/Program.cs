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
            for (int i = 0; i < 10; ++i) //outer loop 
            {
                for (int j = 10; j > i; --j) //inner loop
                {

                    Console.Write(" "); //prints the spaces before the asterick in the command prompt

                }
                Console.WriteLine(" *"); //prints the asterik 
            }
            Console.ReadKey(); //prevents program from closing until user presses enter 
        }
    }
}