using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_Musik_Borvify
{
    // Premium inherits FreeUser class
    public class PremiumUser : FreeUser
    {
        // Overrides RunFreeUser with new code
        public override void RunFreeUser()
        {
            // Welcome statement for Premium Users AKA "Sexy Börve" 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Welcome Sexy Börve!!");
            Console.WriteLine($"Type:");
            Console.WriteLine("1: Go to Band menu");
            Console.WriteLine("2: Change user");

            Console.ForegroundColor = ConsoleColor.Red;
            string musicBandMenu = Console.ReadLine(); 

            if (musicBandMenu == "1")
            {
                MusicBand musicBand = new MusicBand();
                musicBand.RunMusicBand();
            }
            else if (musicBandMenu == "2")
            {
                StartWindow startWindow = new StartWindow();
                startWindow.RunStartWindow();
            }
        }
    }
}
