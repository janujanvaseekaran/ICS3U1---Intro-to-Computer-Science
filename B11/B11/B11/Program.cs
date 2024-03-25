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

            while (age > 0)

            {
                Console.WriteLine("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());




                if (age >= 30)
                {
                    Console.WriteLine("You are old! ");
                    Console.ReadKey();

                    break;
                }

                if (age < 30)
                {
                    Console.WriteLine("You are young!");
                    Console.ReadKey();

                    break;
                }

                   




                }

            }
        }
    }

