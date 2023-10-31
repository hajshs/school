using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRELIMS_NARAG
{
    class Program
    {
        static void Main(string[] args)
        {
            char program;

            Console.Write("Choose a program: ");
            Console.WriteLine("A. Character Checker   B. AED to PHP   C. Number Spelling");
            program = Convert.ToChar(Console.ReadLine());

            if (program == 'A' || program == 'a')
            {
                char input;

                Console.Write("Input: ");
                input = Console.ReadKey().KeyChar;
                Console.Read();

                if (char.IsLetter(input))
                {
                    Console.WriteLine("Input is an alphabet");
                }
                else if (char.IsDigit(input))
                {
                    Console.WriteLine("Input is a digit");
                }
                else
                {
                    Console.WriteLine("Input is a special character");
                }
            }
            else if (program == 'B' || program == 'b')
            {
                double currencyinput, aed, currencyoutput;

                Console.Write("Input AED amount: ");
                currencyinput = double.Parse(Console.ReadLine());
                aed = 15.43;
                currencyoutput = currencyinput * aed;
                Console.WriteLine($"Amount in php: {currencyoutput}");
            }
            else if (program == 'C' || program == 'c')
            {
                int number;

                Console.Write("Number: ");
                number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                    case 10:
                        Console.WriteLine("Ten");
                        break;
                    case 11:
                        Console.WriteLine("Eleven");
                        break;
                    case 12:
                        Console.WriteLine("Twelve");
                        break;
                    case 13:
                        Console.WriteLine("Thirteen");
                        break;
                    case 14:
                        Console.WriteLine("Fourteen");
                        break;
                    case 15:
                        Console.WriteLine("Fifteen");
                        break;
                    case 16:
                        Console.WriteLine("Sixteen");
                        break;
                    case 17:
                        Console.WriteLine("Seventeen");
                        break;
                    case 18:
                        Console.WriteLine("Eighteen");
                        break;
                    case 19:
                        Console.WriteLine("Nineteen");
                        break;
                    case 20:
                        Console.WriteLine("Twenty");
                        break;
                    case 21:
                        Console.WriteLine("Twenty-one");
                        break;
                    case 22:
                        Console.WriteLine("Twenty-two");
                        break;
                    case 23:
                        Console.WriteLine("Twenty-three");
                        break;
                    case 24:
                        Console.WriteLine("Twenty-four");
                        break;
                    case 25:
                        Console.WriteLine("Twenty-five");
                        break;
                    case 26:
                        Console.WriteLine("Twenty-six");
                        break;
                    case 27:
                        Console.WriteLine("Twenty-seven");
                        break;
                    case 28:
                        Console.WriteLine("Twenty-eight");
                        break;
                    case 29:
                        Console.WriteLine("Twenty-nine");
                        break;
                    case 30:
                        Console.WriteLine("Thirty");
                        break;
                    default:
                        Console.WriteLine("Number is out of range");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
            Console.ReadKey();
        }
    }
}
