using System;

namespace _12_03UsingAMultiPurposeEventHandler
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Connection myConnection1 = new Connection();
            myConnection1.Name = "First connection.";
            Connection myConnection2 = new Connection();
            myConnection2.Name = "Second connection.";

            Display myDisplay = new Display();

            myConnection1.MessageArrived +=
                new MessageHandler(myDisplay.DisplayMessage);
            myConnection2.MessageArrived +=
                new MessageHandler(myDisplay.DisplayMessage);
            
            myConnection1.Connect();
            myConnection2.Connect();
            Console.ReadLine();
        }
    }
}