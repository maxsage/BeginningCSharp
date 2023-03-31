using System;
using System.Threading;

namespace _04_02TheGotoStatement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("GotoExample1");
            Console.WriteLine("============");
            
            GotoExample1();
            
            Console.WriteLine("GotoExample2");
            Console.WriteLine("============");
            GotoExample2();
        }

        private static void GotoExample1()
        {
            int myInteger = 5;
            goto myLabel;
            myInteger += 10;
            myLabel:
            Console.WriteLine("myInteger = {0}", myInteger);
        }

        private static void GotoExample2()
        {
            start:
            int myInteger = 5;
            goto addVal;
            writeResult:
            Console.WriteLine("myInteger = {0}", myInteger);
            goto start;
            addVal:
            myInteger += 10;
            goto writeResult;


        }
    }
}