using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha1
{
    class Pecas
    {
        Tabuleiro tab = new Tabuleiro();
        public int d()
        {
            return (tab.Tamanho()-1)/6;// limite para o "X" e o "O"
            
        }

        public void Xa1()
        {
            for (int i = 0; i < d(); i++)
            {
                               
            }
        }
    }
}
