using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aperture_Social_Communications
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aperture Social Communications";
            Start title = new Start();
            Command command = new Command();

            title.WriteApp();
            command.AppCommand();
        }
    }
}
