using System;
using System.Timers;

namespace _12_02DefiningEvents
{
 
    internal class Program
    {
        public static void Main(string[] args)
        {
            Connection myConnection = new Connection();
            Display myDisplay = new Display();
            myConnection.MessageArrived += new MessageHandler(myDisplay.DisplayMessage);
            myConnection.Connect();
            Console.ReadLine();
        }
    }
}