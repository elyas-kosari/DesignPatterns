using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Facade
{
    public class TwitterService
    {
        public void Twitter()
        {
            var oauth = new OAuth();
            var requestToken = oauth.RequestToken("appKey", "secret");
            var accessToken = oauth.GetAccessToken(requestToken);

            var twitterClient = new TwitterClient();
            var tweets = twitterClient.GetRecentTweets(accessToken);

            foreach (var tweet in tweets)
            {
                Console.WriteLine(tweet);
            }
        }
    }
}
