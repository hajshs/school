﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULTIPLICATIONTABLE_NARAG
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x = 1;x <= 10; x++)
            {
                for(int y = 1;y <= 10; y++)
                {
                    Console.Write($"\t{x*y}");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
