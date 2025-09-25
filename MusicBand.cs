using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_Musik_Borvify
{
     public class MusicBand
    {
        public void RunMusicBand()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------");
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Type the number of the band to view their albums");
            Console.ForegroundColor=(ConsoleColor) ConsoleColor.Green;
            Console.WriteLine("1: Gun's n Roses");
            Console.WriteLine("2: Nemo's Orchestra");
            Console.WriteLine("3: BorvBand");

        }
    }
}
