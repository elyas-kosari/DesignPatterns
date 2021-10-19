using DesignPatterns.CreationalPatterns.Adapter.Gmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Adapter
{
    public class EmailAdaptor : IEmailProvider
    {
        private GmailClient _gmailClient = new GmailClient();

        public void DownloadEmails()
        {
            _gmailClient.Connect();
            _gmailClient.GetEmails();
            _gmailClient.Disconnect();
        }
    }
}
