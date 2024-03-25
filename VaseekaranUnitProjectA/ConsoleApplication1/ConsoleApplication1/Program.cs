//Janujan Vaseekaran
// ICS3U1 - Into to Computer Science 
// Unit A Project 
// 2024-03-01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of toonies: "); //Displays message on command prompt for the user to answer
            int toonies = Convert.ToInt32(Console.ReadLine()); //Allows the user to input a value for the message displayed previously and converts that value into a integer and stores in a variable called toonies
            Console.Write("Enter the number of loonies: "); //Displays message on command prompt for the user to answer
            int loonies = Convert.ToInt32(Console.ReadLine());//Allows the user to input a value for the message displayed previously and converts that value into a integer and stores in a variable called loonies
            Console.Write("Enter the number of quaters: ");//Displays message on command prompt for the user to answer
            int quarters = Convert.ToInt32(Console.ReadLine());//Allows the user to input a value for the message displayed previously and converts that value into a integer and stores in a variable called quarters
            Console.Write("Enter the number of dimes: ");//Displays message on command prompt for the user to answer
            int dimes = Convert.ToInt32(Console.ReadLine());//Allows the user to input a value for the message displayed previously and converts that value into a integer and stores in a variable called dimes
            Console.Write("Enter the number of nickels: ");//Displays message on command prompt for the user to answer
            int nickels = Convert.ToInt32(Console.ReadLine());//Allows the user to input a value for the message displayed previously and converts that value into a integer and stores in a variable called nickels
            Console.Write("Enter the number of pennies: ");//Displays message on command prompt for the user to answer
            int pennies = Convert.ToInt32(Console.ReadLine());//Allows the user to input a value for the message displayed previously and converts that value into a integer and stores in a variable called pennies








            Console.WriteLine("You Entered: "); //Displays text saying "You Entered: "
            Console.WriteLine("Toonies: " + toonies);//Displays the number of toonies entered by the user 
            Console.WriteLine("Loonies: " + loonies);//Displays the number of loonies entered by the user 
            Console.WriteLine("Quaters: " + quarters);//Displays the number of quaters entered by the user
            Console.WriteLine("Dimes: " + dimes);//Displays the number of dimes entered by the user
            Console.WriteLine("Nickels: " + nickels); //Displays the number of nickels entered by the user
            Console.WriteLine("Pennies: " + pennies); //Displays the number of pennies entered by the user 


            int totalCoins = (toonies + loonies + quarters + dimes + nickels + pennies);//Caculates the amount of coins the user inputted by adding all the variables with the stored values of the number of coins the user inputted for each coin type
            int totalPennies = (toonies * 200) + (loonies * 100) + (quarters * 25) + (dimes * 10) + (nickels * 5) + (pennies * 1);//Caculates the total value of the coins in pennies by multiply toonies by 200, loonies by 100, quaters by 25, dimes by 10, nickels by 5, and pennies by 1 to get the value of the coins in pennies then add all the values to get the total value in pennies
            Console.WriteLine("The value of your " + totalCoins + " coins is equivalent to " + totalPennies + " pennies ");//Displays the total value and total amount of coins on the command prompt
            Console.ReadKey();//Prevents console from closing untill user presses enter 





        }
    }
}
