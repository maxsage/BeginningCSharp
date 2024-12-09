using System.ComponentModel;

namespace _12_03UsingAMultiPurposeEventHandler
{
    public class MessageArrivedEventArgs : CancelEventArgs
    {
        private string message;

        public string Message 
        {
            get
            {
                return message;
            }
        }

        public MessageArrivedEventArgs()
        {
            message = "No message sent.";
        }

        public MessageArrivedEventArgs(string newMessage)
        {
            message = newMessage;
        }
        

    }
}