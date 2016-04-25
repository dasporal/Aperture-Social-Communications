using System;
using Tweetinvi;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aperture_Social_Service {
    class Users {
        private string user;
        public void BlockUser() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" User : ");
            Console.ResetColor();
            user = Console.ReadLine();
            if (user != "asc cancel") {
                User.BlockUser(user);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" User {0} has been blocked.", user);
            } else {
                Console.WriteLine(" Action cancelled.");
                Console.ForegroundColor = ConsoleColor.Red;

            }
            Console.ResetColor();
        }

        public void UnblockUser() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" User : ");
            Console.ResetColor();
            user = Console.ReadLine();
            if (user != "asc cancel") {
                User.UnBlockUser(user);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" User {0} has been unblocked.", user);
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Action cancelled.");
            }
            Console.ResetColor();
        }
    }
}
