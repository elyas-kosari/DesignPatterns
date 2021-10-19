using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Adapter.Gmail
{
    public class GmailClient
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to Gmail");
        }

        public void GetEmails()
        {
            Console.WriteLine("Downloading emails from Gmail");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from Gmail");
        }
    }
}
