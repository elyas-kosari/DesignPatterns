using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Facade
{
    public class Demo
    {
        public static void Show()
        {
            var tweeterService = new TwitterService();
            tweeterService.Twitter();
        }
    }
}
