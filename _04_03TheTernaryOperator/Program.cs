using System;

namespace _04_03TheTernaryOperator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double number;
            
            Console.WriteLine("Enter a number: ");
            number = Convert.ToDouble(Console.ReadLine());
            
            var resultString = (number < 10) ? "Less than 10" : "Equal to or greater than 10";
            Console.WriteLine(resultString);
        }
    }
}