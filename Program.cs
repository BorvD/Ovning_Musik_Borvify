using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Ovning_Musik_Borvify
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Starts RunStartWindow that leads to the FreeUser class
            StartWindow startWindow = new StartWindow();
            startWindow.RunStartWindow();

        }
    }
}
