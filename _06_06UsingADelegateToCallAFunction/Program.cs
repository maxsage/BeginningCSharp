﻿using System;

namespace _06_06UsingADelegateToCallAFunction
{
    internal class Program
    {
        delegate double processDelegate(double param1, double param2);

        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }

        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }
        
        public static void Main(string[] args)
        {
            processDelegate process;
            Console.WriteLine("Enter 2 numbers separated with comma:");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(',');
            double param1 = Convert.ToDouble(input.Substring(0, commaPos));
            double param2 = Convert.ToDouble(input.Substring(commaPos + 1, 
                input.Length - commaPos - 1));
            
            Console.WriteLine("Enter M to multiply or D to divide");
            input = Console.ReadLine();
            if (input == "M")
                process = new processDelegate(Multiply);
            else
                process = new processDelegate(Divide);
            Console.WriteLine("Result: {0}", process(param1, param2));
        }
    }
}