using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace SorteadorCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ViewSorter.Menu();

            int option = int.Parse(Console.ReadLine() ?? "0");

            // Keeps asking while the option is not 0 or 1
            while (option != 0 && option != 1)
            {
                Console.Clear();

                System.Console.WriteLine("Invalid Option!");

                System.Threading.Thread.Sleep(2000);
                ViewSorter.Menu();

                option = int.Parse(Console.ReadLine() ?? "0");
            }

            switch (option)
            {
                case 1:
                    ViewSorter.StartChoice();
                    break;
                case 0:
                    ViewSorter.Exit();
                    break;
            }
        }
    }
}