using System;
using System.Diagnostics;
using Tweetinvi;
using Tweetinvi.Core.Authentication;

namespace Aperture_Social_Service
{
    class Authentication
    {
        ConsumerToken token = new ConsumerToken();
        public ITwitterCredentials Authentify()
        {
            var appCredentials = new TwitterCredentials(token.consumerKey, token.consumerSecret);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("  Please enter the PIN given by Twitter : ");
            Console.ResetColor();
            var authenticationContext = AuthFlow.InitAuthentication(appCredentials);
            Process.Start(authenticationContext.AuthorizationURL);
            var pinCode = Console.ReadLine();
            var userCredentials = AuthFlow.CreateCredentialsFromVerifierCode(pinCode, authenticationContext);
            Auth.SetCredentials(userCredentials);
            return userCredentials;
        }
        public void AdminAuthentify()
        {
            Auth.SetUserCredentials(token.consumerKey, token.consumerSecret, token.accessToken, token.accessSecret);
        }
    }
}
