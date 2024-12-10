using System;

namespace _12_03UsingAMultiPurposeEventHandler
{
    public class Display
    {
        public void DisplayMessage(Connection source, MessageArrivedEventArgs e)
        {
            Console.WriteLine("Message arrived from: {0}", source.Name);
            Console.WriteLine("Message Text: {0}", e.Message);
        }
    }
}