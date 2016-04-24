using System;
using System.Diagnostics;
using Tweetinvi;
using Tweetinvi.Core.Authentication;

namespace Aperture_Social_Service
{
    class Authentication
    {
        public void Authentify()
        {
            ConsumerToken token = new ConsumerToken();
            var appCredentials = new TwitterCredentials(token.consumerKey, token.consumerSecret);
            Console.Write("Please enter the PIN given by Twitter : ");
            var authenticationContext = AuthFlow.InitAuthentication(appCredentials);
            Process.Start(authenticationContext.AuthorizationURL);
            var pinCode = Console.ReadLine();
            var userCredentials = AuthFlow.CreateCredentialsFromVerifierCode(pinCode, authenticationContext);
            Auth.SetCredentials(userCredentials);
        }
    }
}
