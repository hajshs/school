using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NARAG_CUBE
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmbr, nmbr2, cube;
            Console.Write("Input number: ");
            nmbr2 = Convert.ToInt32(Console.ReadLine());

            for (nmbr = 1; nmbr <= nmbr2; nmbr++)
            {
                cube = nmbr * nmbr * nmbr;
                Console.WriteLine(cube);
            }
            Console.ReadKey();
        }
    }
}
