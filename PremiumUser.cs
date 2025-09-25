using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_Musik_Borvify
{
    public class PremiumUser : FreeUser
    {
        public override void RunFreeUser()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Welcome Sexy Börve!!");
        }
    }
}
