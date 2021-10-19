using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Adapter
{
    public class EmailClient : IEmailProvider
    {
        private readonly List<IEmailProvider> providers = new List<IEmailProvider>();

        public void AddProvider(IEmailProvider provider)
        {
            providers.Add(provider);
        }

        public void DownloadEmails()
        {
            foreach (var provider in providers)
            {
                provider.DownloadEmails();
            }
        }
    }
}
