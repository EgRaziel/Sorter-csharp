using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace SorteadorCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menus.Menu();

            int option = int.Parse(Console.ReadLine());

            // Keeps asking while the option is not 0 or 1
            while (option != 0 && option != 1)
            {
                Console.Clear();

                System.Console.WriteLine("Invalid Option!");

                System.Threading.Thread.Sleep(2000);
                Menus.Menu();

                option = int.Parse(Console.ReadLine());
            }

            if (option == 1)
            {
                Menus.StartChoice();
            }
            else if (option == 0)
            {
                Menus.Exit();
            }
        }
    }
}