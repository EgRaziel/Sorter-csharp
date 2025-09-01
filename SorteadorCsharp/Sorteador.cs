using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorteadorCsharp
{
    public class Sorteador
    {
        public int NumeroInicial { get; set; }
        public int NumeroFinal { get; set; }
        public int Resultado { get; private set; }

        public Sorteador(int numeroInicial, int numeroFinal)
        {
            NumeroInicial = numeroInicial;
            NumeroFinal = numeroFinal;
        }

        public void SortearNumero()
        {
            Random random = new Random();
            Resultado = random.Next(NumeroInicial, NumeroFinal + 1);
        }

        public void SortearNumeroDiferente()
        {
            Random random = new Random();
            int novoResultado = Resultado;

            while (novoResultado == Resultado && NumeroFinal > NumeroInicial)
            {
                novoResultado = random.Next(NumeroInicial, NumeroFinal + 1);
            }

            Resultado = novoResultado;
        }
    }
}