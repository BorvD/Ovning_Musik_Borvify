using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Ovning_Musik_Borvify
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            // Welcome text
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Welcome to Borvify");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose what type of membership by typing either      '1 = Free User'      '2 = Premium User'");
            Console.ForegroundColor = ConsoleColor.White;

            // How the menu workes done with a "if" statement and Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Type:"); Console.ForegroundColor = ConsoleColor.Red; string TypeOfMembership = Console.ReadLine(); Console.ForegroundColor = ConsoleColor.Yellow;
            // If "1" is typed, it leads to "Free User"
            if (TypeOfMembership == "1")
            {
                // Starts RunFreeUser command that leads into FreeUser class
                FreeUser freeUser = new FreeUser();
                freeUser.RunFreeUser();
            }
            // If "2" is typed, it leads to "Premium User"
            else if (TypeOfMembership == "2")
            {
                // Starts RunFreeUser cammand that leads into PremiumUser class
                PremiumUser premiumUser = new PremiumUser();
                premiumUser.RunFreeUser();
            }

        }
    }
}
