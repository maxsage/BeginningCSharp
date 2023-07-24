using System;

namespace _06_05CommandLineArguments
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("{0} command line arguments were specified.",
                args.Length);
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}