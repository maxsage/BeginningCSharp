using System;

namespace _05_05StatementAutoCompletionInVS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string myString = "This is a test.";
            char[] separator = { ' ' };
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                Console.WriteLine("{0}", word);
            }
        }
    }
}