using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_Musik_Borvify
{
    public class GunsNRoses : BandTemplate
    {
        public override void bandTemplate()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Guns N Roses's albums. Choose album by typing the number");
            Console.WriteLine("1: Appetite for destruction ");
            Console.WriteLine("2: Spaghetti incident");
            Console.WriteLine("Type:");

        }
    }
}
