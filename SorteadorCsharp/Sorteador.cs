using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorteadorCsharp
{
    public class Sorteador
    {
        // Propriedade para armazenar o número inicial do sorteio
        public int NumeroInicial { get; set; }
        // Propriedade para armazenar o número final do sorteio
        public int NumeroFinal { get; set; }
        // Propriedade para armazenar o resultado do sorteio (apenas leitura externa)
        public int Resultado { get; private set; }

        // Construtor que define os valores inicial e final do sorteio
        public Sorteador(int numeroInicial, int numeroFinal)
        {
            NumeroInicial = numeroInicial;
            NumeroFinal = numeroFinal;
        }

        // Método que sorteia um número entre NumeroInicial e NumeroFinal (inclusive)
        public void SortearNumero()
        {
            Random random = new Random(); // Cria um gerador de números aleatórios
            Resultado = random.Next(NumeroInicial, NumeroFinal + 1); // Sorteia e armazena o resultado
        }

        // Método que sorteia um número diferente do último resultado
        public void SortearNumeroDiferente()
        {
            Random random = new Random(); // Cria um gerador de números aleatórios
            int novoResultado = Resultado; // Inicializa com o resultado atual

            // Repete o sorteio enquanto o novo resultado for igual ao anterior
            // e o intervalo permitir mais de um valor possível
            while (novoResultado == Resultado && NumeroFinal > NumeroInicial)
            {
                novoResultado = random.Next(NumeroInicial, NumeroFinal + 1);
            }

            Resultado = novoResultado; // Atualiza o resultado com o novo valor sorteado
        }
    }
}