﻿using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = " What if I need a \nsnew line? ";
            //string myString = "Go to your c:\\drive ";
            //string myString = @"Go to your c:\\drive ";
            //string myString = String.Format("{1} = {0}", "First", "Second");
            //string myString = String.Format("{0:C}", 123.45);
            //string myString = String.Format("{0:N}", 1234567890);
            //string myString = String.Format("Percentage: {0:P}", 123);
            //string myString = String.Format("Phone Number: {0:(###) ###-####}", 3026706299);

            string myString = " That summer we took threes across the board ";
            myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);
            //myString = String.Format("Length before: {0} -- Length after: {1}", 
            //myString.Length, 
            //myString.Trim().Length);

            /*string mystring = "";
            for (int i = 0; i < 100; i++)
            {
                mystring += "--" + i.ToString();
            }*/





            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
