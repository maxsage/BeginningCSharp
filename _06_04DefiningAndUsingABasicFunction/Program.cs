using System;

namespace _06_04DefiningAndUsingABasicFunction
{
    internal static class Program
    {
        private static string myString;
        static void Write()
        {
            string myString = "Strind defined in Write()";
            Console.WriteLine("Now in Write()");
            Console.WriteLine("myString = {0}", myString);
            Console.WriteLine("Global myString = {0}", Program.myString);
        }

        public static void Main(string[] args)
        {
            string myString = "String defined in Main()";
            Program.myString = "Global string";
            Write();
            Console.WriteLine("\nNow in Main()");
            Console.WriteLine("Local myString = {0}", myString);
            Console.WriteLine("Global myString = {0}", Program.myString);
            Console.WriteLine("myString = {0}", myString);
        }
    }
}
