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

            while (num != 0)
            {
                Console.WriteLine("Enter Number: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
