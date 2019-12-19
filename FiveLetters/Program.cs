using System;
using System.Collections.Generic;

namespace FiveLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "color", "word", "lover", "going", "cooks", "cooked", "plan" };
            
            LetterFive(words);
        }

        public static void  LetterFive(List<string> list)
        {
            foreach(string word in list)
            {
                if(word.Length == 5)
                {
                    Console.WriteLine("This is only 5 letters long: " + word);
                }
                    
                   
            }
            
        }
    }
}
