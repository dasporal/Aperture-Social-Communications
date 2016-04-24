using Aperture_Social_Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Core;
using Tweetinvi.Core.Authentication;

namespace Aperture_Social_Communications
{
    class Program
    {
        public static string userScreenName;
        static void Main(string[] args)
        {
            
            Console.Title = "Aperture Social Communications";
            Start title = new Start();
            Command command = new Command();
            ConsumerToken token = new ConsumerToken();
            
            title.WriteApp();
            var appCredentials = new TwitterCredentials(token.consumerKey,token.consumerSecret);
            Console.Write("Please enter the PIN given by Twitter : ");
            var authenticationContext = AuthFlow.InitAuthentication(appCredentials);
            Process.Start(authenticationContext.AuthorizationURL);
            var pinCode = Console.ReadLine();
            var userCredentials = AuthFlow.CreateCredentialsFromVerifierCode(pinCode, authenticationContext);
            Auth.SetCredentials(userCredentials);
            command.AppCommand();

        }
    }
}
