using System;

namespace _04_11InfiniteLoops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                if ((i % 9) == 0)
                    continue;
                Console.WriteLine("{0}", i++);
            }
        }
    }
}