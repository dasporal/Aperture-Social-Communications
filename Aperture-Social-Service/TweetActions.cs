using Aperture_Social_Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Tweetinvi;

namespace Aperture_Social_Communications
{
    class TwitterActions
    {
        private Collection<ATweet> Tweets = new Collection<ATweet>();
        private List<string> Splits = new List<string>();
        ATweet theTweet = new ATweet("", 0, 0);
        private string content;
        private int id = 0;
        private int index;
        private int index2;
        private string idD;
        private long idOnline;
        private string splitted;
        private bool split;

        public void WriteTweet() {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write(" Tweet : ");
            Console.ResetColor();
            content = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            if (content.Length <= 140 && content != "asc cancel") {
                idOnline = Tweet.PublishTweet(content).Id;
                theTweet.SetContent(content);theTweet.SetID(id);theTweet.SetIDOnline(idOnline);       // the instancied tweet get all of its needed "proper" values
                Tweet.PublishTweet(content);
                Tweets.Add(theTweet);
                theTweet.SetID(this.id);
                Console.WriteLine(" Tweet id({0}) : {1}", this.id, theTweet.GetContent());
                this.id++;
            } else {
                Console.Write(" Previous tweet too long or cancelled!\n");
                if (content.Length > 140) {
                    StackTweets(theTweet);
                }
            }
            Console.ResetColor();
        }
		
	public void StackTweets(ATweet tweet) {
            Console.Write(" Do you want to split the tweet in multiple tweets ? (true/false) ");
            split = Convert.ToBoolean(Console.ReadLine());
			
		if(split) {
			theTweet.SetContent(content);
			String text = tweet.GetContent();
			for(int i = 0; i < Math.Ceiling(text.Length/140.0); i++) {
				int index1 = 140*i;
				int index2 = (text.Length > 140*(i+1)) ? 140 : text.Length-index1; //condition to avoid OutOfRange error, text lenght is not necessary a modulo of 140
				Tweet.PublishTweet(text.Substring(index1, index2);
			}
		} else {
			//TODO: user doesn't want to split the tweet
		}
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
