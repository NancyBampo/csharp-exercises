using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach (int num in number)
            {   
                Console.WriteLine("The number is: " + num);
            }
        }
        
    }

}
