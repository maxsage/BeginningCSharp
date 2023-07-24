using System;

namespace _06_03ExchaningDataWithAFunctionPart2
{
    internal class Program
    {
        static int sumVals(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }

            return sum;
        }
        
        public static void Main(string[] args)
        {
            int sum = sumVals(1, 5, 2, 9, 8);
            Console.WriteLine("Summed Values = {0}", sum);
            
        }
        
        
    }
}