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
            int counter = 0;

            while (num != 0)
            {
                Console.WriteLine("Enter Number: ");
                num = Convert.ToInt32(Console.ReadLine());

                counter++;
            }
            Console.WriteLine("You entered " + counter + " number(s)! ");
            Console.ReadKey();
        }
    }
}
