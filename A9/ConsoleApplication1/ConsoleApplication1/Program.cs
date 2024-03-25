using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = ""; //declares a string variable called firstName
            Console.Write("Please enter your first name: "); //Prompts the user to enter their First name
            firstName = Console.ReadLine(); //gets the fist name entered from the user
            string lastName = ""; //declares a string variable called lastName
            Console.Write("Please enter your last name: "); //Prompts the user to enter their last name 
            lastName = Console.ReadLine(); //gets the last name entered from the user 
            Console.WriteLine("Hello " + firstName + " " + lastName + " How are you doing today? "); //Here a message is printed on the command prompt which indicates the users first name, last name, and grade all inputed information by the user which is presented in a message 
            Console.ReadKey(); //Prevents the console from closing until you press enter 
        }
    }
}
