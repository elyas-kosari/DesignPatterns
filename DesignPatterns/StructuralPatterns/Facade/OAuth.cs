using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Facade
{
    public class OAuth
    {
        public string RequestToken(string appKey, string appSecret)
        {
            Console.WriteLine("Get a request token");
            return "requestToken";
        }

        public string GetAccessToken(string requestToken)
        {
            Console.WriteLine("Get an access token");
            return "accessToken";
        }
    }
}
