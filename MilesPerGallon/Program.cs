using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gallon;
            double mpg;

            Console.WriteLine("How many miles have you driven: ");
            miles = double.Parse(Console.ReadLine());

            Console.WriteLine("How much gas have you used: ");
            gallon = double.Parse(Console.ReadLine());

            mpg = miles / gallon;

            Console.WriteLine("Your miles per gallon is " + mpg);

        }
    }
}
