//Janujan Vaseekaran
// ICS3U1 - Into to Computer Science 
// B9 Assignment 
// 2024-03-18
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1; 
            int counter = 1;

            while (num != 0 && num != 9 && counter <= 25) //the code will continue to run until the user enters a 0,9, or has entered 25 numbers
            {
                Console.WriteLine("Enter Number: ");//prints a place for the user to input the numbers

                num = Convert.ToInt32(Console.ReadLine());//stores the value of the users input as a number and stored in a variable called num

                counter++;//here the variable called counter increases by one, everytime the user inputs a number that does not make the loop stop 
            }
            
            Console.ReadKey();//Allows the code to run until the user presses enter 
        }
    }
}