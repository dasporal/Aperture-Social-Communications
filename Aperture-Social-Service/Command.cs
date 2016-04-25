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
            command = Console.ReadLine();
            if (command == "asc auth")
            {
                //auth.Authentify();
                auth.AdminAuthentify();
            }
            else
                Auth();
            Console.ResetColor();

        }
        private void Instructions()
        {
            Console.ResetColor();
            Console.Write("\nPlease enter your command (asc help for help) : ");
            command = Console.ReadLine();
        }
        
        public void AppCommand()
        {
            TwitterActions tweet = new TwitterActions("");
            Start title = new Start();

            Auth();
            Instructions();
            while (command != "asc quit")
            {
                if (command == "asc tweet")
                {
                    tweet.WriteTweet();
                }
                else if (command == "asc block")
                {
                    tweet.BlockUser();
                }
                else if (command == "asc unblock")
                {
                    tweet.UnblockUser();
                }
                else if (command == "asc delete")
                {
                    Console.WriteLine("One day");
                }
                else if (command == "asc clear")
                {
                    Console.Clear();
                    title.WriteApp();
                }
                else if (command == "help" || command == "asc help")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
asc tweet: post a tweet
asc delete: delete previous tweet /!\ Not functional yet /!\
asc [un]block: [un]block user
asc clear: clear console
asc quit: close application
More to come.");
                }
                else if (command == "asc quit")
                    Environment.Exit(0);
                else
                {
                    Console.WriteLine("Use an appropriate command.");
                }
                Instructions();
            }
        }
    }
}
