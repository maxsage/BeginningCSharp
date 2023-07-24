using System;
using System.Diagnostics.CodeAnalysis;

namespace _05_01TypeConversionsInPractice
{
    [SuppressMessage("ReSharper", "JoinDeclarationAndInitializer")]
    [SuppressMessage("ReSharper", "SuggestVarOrType_BuiltInTypes")]
    [SuppressMessage("ReSharper", "ConvertToConstant.Local")]
    [SuppressMessage("ReSharper", "SpecifyACultureInStringConversionExplicitly")]
    [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
    internal class Program
    {
        public static void Main(string[] args)
        {
            // short	16-bit signed integer	-32,768 to 32,767
            short shortResult; 
            short shortVal = 4;
            
            // int	32-bit signed integer	-2,147,483,648 to 2,147,483,647
            int integerVal = 67;
            
            // long	64-bit signed integer	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long longResult;
            
            // float	32-bit Single-precision floating point type	-3.402823e38 to 3.402823e38
            float floatVal = 10.5F;
            
            // double	64-bit double-precision floating point type	-1.79769313486232e308 to 1.79769313486232e308
            double doubleResult; 
            double doubleVal = 99.999;
            
            string stringVal = "17";
            bool boolVal = true;

            Console.WriteLine("Variable Conversion Examples\n");

            doubleResult = floatVal * shortVal;
            Console.WriteLine("Implicit, -> double: {0} * {1} -> {2}", floatVal, shortVal,  doubleResult);

            shortResult = (short)floatVal;
            Console.WriteLine("Explicit, -> short: {0} -> {1}", floatVal, shortResult);

            string stringResult  = Convert.ToString(boolVal) + Convert.ToString(doubleVal);
            Console.WriteLine("Explicit, -> string: \"{0}\" + \"{1}\" -> {2}", boolVal, doubleVal, stringResult);

            longResult = integerVal + Convert.ToInt64(stringVal);
            Console.WriteLine("Mixed, -> long: {0} + {1} -> {2}", integerVal, stringVal, longResult);



        }
    }
}