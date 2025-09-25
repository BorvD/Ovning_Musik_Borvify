using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_Musik_Borvify
{
    public class NemosOrchestra : BandTemplate
    {
        public override void bandTemplate()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Nemo's Orchestra's albums. Choose album by typing the number");
            Console.WriteLine("1: Nemo's Orchestra plays Bach");
            Console.WriteLine("2: Nemo's Orchestra plays Mozart");
            Console.WriteLine("Type:");
        }
    }
}
