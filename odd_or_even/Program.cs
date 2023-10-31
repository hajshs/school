using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven_NARAG
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNput, num;

            Console.Write("Input Number: ");
            iNput = int.Parse(Console.ReadLine());
            num = iNput % 2;

            if (num%2 == 0)
            {
                Console.Write("Number is even");
            }
            else
            {
                Console.Write("Number is odd");
            }
            Console.ReadKey();
        }
    }
}
