using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMES_NARAG
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            int x;

            for (x = 0; x < 10; x++)
            {
                Console.Write($"Input name {x + 1}: ");
                names[x] = Console.ReadLine();

            }

            Console.WriteLine("\nNames: ");
            for (x = 9; x >= 0; x--)
            {
                Console.WriteLine(names[x]);
            }
            Console.ReadKey();
        }
    }
}