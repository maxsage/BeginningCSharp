using System;
using System.CodeDom;
using Microsoft.Win32.SafeHandles;

namespace _07_02WritingTextToTheOutputWindow
{
    internal class Program
    {
        private static string[] eTypes = { "none", "simple", "index", "nested index" };
        
        public static void Main(string[] args)
        {
            foreach (string eType in eTypes)
            {
                try
                {
                    Console.WriteLine("Main() try block reached.");                     // Line 18
                    Console.WriteLine("ThrowException(\"{0}\") called.", eType);      // Line 19

                    ThrowException(eType);
                    Console.WriteLine("Main() try block continues.");                   // Line 21
                }
                catch (System.IndexOutOfRangeException e)
                {
                    Console.WriteLine("Main() System.IndexOutOfRangeException catch"
                                      + " block reached. Message:\n\"{0}\"",
                        e.Message);
                }
                catch
                {
                    Console.WriteLine("Main() general catch block reached.");
                }
                finally
                {
                    Console.WriteLine("Main() finally block reached.");
                }
                Console.WriteLine();
            }
        }

        static void ThrowException(string exceptionType)
        {
            Console.WriteLine("ThrowException(\"{0}\") reached.", exceptionType);          // Line 43
            switch (exceptionType)
            {
                case "none":
                    Console.WriteLine("Not throwing an exception");
                    break;
                case "simple":
                    Console.WriteLine("Throwing System.Exception.");                        // Line 51
                    throw (new System.Exception());
                    break;
                case "index":
                    Console.WriteLine("Throwing System.IndexOutOfRangeException.");         // Line 55
                    eTypes[4] = "error";
                    break;
                case "nested index":
                    try                                                                     // Line 58
                    {
                        Console.WriteLine("ThrowException(\"nested index\") " +
                                          "try block reached.");
                        Console.WriteLine("ThrowException(\"index \") called. ");
                        ThrowException("index");                                            // Line 63
                    }
                    catch                                                                   // Line 65
                    {
                        Console.WriteLine("ThrowException(\"nested index\") general"
                                          + " catch block reached.");
                    }
                    finally
                    {
                        Console.WriteLine("ThrowException(\"nested index\") finally"
                                          + " block reached.");
                    }

                    break;
            }
        }
    }
}