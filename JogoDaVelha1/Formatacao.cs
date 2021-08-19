using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha1
{
    class Formatacao
    {
        public void Altura()
        {
            Console.Write("\n\n");
        }

        // Traçando uma linha horizontal que percorre toda a janela do console
        int largTotalJanela = Console.WindowWidth;
        public void Linha()
        {
            for (int i = 1; i <= largTotalJanela; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }

        // Estabelecendo uma margem de 30 (5x6) caracteres da borda esquerda da janela do console
        public void MargEsqu()
        {
            Console.Write("\t\t\t\t\t\t");
        }

        // Estabelecendo uma margem de 18 (2x6) caracteres da borda esquerda da janela do console
        public void MargEsquRed()
        {
            Console.Write("\t\t");
        }
    }
}
