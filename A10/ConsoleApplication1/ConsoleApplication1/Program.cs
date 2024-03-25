//Janujan Vaseekaran
// ICS3U1 - Into to Computer Science 
// A10 Assignment 
// 2024-02-17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = ""; //declares a string variable called firstName 
            Console.Write("Please enter your first name: "); //prompts the user to enter their first name 
            firstName = Console.ReadLine(); //gets the first name entered from the user
            string lastName = ""; //declares a string variable called lastName 
            Console.Write("Please enter your last name: "); //prompts the user to enter their last name 
            lastName = Console.ReadLine(); //gets the last name entered from the user 
            int grade = 0; //declares a grade variable and assigns a default value 
            Console.Write("Enter an your Grade: "); //prompts the user to enter their Grade
            grade = Convert.ToInt32(Console.ReadLine()); //gets the grade number from the user
            Console.WriteLine("Hello " + firstName + " " + lastName + " How are you doing today? I hope your doing fine in grade " + grade + " enjoy this year"); //prints the first and last name in a friendly greeting which includes the grade of the student
            Console.ReadKey(); //Prevents the console from closing untill you press enter
        }
    }
}
