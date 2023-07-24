using System;

namespace _05_04UsingAnArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] friendNames = { "Robert Barwell", "Mike Parry", "Jeremy Beacock" };
            int i;
            Console.WriteLine("Here are {0} of my friends",
                friendNames.Length);
            foreach(string friendName in friendNames)
            {
                Console.WriteLine(friendName);
            }
        }
    }
}