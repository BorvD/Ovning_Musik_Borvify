using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_Musik_Borvify
{
    public class BorveBand : BandTemplate
    {
        public override void bandTemplate()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BorveBands albums. Choose album by typing the number");
            Console.WriteLine("1: Borve screams in the woods");
            Console.WriteLine("2: Borve screams at sea");
            Console.WriteLine("Type:");
        }
    }
}
