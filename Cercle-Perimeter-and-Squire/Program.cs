﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cercle_Perimeter_and_Squire
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + (Math.PI * r * r));
            Console.WriteLine("Perimeter = " + (2 * Math.PI * r));
        }
    }
}
