using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string fromCurrency = Console.ReadLine().ToUpper();
            string toCurrency = Console.ReadLine().ToUpper();

            decimal levs = currencyToLevs(fromCurrency, money);
            Console.WriteLine(Math.Round(levsToCurrency(levs, toCurrency), 2) + " " + toCurrency);
        }

        private static decimal currencyToLevs(string currencyName, decimal currencyVal)
        {
            decimal levs = 0;
            switch (currencyName)
            {
                case "BGN": levs = currencyVal; break;
                case "USD": levs = currencyVal * 1.79549m; break;
                case "EUR": levs = currencyVal * 1.95583m; break;
                case "GBP": levs = currencyVal * 2.53405m; break;
            }
            return levs;
        }

        private static decimal levsToCurrency(decimal levs, string toCurrency)
        {
            decimal result = 0;
            switch (toCurrency)
            {
                case "BGN": result = levs; break;
                case "USD": result = levs / 1.79549m; break;
                case "EUR": result = levs / 1.95583m; break;
                case "GBP": result = levs / 2.53405m; break;
            }
            return result;
        }
    }
}
