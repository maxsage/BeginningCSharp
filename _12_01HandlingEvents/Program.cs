using System;
using System.Timers;

namespace _12_01HandlingEvents
{
    internal class Program
    {
        private static int counter = 0;

        private static string displayString = "The string will appear one letter at a time.";
        
        public static void Main(string[] args)
        {
            Timer myTimer = new Timer(100);
            myTimer.Elapsed += new ElapsedEventHandler(WriteChar);
            myTimer.Start();
            Console.ReadLine();
        }

        private static void WriteChar(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(displayString[counter++ % displayString.Length]);
        }
    }
}