using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double width;
            double height;
            double area;

            Console.WriteLine("Enter a width: ");
            string width_str = Console.ReadLine();
            width = int.Parse(width_str);
            Console.WriteLine("Enter a height: ");
            height = int.Parse(Console.ReadLine());

            area = height * width;

            Console.WriteLine("The area of the rectangle is " + area);
        }
    }
}
