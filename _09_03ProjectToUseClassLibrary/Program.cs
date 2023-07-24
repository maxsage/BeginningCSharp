using System;
using _09_02UsingAClassLibrary;

namespace _09_03ProjectToUseClassLibrary
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyExternalClass myObj = new MyExternalClass();
            Console.WriteLine(myObj.ToString());
        }
    }
}