using System;

namespace String
{
    class Program
    {
        static void Main()
        {
            string message;
            string searchTerm;
            int indexOfSearchTerm;

            message = "Alice was beginning to get very tired of sitting by her sister on the bank," +
                " and of having nothing to do: once or twice she had peeped into the book her sister was reading," +
                "but it had no pictures or conversations in it, 'and what is the use of a book," +
                "' thought Alice 'without pictures or conversation?'";
            Console.WriteLine(message);
            Console.WriteLine("Enter a string: ");

            searchTerm = Console.ReadLine();
            indexOfSearchTerm = message.IndexOf(searchTerm);
            Console.WriteLine("Index " + indexOfSearchTerm);

            Console.WriteLine("Was term found? " + (indexOfSearchTerm >= 0));



        }

    }

}