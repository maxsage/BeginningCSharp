using System;
using System.Diagnostics.CodeAnalysis;

namespace _04_04UsingTheIfStatement
{
    [SuppressMessage("ReSharper", "ConvertIfStatementToConditionalTernaryExpression")]
    internal static class Program
    {
        public static void Main(string[] args)
        {
            string comparison;
            Console.WriteLine("Enter a number:");
            var var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            var var2 = Convert.ToDouble(Console.ReadLine());
            if (var1 < var2)
                comparison = "less than";
            else
            {
                if(var1 == var2)
                    comparison = "equal to";
                else
                    comparison = "greater than";
            }
            
            Console.WriteLine("The first number is {0} the second number.", comparison);
        }
    }
}