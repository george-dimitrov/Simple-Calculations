using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double xSide = Math.Abs(x1 - x2);
            double ySide = Math.Abs(y1 - y2);

            Console.WriteLine(xSide * ySide);
            Console.WriteLine(2 * xSide + 2 * ySide);
        }
    }
}
