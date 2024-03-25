using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName; //declares a string variable called firstName
            string lastName; //declares a string variable called lastName 
            firstName = "Janujan"; //String variable called firstName is given the value Janujan
            lastName = "Vaseekaran"; //String variable called lastName is given the value Vaseekaran
            int grades = 11; //declares a variable called grades and gives a value of 11
            Console.WriteLine("Hello " + firstName + " " + lastName + " you are in grade: " + grades); //Here the variables firstName, lastName, and grades are used to print a message in the command prompt
            Console.ReadKey();//Prevents the console from closing until you press enter

        }
    }
}
