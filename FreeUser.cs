using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_Musik_Borvify
{
    public class FreeUser
    {
        // RunFreeUser shares its method
        public virtual void RunFreeUser()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------");
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine($"Welcome Budget Börve!! Choose what you wanna do!");
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
