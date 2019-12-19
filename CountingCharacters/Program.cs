using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                " Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. " +
                "Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. " +
                "Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";



            string[] paragraph = new string[text.Length];

            /*char[] val = text.ToCharArray();

            for(int i = 0; 1<val.Length; i++)
            {
                
                foreach(char alpha in val)
                {
                    char letter = val[i];

                }
            }*/




            Dictionary<char, int> counts = CountCharacters(text);

            foreach (KeyValuePair<char, int> count in counts)
            {
                Console.WriteLine("{0}:{1}", count.Key, count.Value);
            }
        }

        public static Dictionary<char, int> CountCharacters(string text)
        {
            Dictionary<char, int> textList = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (textList.ContainsKey(c))
                    textList[c]++;
                else
                    textList.Add(c, 1);
            }

            /*           for (int i = 0; i < text.Length; i++)
                        {
                            if (textList.ContainsKey(text[i]))
                                textList[text[i]]++;
                            else
                                textList.Add(text[i],1);

                        }*/

            return textList;
            /*            foreach (KeyValuePair<char, int> count in textList)
                        {
                            return  count.Key, count.Value;
                        }*/


        }
    }
}       
