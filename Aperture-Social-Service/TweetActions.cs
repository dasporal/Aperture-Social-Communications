using System;
using Tweetinvi;

namespace Aperture_Social_Communications
{
    class TwitterActions
    {
        private string tweet;
        private long id;
        public long WriteTweet()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write(" Tweet : ");
            Console.ResetColor();
            tweet = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            if (tweet.Length <= 140 && tweet != "asc cancel") {
                id = Tweet.PublishTweet(tweet).Id;
                Tweet.PublishTweet(tweet);
                Console.ResetColor();
                return id;
            } else {
                Console.Write(" Previous tweet too long or cancelled!\n");
                Console.ResetColor();
                return 0;
            }
            
        }
        public void DeleteTweet() {
            Tweet.DestroyTweet(id);
        }
        
    }
}
