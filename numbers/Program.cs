using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBERS_NARAG
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15];
            int[] odd = new int[15];
            int[] even = new int[15];

            int x;

            for (x = 0; x < 15; x++)
            {
                Console.Write($"Input number {x + 1}: ");
                numbers[x] = Int32.Parse(Console.ReadLine());

                if (numbers[x] % 2 == 0)
                {
                    even[x] = numbers[x];
                }
                else
                {
                    odd[x] = numbers[x];
                }
            }

            Console.WriteLine("\nEven Numbers: ");
            foreach (int evn in even)
            {
                if (evn != 0)
                {
                    Console.WriteLine($"{evn}");
                }
            }

            Console.WriteLine("\nOdd Numbers: ");
            foreach (int od in odd)
            {
                if (od != 0)
                {
                    Console.WriteLine($"{od}");
                }
            }
            Console.ReadKey();
        }
    }
}
