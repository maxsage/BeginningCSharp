                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           using System;

namespace _05_02UsingAnEnumeration
{
    enum Orientation : byte
    {
        North = 1,
        South = 2,
        East = 3,
        West = 4
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            byte directionByte;
            string directionString;
            Orientation myDirection = Orientation.North;
            Console.WriteLine("myDirection = {0}", myDirection);
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            Console.WriteLine("byte equivalent = {0}", directionByte);
            Console.WriteLine("string equivalent = {0}", directionString);
        }
    }
}