using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace Aperture_Social_Communications
{
    class PostTweet
    {
        private string tweet;
        public PostTweet(string tweet)
        {
            this.tweet = tweet;
        }
        public void WriteTweet()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write("Tweet : ");
            tweet = Console.ReadLine();
            if(tweet.Length<=140 && tweet!="asc cancel")
                Tweet.PublishTweet(tweet);
            else
            {
                Console.Write("Previous tweet too long or cancelled!\n");
            }
            Console.ResetColor();
        }
    }
}
