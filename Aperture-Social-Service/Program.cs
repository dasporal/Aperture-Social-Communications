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
        static void Main(string[] args)
        {
            Console.Title = "Aperture Social Communications";
            Start title = new Start();
            Command command = new Command();
            Authentication auth = new Authentication();

            title.WriteApp();
            auth.Authentify();
            command.AppCommand();
        }
    }
}
