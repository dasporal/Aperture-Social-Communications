using Aperture_Social_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aperture_Social_Communications
{
    class Command
    {
        private string command;
        private void Auth()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Authentication auth = new Authentication();
            Console.Write("\nPlease begin the authentication process (asc auth) : ");
            Console.ResetColor();
            //auth.Authentify();
            Console.ForegroundColor = ConsoleColor.Magenta;
            auth.AdminAuthentify();
            Console.ResetColor();
            command = Console.ReadLine();

        }
        private void Instructions()
        {
            Console.ResetColor();
            Console.Write("\nPlease enter your command (asc help for help) : ");
            command = Console.ReadLine();
        }
        
        public void AppCommand()
        {
            PostTweet tweet = new PostTweet("");
            Start title = new Start();
            Auth();
            Instructions();
            while (command != "asc quit")
            {
                if (command == "asc tweet")
                {
                    tweet.WriteTweet();
                    Instructions();
                }
                else if (command == "asc delete")
                {
                    Instructions();
                }
                else if (command == "asc clear")
                {
                    Console.Clear();
                    title.WriteApp();
                    Instructions();
                }
                else if (command == "help" || command == "asc help")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
asc tweet: post a tweet
asc delete: delete previous tweet /!\ Not functional yet /!\
asc clear: clear console
asc quit: close application
More to come.");
                    Instructions();
                }
                else if (command == "asc quit")
                    Environment.Exit(0);
                else
                {
                    Console.WriteLine("Use an appropriate command.");
                    Instructions();
                }
            }
        }
    }
}
