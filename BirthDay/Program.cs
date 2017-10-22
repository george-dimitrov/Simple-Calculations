using System;

namespace BirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percents = double.Parse(Console.ReadLine()) * 0.01;
            double quontity = length * width * height * 0.001;

            Console.WriteLine($"{quontity * ( 1 - percents):f3}");
        }
    }
}
