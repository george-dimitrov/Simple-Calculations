using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_To_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dolars = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.Round(dolars * 1.79549m, 2)} BGN");
        }
    }
}
