using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace SorteadorCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menus.Menu();
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 0 && opcao != 1)
            {
                System.Console.WriteLine("Opção inválida!");
                Menus.Menu();
                opcao = int.Parse(Console.ReadLine());
            }
            if (opcao == 1)
            {
                Menus.EscolhaInicial();
            }
            else if (opcao == 0)
            {
                Menus.Sair();
            }
        }
    }
}