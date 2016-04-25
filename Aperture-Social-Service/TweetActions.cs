using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace Aperture_Social_Communications
{
    class TwitterActions
    {
        private string tweet;

        public void WriteTweet()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write(" Tweet : ");
            Console.ResetColor();
            tweet = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            if (tweet.Length<=140 && tweet!="asc cancel")
                Tweet.PublishTweet(tweet);
                
            else
            {
                Console.Write(" Previous tweet too long or cancelled!\n");
            }
            Console.ResetColor();
        }
        
    }
}
