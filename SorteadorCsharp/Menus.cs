using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorteadorCsharp
{
    public class Menus
    {
        // Exibe o menu principal na tela
        public static void Menu()
        {
            string barras = new string('=', 37); // Cria uma linha de "=" para o topo e rodapé
            string titulo = "SORTEADOR";
            int largura = barras.Length;
            int espacos = (largura - titulo.Length) / 2; // Calcula espaços para centralizar o título

            System.Threading.Thread.Sleep(400); // Pausa para efeito visual
            System.Console.WriteLine(barras);   // Exibe linha superior
            System.Threading.Thread.Sleep(400);
            Console.WriteLine(new string(' ', espacos) + titulo); // Exibe título centralizado
            System.Threading.Thread.Sleep(400);
            System.Console.WriteLine(barras);   // Exibe linha inferior

            System.Threading.Thread.Sleep(400);
            Console.WriteLine("\n1. Sortear número"); // Opção de sorteio
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("0. Sair");             // Opção de sair
            System.Threading.Thread.Sleep(400);
            Console.Write("\nEscolha uma opção: ");   // Solicita escolha do usuário
        }

        // Solicita os valores iniciais e finais, realiza o sorteio e exibe o resultado
        public static void EscolhaInicial()
        {
            Console.Clear();

            Console.Write("Número Inicial: ");
            int numeroInicial = int.Parse(Console.ReadLine()); // Lê valor inicial
            Console.Write("Número Final: ");
            int numeroFinal = int.Parse(Console.ReadLine());   // Lê valor final

            Sorteador valores = new Sorteador(numeroInicial, numeroFinal); // Cria objeto sorteador
            valores.SortearNumero(); // Realiza o sorteio

            Console.Clear();
            Console.Write($"Resultado: {valores.Resultado}\n"); // Exibe resultado

            RepetirSorteio(); // Pergunta se deseja sortear novamente
        }

        // Solicita valores e realiza sorteio sem repetir o último resultado
        public static void SorteioAlternativo()
        {
            Console.Clear();

            Console.Write("Número Inicial: ");
            int numeroInicial = int.Parse(Console.ReadLine());
            Console.Write("Número Final: ");
            int numeroFinal = int.Parse(Console.ReadLine());

            Sorteador valores = new Sorteador(numeroInicial, numeroFinal);
            valores.SortearNumeroDiferente(); // Sorteia número diferente do anterior

            Console.Clear();
            Console.Write($"Resultado: {valores.Resultado}\n");

            RepetirSorteio();
        }

        // Pergunta ao usuário se deseja sortear outro número
        public static void RepetirSorteio()
        {
            Console.Write($"\nGostaria de sortear outro número?(s/n): ");
            char resposta = char.Parse(Console.ReadLine().ToLower());

            // Valida resposta do usuário
            while (resposta != 's' && resposta != 'n')
            {
                Console.Clear();
                Console.Write("Opção inválida!");
                System.Threading.Thread.Sleep(2000);

                Console.Clear();
                Console.Write("Gostaria de sortear outro número?(s/n): ");
                resposta = char.Parse(Console.ReadLine().ToLower());
            }

            if (resposta == 's')
            {
                RepetirResultado(); // Pergunta se pode repetir o resultado anterior
            }
            else if (resposta == 'n')
            {
                Sair(); // Encerra o programa
            }
        }

        // Pergunta se pode repetir o resultado anterior no novo sorteio
        public static void RepetirResultado()
        {
            Sorteador valores;

            Console.Write($"\nRepetir o resultado no novo sorteio?(s/n): ");
            char resposta = char.Parse(Console.ReadLine().ToLower());

            // Valida resposta do usuário
            while (resposta != 's' && resposta != 'n')
            {
                Console.Clear();
                Console.Write("Opção inválida!");
                System.Threading.Thread.Sleep(500);

                Console.Clear();
                Console.Write("Repetir o resultado no novo sorteio?(s/n): ");
                resposta = char.Parse(Console.ReadLine().ToLower());
            }

            if (resposta == 's')
            {
                EscolhaInicial(); // Sorteia normalmente (pode repetir resultado)
            }
            else if (resposta == 'n')
            {
                SorteioAlternativo(); // Sorteia sem repetir o resultado anterior
            }
        }

        // Exibe mensagem de saída e encerra o programa
        public static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar o sorteador!");
            System.Threading.Thread.Sleep(1000);

            Console.Write("Saindo");
            System.Threading.Thread.Sleep(750);
            Console.Write(".");
            System.Threading.Thread.Sleep(750);
            Console.Write(".");
            System.Threading.Thread.Sleep(750);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);

            Environment.Exit(0); // Finaliza o programa
        }
    }
}