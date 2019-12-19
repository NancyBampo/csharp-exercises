using System;
using System.Collections.Generic;

namespace SumEven
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 5, 2, 7, 4, 12, 23, 46, 11, 10 };
            int sum = EvenNums(nums);
            Console.WriteLine("The sum of all the even numbers are: " + sum);

            
            
        }

        public static int EvenNums(List<int> list)
        {
            int sum = 0;
            foreach(int num in list)
            {
                if(num % 2 == 0)
                
                sum += num;
                
                
            }
            return sum;
        }
    }
}
