using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NARAG_FIBONACCI
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c, x, z;

            Console.Write("Amount of numbers to be displayed: ");
            z = Convert.ToInt32(Console.ReadLine());

            for (x = 0; x <= z; x++)
            {
                Console.WriteLine(a);
                c = a + b;
                a = b;
                b =  c;
            }
            Console.ReadKey();
        }
    }
}
