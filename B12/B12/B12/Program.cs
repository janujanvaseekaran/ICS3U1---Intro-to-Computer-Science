//Janujan Vaseekaran
// ICS3U1 - Into to Computer Science 
// B12 Assignment 
// 2024-03-22
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
            int age = 1;

            while (age > 0) //Here the while loop will continue to run until the user inputs a zero 

            {
                Console.WriteLine("Enter your age: "); //Displays the text on the command prompt
                age = Convert.ToInt32(Console.ReadLine()); //converts the string variable to a interger variable so it can hold the value the user inputs for the variable called age 




                if (age > 29) //this if statement will work if the number inputed by the user is greater than 29
                {
                    Console.WriteLine("You are old! "); //Displays you are old in the command prompt if age is greater than 29
                    Console.ReadKey(); //Runs the code until the user presses enter

                    break; //stops the if statement once it is used
                }

                if (age > 19 && age < 30) //this if statement will work if the number the user inputed is between 19 and 30  
                {
                    Console.WriteLine("You are getting old"); //Displays on the command prompt that you are getting old if the if statement is true 
                    Console.ReadKey(); //runs the cde until the user presses enter

                

                    break; //stops the if statement once it is used
                }


                if (age > 13 && age < 19) //this if statement works 
                {
                    Console.WriteLine("You are a teenager");
                    Console.ReadKey();



                    break;
                }


                if (age < 13 && age > 0)
                {
                    Console.WriteLine("You are a child");
                    Console.ReadKey();



                    break;
                }






            }

        }
    }
}
