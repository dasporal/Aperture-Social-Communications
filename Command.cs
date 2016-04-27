using Aperture_Social_Service;
using System;

namespace Aperture_Social_Communications {
    class Command {
        private string command;
        private void Auth() {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Authentication auth = new Authentication();
            Console.Write("\n  Please begin the authentication process (asc auth) : ");
            Console.ResetColor();
            command = Console.ReadLine();
            if (command == "asc auth") {
                auth.Authentify();
                //auth.AdminAuthentify();
            } else
                Auth();
            Console.ResetColor();

        }
        private void Instructions() {
            Console.ResetColor();
            Console.Write("\n  Please enter your command (asc help for help) : ");
            command = Console.ReadLine();
        }

        public void AppCommand() {
            Start title = new Start();
            TwitterActions tweet = new TwitterActions();
            DMActions message = new DMActions();
            Users user = new Users();

            Auth();
            Instructions();
            while (command != "asc quit") {
                if (command == "asc tweet") {
                    tweet.WriteTweet();
                } else if (command == "asc block") {
                    user.BlockUser();
                } else if (command == "asc unblock") {
                    user.UnblockUser();
                } else if (command == "asc delete") {
                    tweet.DeleteTweet();
                } else if (command == "asc clear") {
                    Console.Clear();
                    title.WriteApp();
                } else if (command == "asc dm")
                    message.WriteDM();
                else if (command == "help" || command == "asc help") {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
    asc tweet: post a tweet
    asc dm : send a dm
    asc delete: delete previous tweet
    asc [un]block: [un]block user
    asc clear: clear console
    asc quit: close application
    More to come.");
                } else if (command == "asc quit")
                    Environment.Exit(0);
                else {
                    Console.WriteLine("  Use an appropriate command.");
                }
                Instructions();
            }
        }
    }
}
