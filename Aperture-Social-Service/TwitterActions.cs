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
        private string user;
        public TwitterActions(string tweet)
        {
            this.tweet = tweet;
        }
        public void WriteTweet()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write("Tweet : ");
            tweet = Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            if (tweet.Length<=140 && tweet!="asc cancel")
                Tweet.PublishTweet(tweet);
            else
            {
                Console.Write("Previous tweet too long or cancelled!\n");
            }
            Console.ResetColor();
        }
        public void BlockUser()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("User : ");
            Console.ResetColor();
            user = Console.ReadLine();
            User.BlockUser(user);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("User {0} has been blocked.", user);
            Console.ResetColor();
        }
        public void UnblockUser()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("User : ");
            Console.ResetColor();
            user = Console.ReadLine();
            User.UnBlockUser(user);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("User {0} has been unblocked.", user);
            Console.ResetColor();
        }
    }
}
