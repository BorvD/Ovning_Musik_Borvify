using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_Musik_Borvify
{
     public class MusicBand
    {
        public void RunMusicBand()
        {
            // Text when you reach which band to view its albums
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Type the number of the band to view their albums");
            Console.WriteLine("1: Gun's n Roses");
            Console.WriteLine("2: Nemo's Orchestra");
            Console.WriteLine("3: BorveBand");
            Console.WriteLine("Type:");


        }
    }
}
