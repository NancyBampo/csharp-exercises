using System;

namespace Area
{
    class Program
    {
        public static void Main(string[] args)
        {
            float radius;
            do
            {
                Console.WriteLine("Enter a radius greater 0");

                string input = Console.ReadLine();

                radius = float.Parse(input);
            }
            while (radius < 0);
            {
                
                double area = Math.PI * Math.Pow(radius, 2);

                Console.WriteLine("The area of the circle is " + area);
                
            }
        }
    }
}
