using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aperture_Social_Communications
{
    class Start
    {
        public void WriteApp()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            try {
                Console.SetWindowSize(210, 40);
                Console.WriteLine(@"
                  .,-:;//;:=,
              . :H@@@MM@M#H/.,+%;,
           ,/X+ +M@@M@MM%=,-%HMMM@X/,
         -+@MM; $M@@MH+-,;XMMMM@MMMM@+-
        ;@M@@M- XM@X;. -+XXXXXHHH@M@M#@/.
      ,%MM@@MH ,@%=             .---=-=:=,.         _                   _                    __      _                         ___                                      _           _   _                 
      =@#@@@MX.,                -%HX$$%%%:;        /_\  _ __   ___ _ __| |_ _   _ _ __ ___  / _\ ___(_) ___ _ __   ___ ___    / __\___  _ __ ___  _ __ ___  _   _ _ __ (_) ___ __ _| |_(_) ___  _ __  ___ 
     =-./@M@M$                   .;@MMMM@MM:      //_\\| '_ \ / _ \ '__| __| | | | '__/ _ \ \ \ / __| |/ _ \ '_ \ / __/ _ \  / /  / _ \| '_ ` _ \| '_ ` _ \| | | | '_ \| |/ __/ _` | __| |/ _ \| '_ \/ __|
     X@/ -$MM/                    . +MM@@@M$     /  _  \ |_) |  __/ |  | |_| |_| | | |  __/ _\ \ (__| |  __/ | | | (_|  __/ / /__| (_) | | | | | | | | | | | |_| | | | | | (_| (_| | |_| | (_) | | | \__ \
    ,@M@H: :@:                    . =X#@@@@-     \_/ \_/ .__/ \___|_|   \__|\__,_|_|  \___| \__/\___|_|\___|_| |_|\___\___| \____/\___/|_| |_| |_|_| |_| |_|\__,_|_| |_|_|\___\__,_|\__|_|\___/|_| |_|___/
    ,@@@MMX, .                    /H- ;@M@M=           |_|     
    .H@@@@M@+,                    %MM+..%#$.
     /MMMM@MMH/.                  XM@MH; =;
      /%+%$XHH@$=              , .H@@@@MX,
       .=--------.           -%H.,@@@@@MX,
       .%MM@@@HHHXX$$$%+- .:$MMX =M@@MM%.
         =XMMM@MM@MM#H;,-+HMM@M+ /MMMX=
           =%@M@M#@$-.=$@MM@@@M; %M%=
             ,:+$+-,/H#MMMMMMM@= =,
                   =++%%%%+/:-.
            ");
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.SetCursorPosition((Console.WindowWidth - ("Aperture Science Communications").Length) / 2, Console.CursorTop);
                Console.WriteLine("Aperture Science Communications");
            }
            Console.ResetColor();
        }
    }
}
