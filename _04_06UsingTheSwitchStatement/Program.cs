﻿using System;
using System.Data;

namespace _04_06UsingTheSwitchStatement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string myName = "karli";
            const string sexyName = "angelina";
            const string sillyName = "ploppy";

            string name;
            
            Console.WriteLine("What is your name?");

            name = Console.ReadLine();

            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the same name as me!");
                    break;
                case sexyName:
                    Console.WriteLine("My, what a sexy name you have!");
                    break;
                case sillyName:
                    Console.WriteLine("That's a very silly name.");
                    break;
            }
            
            Console.WriteLine("Hello {0}!", name);
        }
    }
}