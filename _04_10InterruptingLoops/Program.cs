using System;
using System.Configuration;

namespace _04_10InterruptingLoops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TheBreakCommand();

            TheContinueCommand();

            TheGotoCommand();

            TheReturnCommand();
        }

        private static void TheReturnCommand()
        {
            int i = 1;
            while (i <= 10)
            {
                if (i == 6)
                    return;
                Console.WriteLine("{0}", i++);
            }
        }

        private static void TheGotoCommand()
        {
            int i = 1;
            while (i <= 10)
            {
                if (i == 6)
                    goto exitPoint;
                Console.WriteLine("{0}", i++);
            }

            Console.WriteLine("This code will never be reached.");
            exitPoint:
            Console.WriteLine("This code is run when the loop is exited using goto.");
        }

        private static void TheContinueCommand()
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                if ((i % 2) == 0)
                    continue;
                Console.WriteLine(i);
            }
        }

        private static void TheBreakCommand()
        {
            int i = 1;
            while (i <= 10)
            {
                if (i == 6)
                    break;
                Console.WriteLine("{0}", i++);
            }
        }
    }
}