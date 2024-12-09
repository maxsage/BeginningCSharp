using System;
using System.Timers;

namespace _12_02DefiningEvents
{
    public delegate void MessageHandler(string messageText);

    public class Connection
    {
        public event MessageHandler MessageArrived;

        private Timer pollTimer;

        public Connection()
        {
            pollTimer = new Timer(100);
            pollTimer.Elapsed += new ElapsedEventHandler(CheckForMessage);
        }

        private void CheckForMessage(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Checking for new messages.");
            Random random = new Random();
            if ((random.Next(9) == 0) && (MessageArrived != null))
            {
                MessageArrived("Hello Mum");
            }
        }

        public void Connect()
        {
            pollTimer.Start();
        }

        public void Disconnect()
        {
            pollTimer.Stop();
        }
        
        
    }
}