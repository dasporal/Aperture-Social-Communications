using System;
using Tweetinvi;

namespace Aperture_Social_Service {
    class DMActions {
        private string message;
        private string user;
        public void WriteDM() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" User : ");
            Console.ResetColor();
            user = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            if (user != "asc cancel") {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" Tweet : ");
                Console.ResetColor();
                message = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (message != "asc cancel")
                    Message.PublishMessage(message, user);
                else
                    Console.Write(" Message cancelled!\n");
            } else
                Console.Write(" Message cancelled!\n");
            Console.ResetColor();
        }
    }
}
