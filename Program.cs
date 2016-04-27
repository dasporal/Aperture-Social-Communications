using System;

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
