using Aperture_Social_Service;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using Tweetinvi;

namespace Aperture_Social_Communications
{
    class TwitterActions
    {
        private Collection<ATweet> Tweets = new Collection<ATweet>();
        private string content;
        private int id=0;
        private string idD;
        private long idOnline;
        public void WriteTweet()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write(" Tweet : ");
            Console.ResetColor();
            content = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            if (content.Length <= 140 && content != "asc cancel") {
                idOnline = Tweet.PublishTweet(content).Id;
                ATweet theTweet = new ATweet(this.content, this.id, this.idOnline);
                Tweet.PublishTweet(content);
                Tweets.Add(theTweet);
                theTweet.SetID(this.id);
                Console.WriteLine(" Tweet id({0}) : {1}", this.id, theTweet.GetContent());
                this.id++;
            } else {
                Console.Write(" Previous tweet too long or cancelled!\n");
            }
            Console.ResetColor();
        }
        public void DeleteTweet() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" id : ");
            Console.ResetColor();
            id = Convert.ToInt32(Console.ReadLine());
            idD = id.ToString();
            if(idD!="asc cancel")
                Tweet.DestroyTweet(idOnline);
            else
                Console.Write(" Action cancelled!\n");

        }
        
    }
}
