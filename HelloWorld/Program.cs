using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a width:");

            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a height:");
            int height = int.Parse(Console.ReadLine());

            int area = width * height;

            Console.WriteLine("The area of the rectangle was " + area);
        }
    }
}
