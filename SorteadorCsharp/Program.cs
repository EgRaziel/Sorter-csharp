using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace SorteadorCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menus.Menu(); // Exibe o menu principal para o usuário
            int opcao = int.Parse(Console.ReadLine()); // Lê a opção escolhida pelo usuário

            // Enquanto a opção não for 0 ou 1, solicita uma opção válida
            while (opcao != 0 && opcao != 1)
            {
                System.Console.WriteLine("Opção inválida!"); // Informa que a opção é inválida
                Menus.Menu(); // Exibe o menu novamente
                opcao = int.Parse(Console.ReadLine()); // Lê nova opção
            }
            if (opcao == 1)
            {
                Menus.EscolhaInicial(); // Inicia o processo de sorteio
            }
            else if (opcao == 0)
            {
                Menus.Sair(); // Encerra o programa
            }
        }
    }
}