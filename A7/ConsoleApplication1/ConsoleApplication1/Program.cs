//Janujan Vaseekaran
// ICS3U1 - Into to Computer Science 
// A7 Assignment 
// 2024-02-17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Janujan"; //Declares a string variable called firstName which contains the value Janujan

            string lastName = "Vaseekaran"; //Declares a string variable called lastName contains the value Vaseekaran
            int grades = 11; //declares a grade variable and assigns 11 as the value 
            Console.WriteLine("Hello " + firstName + " " + lastName + " you are in grade: " + grades); //Here the variables firstName, lastName, and grades are used to print a message in the command prompt

            firstName = "Ayyan"; //Reassigns the original value of the variable firstName to Ayyan
            lastName = "Naqvi"; //Reassigns the original value of the variable lastName to Naqvi

            Console.WriteLine("Hello " + firstName + " " + lastName + " you are in grade: " + grades); // //Here the variables firstName, lastName, and grades are used to print a message in the command prompt

            firstName = "Abdullah"; //Reassigns the value of the variable firstName to Abdullah
            lastName = "Khalid"; //Reassigns the value of the variable lastName to Khalid
            Console.WriteLine("Hello " + firstName + " " + lastName + " you are in grade: " + grades); // //Here the variables firstName, lastName, and grades are used to print a message in the command prompt

            firstName = "Krish"; //Reassigns the value of the variable firstName to Krish
            lastName = "Patel"; //Reassigns the value of the variable lastName to Patel 


            Console.WriteLine("Hello " + firstName + " " + lastName + " you are in grade: " + grades); // //Here the variables firstName, lastName, and grades are used to print a message in the command prompt

            Console.ReadKey(); //Prevents the console from closing until you press enter

        }
    }
}
