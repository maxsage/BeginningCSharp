using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace _04_00Scratch01
{
    [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Boolean Logic");
            Console.WriteLine("As an historical aside, it is worth remembering (and respecting) the English\n" +
                              "mathematician George Boole, whose work in the mid nineteenth century forms the\n" +
                              "basis of Boolean logic.\n");
            
            Console.WriteLine("Boolean Comparison Operators");
            Console.WriteLine("============================");
            
            /*
            BooleanComparisonOperators();
            
            LogicalNot();
            LogicalAnd();
            LogicalOr();
            LogicalXOr(); 
            */

            BitwiseOperators();
        }
        
        private static void BooleanComparisonOperators()
        {
            bool var1; 
            var var2 = 10;
            var var3 = 12;

            var1 = var2 == var3;
            Console.WriteLine("var1 = {0} == {1}", var2, var3);
            Console.WriteLine("var1 = {0}\n", var1);
            
            var1 = var2 != var3;
            Console.WriteLine("var1 = {0} != {1}", var2, var3);
            Console.WriteLine("var1 = {0}\n", var1);
            
            var1 = var2 < var3;
            Console.WriteLine("var1 = {0} < {1}", var2, var3);
            Console.WriteLine("var1 = {0}\n", var1);
            
            var1 = var2 > var3;
            Console.WriteLine("var1 = {0} > {1}", var2, var3);
            Console.WriteLine("var1 = {0}\n", var1);
            
            var1 = var2 <= var3;
            Console.WriteLine("var1 = {0} <= {1}", var2, var3);
            Console.WriteLine("var1 = {0}\n", var1);
            
            var1 = var2 >= var3;
            Console.WriteLine("{0} = {1} >= {2}", var1, var2, var3);
            Console.WriteLine("var1 = {0}\n", var1);
        }
        
        private static void LogicalNot()
        {
            Console.WriteLine("! Logical NOT");
            Console.WriteLine("=============");

            var dayOfWeek = DateTime.Today.DayOfWeek;
            Console.WriteLine("dayOfWeek = {0}\n", dayOfWeek.ToString());
            
            var var2 = DayOfWeek.Monday == dayOfWeek;
            Console.WriteLine("var2 = DayOfWeek.Monday == {0}", dayOfWeek.ToString());
            Console.WriteLine("var2 = {0}\n", var2);
            
            var var1 = !var2;
            Console.WriteLine("var1 = !var2;");
            Console.WriteLine("var1 = {0}\n", var1);
        }

        private static void LogicalAnd()
        {
            Console.WriteLine("&, && Logical AND");
            Console.WriteLine("=================");

            var var1 = true;
            Console.WriteLine("var1 = {0}\n", var1);
            
            var var2 = true;
            Console.WriteLine("var2 = {0}\n", var2);
            
            var var3 = var1 & var2;
            Console.WriteLine("var3 = var1 & var2;");
            Console.WriteLine("var3 = {0}\n", var3);
        }
        
        private static void LogicalOr()
        {
            Console.WriteLine("|, || Logical Or");
            Console.WriteLine("================");

            var var1 = true;
            Console.WriteLine("var1 = {0}\n", var1);

            var var2 = false;
            Console.WriteLine("var2 = {0}\n", var2);
            
            var var3 = var1 | var2;
            Console.WriteLine("var3 = var1 | var2;");
            Console.WriteLine("var3 = {0}\n", var3);
        }
        
        private static void LogicalXOr()
        {
            Console.WriteLine("^ Logical XOr");
            Console.WriteLine("=============");

            var var1 = true;
            Console.WriteLine("var1 = {0}\n", var1);

            var var2 = true;
            Console.WriteLine("var2 = {0}\n", var2);
            
            var var3 = var1 ^ var2;
            Console.WriteLine("var3 = var1 ^ var2;");
            Console.WriteLine("var3 = {0}\n", var3);
        }

        private static void BitwiseOperators()
        {
            int op1 =4, op2 = 5; 

            Console.WriteLine("Bitwise Operators");
            Console.WriteLine("=================");
            
            Console.WriteLine("{0} & {1} = {2}", op1, op2, op1 & op2);
            Console.WriteLine("{0} | {1} = {2}", op1, op2, op1 | op2);
            Console.WriteLine("{0} ^ {1} = {2}", op1, op2, op1 ^ op2);
            Console.WriteLine("~{0} = {1}", op1, ~op1);
            Console.WriteLine("{0} << {1} = {2}", 10, 2, 10 << 2);
            Console.WriteLine("{0} >> {1} = {2}", 10, 2, 10 >> 2);
            
            Console.WriteLine();

            Console.WriteLine("{0} & {1} = {2}", Convert.ToString(op1, 2), 
                Convert.ToString(op2, 2),
                Convert.ToString(op1 & op2, 2));
            
            Console.WriteLine("{0} | {1} = {2}", Convert.ToString(op1, 2), 
                Convert.ToString(op2, 2),
                Convert.ToString(op1 | op2, 2));
            
            Console.WriteLine("{0} ^ {1} = {2}", Convert.ToString(op1, 2), 
                Convert.ToString(op2, 2),
                Convert.ToString(op1 ^ op2, 2));
            
            Console.WriteLine("~{0} = {1}", Convert.ToString(op1, 2), 
                Convert.ToString(~op1, 2));

            Console.WriteLine("{0} << {1} = {2}", Convert.ToString(10, 2),
                Convert.ToString(2, 2),
                Convert.ToString(10 << 2, 2));
            
            Console.WriteLine("{0} >> {1} = {2}", Convert.ToString(10, 2),
                Convert.ToString(2, 2),
                Convert.ToString(10 >> 2, 2));

            
        }
    }
}