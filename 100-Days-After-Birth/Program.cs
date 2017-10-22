using System;
using System.Globalization;

namespace _100_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthDay = Console.ReadLine();
            DateTime dt = DateTime.ParseExact(birthDay, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dt.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}
