using System;

namespace _03_01UsingSimpleTypeVariables
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "\"myInteger\" is";
            Console.WriteLine("{0} {1}.", myString, myInteger);
        }
    }
}