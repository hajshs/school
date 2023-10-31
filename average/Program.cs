using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NARAG_AVERAGE
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmbr, nmbr2;
            double avg = 0;
            Console.Write("Quantity of numbers to be averaged: ");
            nmbr2 = Convert.ToInt32(Console.ReadLine());

            for (nmbr = 1; nmbr <= nmbr2; nmbr++)
            {
                Console.WriteLine(nmbr);
                avg += nmbr;
            }
            Console.WriteLine($"The average is: {(float)avg / nmbr2}");
            Console.ReadKey();
        }
    }
}