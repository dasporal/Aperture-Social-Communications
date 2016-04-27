using Aperture_Social_Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Tweetinvi;

namespace Aperture_Social_Communications
{
    class TwitterActions
    {
        private Collection<ATweet> Tweets = new Collection<ATweet>();
        private Stack<string> Splits = new Stack<string>();
        private string content;
        private int id=0;
        private string idD;
        private long idOnline;
        private string splitted;
        private bool split;
        public void WriteTweet()
        {
            ATweet theTweet = new ATweet("", 0, 0);
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write(" Tweet : ");
            Console.ResetColor();
            content = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            if (content.Length <= 140 && content != "asc cancel") {
                idOnline = Tweet.PublishTweet(content).Id;
                theTweet.SetContent(content);theTweet.SetID(id);theTweet.SetIDOnline(idOnline);
                Tweet.PublishTweet(content);
                Tweets.Add(theTweet);
                theTweet.SetID(this.id);
                Console.WriteLine(" Tweet id({0}) : {1}", this.id, theTweet.GetContent());
                this.id++;
            } else {
                Console.Write(" Previous tweet too long or cancelled!\n");
                if (content.Length > 140) {
                    Console.Write(" Do you want to split the tweet in multiple tweets ? (true/false) ");
                    split = Convert.ToBoolean(Console.ReadLine());
                    if (split) {
                        theTweet.SetContent(content); theTweet.SetID(id);
                        while (theTweet.GetContent().Length >= 140) {
                            splitted = theTweet.GetContent().Substring(theTweet.GetContent().Length-140, theTweet.GetContent().Length);   // OutOfRangeException need to be figured out
                            Splits.Push(splitted);
                        }
                        foreach(string split in Splits) {
                            Tweet.PublishTweet(split);
                        }
                    }
                }
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
