using DesignPatterns.CreationalPatterns.Adapter.Gmail;

namespace DesignPatterns.CreationalPatterns.Adapter
{
    public class Demo
    {
        public static void Show()
        {
            var emailClient = new EmailClient();
            emailClient.AddProvider(new EmailAdaptor());
            emailClient.DownloadEmails();
        }
    }
}
