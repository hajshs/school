using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRADES_NARAG
{
    class Program
    {
        static void Main(string[] args)
        {
            double prelim, midterm, finalterm, prelimgrade, midtermgrade, finaltermgrade, total;

            Console.Write("Input Prelim Grade: ");
            prelim = double.Parse(Console.ReadLine());
            prelimgrade = prelim * 0.30;
            Console.Write("Inpit Midterm Grade: ");
            midterm = double.Parse(Console.ReadLine());
            midtermgrade = midterm * 0.30;
            Console.Write("Input Final Term Grade: ");
            finalterm = double.Parse(Console.ReadLine());
            finaltermgrade = finalterm * 0.40;
            total = prelimgrade + midtermgrade + finaltermgrade;

            if (total >= 97)
            {
                Console.WriteLine($"Final term grade: {total} is equivalent to 1.00");
            }
            else if (total >= 93)
            {
                Console.WriteLine($"Final term grade: {total} is equivalent to 1.25");
            }
            else if (total >= 89)
            {
                Console.WriteLine($"Final term grade: {total} is equivalent to 1.50");
            }
            else if (total >= 85)
            {
                Console.WriteLine($"Final term grade: {total} is equivalent to 1.75");
            }
            else if (total >= 82)
            {
                Console.WriteLine($"Final term grade: {total} is equivalent to 2.00");
            }
            else if (total >= 79)
            {
                Console.WriteLine($"Final term grade: {total} is equivalent to 2.25");
            }
            else if (total >= 76)
            {
                Console.WriteLine($"Final term grade: {total} is equivalent to 2.50");
            }
            else if (total >= 73)
            {
                Console.WriteLine($"Final term grade: {total} is equivalent to 2.75");
            }
            else if (total >= 70)
            {
                Console.WriteLine($"Final term grade: {total} is equivalent to 3.00");
            }
            else if (total < 70)
            {
                Console.WriteLine($"Final term grade: {total} is equivalent to 5.00");
            }
            Console.ReadKey();
        }
    }
}
